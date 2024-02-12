namespace BimStep_Общие
{
    partial class FindChangeFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.cbxl1 = new System.Windows.Forms.CheckedListBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuide = new System.Windows.Forms.Button();
            this.btnYouTube = new System.Windows.Forms.Button();
            this.btnUpdateMarka = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(24, 398);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(179, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Параметр, в котором ищем текст";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(8, 21);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(232, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(8, 19);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(232, 20);
            this.txt2.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.Location = new System.Drawing.Point(180, 588);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 30);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Готово";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(8, 44);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(165, 17);
            this.rbt2.TabIndex = 10;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Все текстовые примечания";
            this.rbt2.UseVisualStyleBackColor = true;
            this.rbt2.CheckedChanged += new System.EventHandler(this.rbt2_CheckedChanged);
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Location = new System.Drawing.Point(8, 70);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(131, 17);
            this.rbt3.TabIndex = 10;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Значение параметра";
            this.rbt3.UseVisualStyleBackColor = true;
            this.rbt3.CheckedChanged += new System.EventHandler(this.rbt3_CheckedChanged);
            // 
            // cbxl1
            // 
            this.cbxl1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxl1.CheckOnClick = true;
            this.cbxl1.FormattingEnabled = true;
            this.cbxl1.HorizontalScrollbar = true;
            this.cbxl1.Location = new System.Drawing.Point(8, 116);
            this.cbxl1.Name = "cbxl1";
            this.cbxl1.Size = new System.Drawing.Size(232, 244);
            this.cbxl1.TabIndex = 11;
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Location = new System.Drawing.Point(8, 366);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(91, 17);
            this.cbx1.TabIndex = 12;
            this.cbx1.Text = "Выбрать все";
            this.cbx1.UseVisualStyleBackColor = true;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(8, 417);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(232, 21);
            this.cmb1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdateMarka);
            this.groupBox1.Controls.Add(this.cmb1);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.cbx1);
            this.groupBox1.Controls.Add(this.rbt3);
            this.groupBox1.Controls.Add(this.cbxl1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Location = new System.Drawing.Point(15, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 451);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Элемент для переименования";
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(8, 19);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(113, 17);
            this.rbt1.TabIndex = 10;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Выбранные виды";
            this.rbt1.UseVisualStyleBackColor = true;
            this.rbt1.CheckedChanged += new System.EventHandler(this.rbt1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Location = new System.Drawing.Point(15, 476);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 50);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходный текст";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.txt2);
            this.groupBox3.Location = new System.Drawing.Point(15, 531);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 51);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Новый текст";
            // 
            // btnGuide
            // 
            this.btnGuide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuide.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuide.FlatAppearance.BorderSize = 0;
            this.btnGuide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuide.Image = global::BimStep_Общие.Properties.Resources.BS_info_color_24;
            this.btnGuide.Location = new System.Drawing.Point(68, 590);
            this.btnGuide.Name = "btnGuide";
            this.btnGuide.Size = new System.Drawing.Size(46, 32);
            this.btnGuide.TabIndex = 27;
            this.btnGuide.UseVisualStyleBackColor = false;
            // 
            // btnYouTube
            // 
            this.btnYouTube.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYouTube.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnYouTube.FlatAppearance.BorderSize = 0;
            this.btnYouTube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYouTube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYouTube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYouTube.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYouTube.Image = global::BimStep_Общие.Properties.Resources.YouTube;
            this.btnYouTube.Location = new System.Drawing.Point(16, 590);
            this.btnYouTube.Name = "btnYouTube";
            this.btnYouTube.Size = new System.Drawing.Size(46, 32);
            this.btnYouTube.TabIndex = 17;
            this.btnYouTube.UseVisualStyleBackColor = false;
            // 
            // btnUpdateMarka
            // 
            this.btnUpdateMarka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateMarka.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarka.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarka.FlatAppearance.BorderSize = 0;
            this.btnUpdateMarka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMarka.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateMarka.Image = global::BimStep_Общие.Properties.Resources.BS_refresh_32;
            this.btnUpdateMarka.Location = new System.Drawing.Point(208, 366);
            this.btnUpdateMarka.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMarka.Name = "btnUpdateMarka";
            this.btnUpdateMarka.Size = new System.Drawing.Size(32, 32);
            this.btnUpdateMarka.TabIndex = 59;
            this.btnUpdateMarka.UseVisualStyleBackColor = false;
            this.btnUpdateMarka.Click += new System.EventHandler(this.btnUpdateMarka_Click);
            // 
            // FindChangeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 626);
            this.Controls.Add(this.btnGuide);
            this.Controls.Add(this.btnYouTube);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FindChangeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Найти заменить";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindChangeFrm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.TextBox txt1;
        public System.Windows.Forms.TextBox txt2;
        public System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.CheckedListBox cbxl1;
        public System.Windows.Forms.CheckBox cbx1;
        public System.Windows.Forms.ComboBox cmb1;
        public System.Windows.Forms.RadioButton rbt2;
        public System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnYouTube;
        public System.Windows.Forms.Button btnUpdateMarka;
        private System.Windows.Forms.Button btnGuide;
    }
}