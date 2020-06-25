namespace _312
{
    partial class Developerss
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
            this.listViewDeveloperss = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxPatronumic = new System.Windows.Forms.TextBox();
            this.comboBoxDepatment = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPatronumic = new System.Windows.Forms.Label();
            this.labelDepatment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDeveloperss
            // 
            this.listViewDeveloperss.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewDeveloperss.FullRowSelect = true;
            this.listViewDeveloperss.GridLines = true;
            this.listViewDeveloperss.HideSelection = false;
            this.listViewDeveloperss.Location = new System.Drawing.Point(175, 12);
            this.listViewDeveloperss.MultiSelect = false;
            this.listViewDeveloperss.Name = "listViewDeveloperss";
            this.listViewDeveloperss.Size = new System.Drawing.Size(613, 282);
            this.listViewDeveloperss.TabIndex = 24;
            this.listViewDeveloperss.UseCompatibleStateImageBehavior = false;
            this.listViewDeveloperss.View = System.Windows.Forms.View.Details;
            this.listViewDeveloperss.SelectedIndexChanged += new System.EventHandler(this.listViewDeveloperss_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id разработчика";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Фамилия";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Отчество";
            this.columnHeader4.Width = 95;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Отдел разработки";
            this.columnHeader5.Width = 163;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(310, 353);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(466, 353);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(610, 353);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 27;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 20);
            this.textBoxName.TabIndex = 28;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 79);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(133, 20);
            this.textBoxSurname.TabIndex = 29;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxPatronumic
            // 
            this.textBoxPatronumic.Location = new System.Drawing.Point(12, 122);
            this.textBoxPatronumic.Name = "textBoxPatronumic";
            this.textBoxPatronumic.Size = new System.Drawing.Size(133, 20);
            this.textBoxPatronumic.TabIndex = 30;
            this.textBoxPatronumic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // comboBoxDepatment
            // 
            this.comboBoxDepatment.FormattingEnabled = true;
            this.comboBoxDepatment.Items.AddRange(new object[] {
            "Технический отдел",
            "Информационный отдел"});
            this.comboBoxDepatment.Location = new System.Drawing.Point(12, 171);
            this.comboBoxDepatment.Name = "comboBoxDepatment";
            this.comboBoxDepatment.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDepatment.TabIndex = 31;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 32;
            this.labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 63);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(56, 13);
            this.labelSurname.TabIndex = 33;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelPatronumic
            // 
            this.labelPatronumic.AutoSize = true;
            this.labelPatronumic.Location = new System.Drawing.Point(12, 106);
            this.labelPatronumic.Name = "labelPatronumic";
            this.labelPatronumic.Size = new System.Drawing.Size(54, 13);
            this.labelPatronumic.TabIndex = 34;
            this.labelPatronumic.Text = "Отчество";
            // 
            // labelDepatment
            // 
            this.labelDepatment.AutoSize = true;
            this.labelDepatment.Location = new System.Drawing.Point(12, 155);
            this.labelDepatment.Name = "labelDepatment";
            this.labelDepatment.Size = new System.Drawing.Size(100, 13);
            this.labelDepatment.TabIndex = 35;
            this.labelDepatment.Text = "Отдел разработки";
            // 
            // Developerss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelDepatment);
            this.Controls.Add(this.labelPatronumic);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxDepatment);
            this.Controls.Add(this.textBoxPatronumic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDeveloperss);
            this.Name = "Developerss";
            this.Text = "Developerss";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDeveloperss;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxPatronumic;
        private System.Windows.Forms.ComboBox comboBoxDepatment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPatronumic;
        private System.Windows.Forms.Label labelDepatment;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}