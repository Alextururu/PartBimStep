using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using SAV;

namespace BimStep_Общие
{
    public partial class FindChangeFrm : System.Windows.Forms.Form
    {
        private Document doc;

        public FindChangeFrm(List<String> allCatDoc, Document _doc)
        {
            InitializeComponent();
            doc = _doc;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler((sender, e) => HelpForms.Form1_KeyDown(e, this));
            this.cbx1.CheckedChanged += new System.EventHandler((sender, e) => HelpForms.cbx1_CheckedChanged(cbx1, cbxl1));
            this.btnYouTube.Click += new System.EventHandler((sender, e) => HelpForms.btnYouTube_Click(HelpYouTubeVideos.GetLink("Найти заменить")));
            this.btnYouTube.MouseEnter += new System.EventHandler(HelpForms.btnYouTube_MouseEnter);
            this.btnYouTube.MouseLeave += new System.EventHandler(HelpForms.btnYouTube_MouseLeave);
            btnYouTube.Image = new Bitmap(Properties.Resources.YouTube_Серый);
            this.btnUpdateMarka.MouseEnter += new System.EventHandler(HelpForms.btn_MouseEnter);
            this.btnUpdateMarka.MouseLeave += new System.EventHandler(HelpForms.btn_MouseLeave);
            new ToolTip().SetToolTip(btnUpdateMarka, TR.GT("Обновить список параметров"));
            this.btnGuide.MouseEnter += new System.EventHandler(HelpForms.btnGuide_MouseEnter);
            this.btnGuide.MouseLeave += new System.EventHandler(HelpForms.btnGuide_MouseLeave);
            btnGuide.Image = new Bitmap(Properties.Resources.BS_info_grey_24);
            this.btnGuide.Click += new System.EventHandler((sender, e) => HelpForms.OpenInstruction("Найти заменить"));
            Location = HelpForms.Position();
            TR.TranslateForm(this);

            Config conf = new Config();
            string param1 = conf.Read("FindChangeFrmtxt1", "");
            txt1.Text = param1;
            string param2 = conf.Read("FindChangeFrmtxt2", "");
            txt2.Text = param2;
            //Вырубаем активность контрола т.к. работа не ведется по категориям
            cbxl1.Enabled = false;
            cbx1.Enabled = false;
            cmb1.Enabled = false;
            rbt1.Checked=true;//Ставим значение положительное чтобы включить первый радиобаттон

            cbxl1.Items.AddRange(allCatDoc.ToArray());
            for (int i = 0; i < cbxl1.Items.Count; i++)
            {
                var item = cbxl1.Items[i];
                if (item.ToString() == conf.Read("FindChangeFrmclb1" + item.ToString(), "Нет"))
                {
                    cbxl1.SetItemChecked(i, true);
                }
            }
        }

        private void FindChangeFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Config conf = new Config();
            conf.Write("X", Location.X.ToString());
            conf.Write("Y", Location.Y.ToString());
            conf.Write("FindChangeFrmtxt1", txt1.Text);
            conf.Write("FindChangeFrmtxt2", txt2.Text);
            CheckedListBox.CheckedItemCollection checkitems1 = cbxl1.CheckedItems;
            for (int i = 0; i < cbxl1.Items.Count; i++)
            {
                object item = cbxl1.Items[i];
                if (checkitems1.Contains(item) == true) conf.Write("FindChangeFrmclb1" + item.ToString(), item.ToString());
                else conf.Write("FindChangeFrmclb1" + item.ToString(), "Нет");
            }
        }

        private void rbt3_CheckedChanged(object sender, EventArgs e)
        {
            cbxl1.Enabled = true;
            cbx1.Enabled = true;
            cmb1.Enabled = true;
        }

        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            cbxl1.Enabled = false;
            cbx1.Enabled = false;
            cmb1.Enabled = false;
        }

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            cbxl1.Enabled = false;
            cbx1.Enabled = false;
            cmb1.Enabled = false;
        }

        private void btnUpdateMarka_Click(object sender, EventArgs e)
        {
            //Собираем список выбранных категорий
            var SelectItems = this.cbxl1.CheckedItems;
            List<string> SelectCat = new List<string>();
            foreach (var i in SelectItems)
            {
                SelectCat.Add(i.ToString());
            }
            //Получаем уникальные текстовые параметры
            List<string> UniqParam = GetAnything.GetUniqTextParametersSelectCategories(doc, SelectCat);//Получаем все никальные ткстовые параметры с элементов
            UniqParam.Sort();//Сортируем список с параметарми
            cmb1.Items.Clear();//Очищаем от того что было раньше
            cmb1.Items.AddRange(UniqParam.ToArray());//Добавляем в контрол список уникальных параметров
        }
    }
}
