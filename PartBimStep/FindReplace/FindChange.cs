using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Application = Autodesk.Revit.ApplicationServices.Application;

namespace BimStep_Общие
{
    [Transaction(TransactionMode.Manual)]
    public class FindChange : IExternalCommand
    {
        private UIDocument uidoc;
        private Document doc;
        private FindChangeFrm f1;
        private List<Element> views;
        private Dictionary<BuiltInCategory, string> dict;

        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            doc = uidoc.Document;

            dict = new Dictionary<BuiltInCategory, string>();
            List<String> allCat = new List<String>();
            //Получаем все категории в документе, записываем в 2 списка имена и сами категории а потом создаем из них словарь
            IList<Element> allElems = new FilteredElementCollector(doc).WhereElementIsNotElementType().ToElements();
            List<ElementId> allCatdoc = allElems.Where(x => x.Category != null && x.Category.Name != null && x.Category.AllowsBoundParameters == true).
                Select(x => x.Category.Id).Distinct().ToList();
            foreach (ElementId catId in allCatdoc)
            {
                Category a = Category.GetCategory(doc, catId);
                if (a != null)
                {
                    allCat.Add(a.Name);
                    BuiltInCategory myCatEnum = (BuiltInCategory)Enum.Parse(typeof(BuiltInCategory), Convert.ToString(a.Id));
                    dict.Add(myCatEnum, a.Name);
                }
            }
            allCat.Sort(new NameComparer());


            f1 = new FindChangeFrm( allCat, doc);
            f1.btnOk.Click += new EventHandler(Ok_Click);
            f1.ShowDialog();
            return Result.Succeeded;
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            string naiti = f1.txt1.Text;
            string zamenit = f1.txt2.Text;
            using (Transaction tx = new Transaction(doc))
            {
                tx.Start(Constant.ModuleName + TR.GT(" Найти и заменить"));

                #region Работаем если пользователь выбрал переименование выбранных видов
                if (f1.rbt1.Checked)
                {
                    if (String.IsNullOrEmpty(naiti) == false)
                    {
                        Selection sel = uidoc.Selection;
                        ICollection<ElementId> ids = sel.GetElementIds();
                        views = new List<Element>();
                        int countView = ids.Where(x=> (doc.GetElement(x) is Autodesk.Revit.DB.View)).Count();
                        if (countView == 0)
                        {
                            MessageBox.Show(TR.GT("Выберите виды"), TR.GT("Сообщение"));
                            return;
                        }
                        else
                        {
                            foreach (ElementId id in ids)
                            {
                                Element el = doc.GetElement(id);
                                el.Name = el.Name.Replace(naiti, zamenit);
                            }
                        }
                    }
                }
                #endregion

                #region Работаем если пользователь выбрал переименование текста в модели
                if (f1.rbt2.Checked)
                {
                    IList<Element> AllText = new FilteredElementCollector(doc).OfCategory(BuiltInCategory.OST_TextNotes).WhereElementIsNotElementType().ToElements();
                    foreach (Element t in AllText)
                    {
                        TextNote tn = t as TextNote;
                        if (tn.Text.Contains(naiti))
                        {
                            tn.Text = tn.Text.Replace(naiti, zamenit);
                        }
                    }
                }
                #endregion

                #region Работаем если пользователь выбрал переименование значения параметра элементов
                if (f1.rbt3.Checked)
                {
                    string parameterName = f1.cmb1.Text;//получаем имя выбранного параметра
                    if (AllChecks.CheckEmptyStringWithMessage(parameterName, TR.GT("Не задан параметр"))) { return; };//Проверка строки
                    //Получаем все категории, которые мы выбрали в форме в вид текста, а потом ищем их в словаре
                    var checkList = f1.cbxl1.CheckedItems;
                    if (checkList.Count == 0)
                    {
                        MessageBox.Show(TR.GT("Не выбраны категории"));
                        return;
                    }
                    List<BuiltInCategory> ListCheckCategories = dict.Where(x => checkList.Contains(x.Value)).Select(x => x.Key).ToList();
                    // На основе этого списка создаём список фильтров по категории
                    List<ElementFilter> a = ListCheckCategories.Select(x => new ElementCategoryFilter(x) as ElementFilter).ToList();
                    // Объединяем все эти фильтры в один
                    LogicalOrFilter categoryFilter = new LogicalOrFilter(a);
                    IList<Element> Elements = new FilteredElementCollector(doc).WherePasses(categoryFilter).WhereElementIsNotElementType().ToElements();
                    //Теперь проходимся по элементам и пытаемся переписать значение параметра в нем или в типе
                    List<ElementId> SuccsessTypes = new List<ElementId>();//Делаем пустой список для айдишек типов по которым уже прошлись, чтобы не проходиться еще раз
                    foreach (Element i in Elements)
                    {
                        Parameter pIns = i.LookupParameter(parameterName);
                        if (pIns!=null && pIns.IsReadOnly == false)//Мы нашли что это параметр экземпляра поэтому можем работать с ним и его перезаписывать
                        {
                            string oldValue = pIns.AsString();//Получаем старое значение параметра
                            if (oldValue != null && oldValue.Contains(naiti))//Проверяем не нулевое ли оно и есть ли в нем точно значение которое нужно поменять
                            {
                                pIns.Set(pIns.AsString().Replace(naiti, zamenit));
                            }
                        }
                        if (pIns==null)//Значит мы не нашли параметр в экзепляре давай ка попробуем в типе
                        {
                            ElementId typeId = i.GetTypeId();
                            if (typeId!=null)
                            {
                                if (SuccsessTypes.Contains(typeId)==false)//Проверяем а не проходили ли мы ранее по этому типу, если нет то работаем дальше
                                {
                                    Element type = doc.GetElement(typeId);
                                    if (type!=null)
                                    {
                                        Parameter pType = type.LookupParameter(parameterName);
                                        if (pType != null && pType.IsReadOnly == false)//Мы нашли что это параметр типа поэтому можем работать с ним и его перезаписывать
                                        {
                                            string oldValue = pType.AsString();//Получаем старое значение параметра
                                            if (oldValue != null && oldValue.Contains(naiti))//Проверяем не нулевое ли оно и есть ли в нем точно значение которое нужно поменять
                                            {
                                                pType.Set(pType.AsString().Replace(naiti, zamenit));
                                                SuccsessTypes.Add(typeId);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion

                tx.Commit();
            }
        }
    }
}

