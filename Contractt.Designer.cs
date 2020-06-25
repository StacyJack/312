namespace _312
{
    partial class Contractt
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
            this.listViewContractt = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.comboBoxId_Customers = new System.Windows.Forms.ComboBox();
            this.comboBoxId_Services = new System.Windows.Forms.ComboBox();
            this.comboBoxId_Depatment = new System.Windows.Forms.ComboBox();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelId_Company = new System.Windows.Forms.Label();
            this.labelId_Customers = new System.Windows.Forms.Label();
            this.labelId_Services = new System.Windows.Forms.Label();
            this.labelId_Depatment = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.label_End = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxCustomersYR_L = new System.Windows.Forms.ComboBox();
            this.labelCustomersYR_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewContractt
            // 
            this.listViewContractt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewContractt.FullRowSelect = true;
            this.listViewContractt.GridLines = true;
            this.listViewContractt.HideSelection = false;
            this.listViewContractt.Location = new System.Drawing.Point(175, 12);
            this.listViewContractt.MultiSelect = false;
            this.listViewContractt.Name = "listViewContractt";
            this.listViewContractt.Size = new System.Drawing.Size(733, 282);
            this.listViewContractt.TabIndex = 24;
            this.listViewContractt.UseCompatibleStateImageBehavior = false;
            this.listViewContractt.View = System.Windows.Forms.View.Details;
            this.listViewContractt.SelectedIndexChanged += new System.EventHandler(this.listViewContractt_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Контракта";
            this.columnHeader1.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id Компания";
            this.columnHeader2.Width = 69;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id Заказчика Ф.л";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id Заказчика Юр.л";
            this.columnHeader9.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Услуга";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Отдел";
            this.columnHeader5.Width = 47;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Начало разработки";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Конец срока";
            this.columnHeader7.Width = 72;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Цена";
            this.columnHeader8.Width = 62;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(347, 362);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 26;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(476, 362);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(597, 362);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 28;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Location = new System.Drawing.Point(12, 38);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCompany.TabIndex = 29;
            // 
            // comboBoxId_Customers
            // 
            this.comboBoxId_Customers.FormattingEnabled = true;
            this.comboBoxId_Customers.Location = new System.Drawing.Point(12, 83);
            this.comboBoxId_Customers.Name = "comboBoxId_Customers";
            this.comboBoxId_Customers.Size = new System.Drawing.Size(146, 21);
            this.comboBoxId_Customers.TabIndex = 30;
            // 
            // comboBoxId_Services
            // 
            this.comboBoxId_Services.FormattingEnabled = true;
            this.comboBoxId_Services.Location = new System.Drawing.Point(12, 167);
            this.comboBoxId_Services.Name = "comboBoxId_Services";
            this.comboBoxId_Services.Size = new System.Drawing.Size(146, 21);
            this.comboBoxId_Services.TabIndex = 31;
            // 
            // comboBoxId_Depatment
            // 
            this.comboBoxId_Depatment.FormattingEnabled = true;
            this.comboBoxId_Depatment.Items.AddRange(new object[] {
            "Технический отдел",
            "Информационный отдел"});
            this.comboBoxId_Depatment.Location = new System.Drawing.Point(12, 207);
            this.comboBoxId_Depatment.Name = "comboBoxId_Depatment";
            this.comboBoxId_Depatment.Size = new System.Drawing.Size(146, 21);
            this.comboBoxId_Depatment.TabIndex = 32;
            // 
            // textBoxStart
            // 
            this.textBoxStart.Location = new System.Drawing.Point(12, 247);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(146, 20);
            this.textBoxStart.TabIndex = 34;
            this.textBoxStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeid_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 286);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDeid_KeyPress);
            // 
            // labelId_Company
            // 
            this.labelId_Company.AutoSize = true;
            this.labelId_Company.Location = new System.Drawing.Point(12, 23);
            this.labelId_Company.Name = "labelId_Company";
            this.labelId_Company.Size = new System.Drawing.Size(58, 13);
            this.labelId_Company.TabIndex = 36;
            this.labelId_Company.Text = "Компания";
            // 
            // labelId_Customers
            // 
            this.labelId_Customers.AutoSize = true;
            this.labelId_Customers.Location = new System.Drawing.Point(12, 68);
            this.labelId_Customers.Name = "labelId_Customers";
            this.labelId_Customers.Size = new System.Drawing.Size(108, 13);
            this.labelId_Customers.TabIndex = 37;
            this.labelId_Customers.Text = "Заказчик Физ.лицо";
            // 
            // labelId_Services
            // 
            this.labelId_Services.AutoSize = true;
            this.labelId_Services.Location = new System.Drawing.Point(9, 151);
            this.labelId_Services.Name = "labelId_Services";
            this.labelId_Services.Size = new System.Drawing.Size(43, 13);
            this.labelId_Services.TabIndex = 38;
            this.labelId_Services.Text = "Услуга";
            // 
            // labelId_Depatment
            // 
            this.labelId_Depatment.AutoSize = true;
            this.labelId_Depatment.Location = new System.Drawing.Point(9, 191);
            this.labelId_Depatment.Name = "labelId_Depatment";
            this.labelId_Depatment.Size = new System.Drawing.Size(76, 13);
            this.labelId_Depatment.TabIndex = 39;
            this.labelId_Depatment.Text = "Департамент";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(9, 231);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(44, 13);
            this.labelStart.TabIndex = 41;
            this.labelStart.Text = "Начало";
            // 
            // label_End
            // 
            this.label_End.AutoSize = true;
            this.label_End.Location = new System.Drawing.Point(12, 270);
            this.label_End.Name = "label_End";
            this.label_End.Size = new System.Drawing.Size(38, 13);
            this.label_End.TabIndex = 42;
            this.label_End.Text = "Конец";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(12, 325);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(146, 20);
            this.textBoxPrice.TabIndex = 43;
            this.textBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrice_KeyPress);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 309);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 44;
            this.labelPrice.Text = "Цена";
            // 
            // comboBoxCustomersYR_L
            // 
            this.comboBoxCustomersYR_L.FormattingEnabled = true;
            this.comboBoxCustomersYR_L.Location = new System.Drawing.Point(12, 127);
            this.comboBoxCustomersYR_L.Name = "comboBoxCustomersYR_L";
            this.comboBoxCustomersYR_L.Size = new System.Drawing.Size(146, 21);
            this.comboBoxCustomersYR_L.TabIndex = 45;
            // 
            // labelCustomersYR_L
            // 
            this.labelCustomersYR_L.AutoSize = true;
            this.labelCustomersYR_L.Location = new System.Drawing.Point(12, 111);
            this.labelCustomersYR_L.Name = "labelCustomersYR_L";
            this.labelCustomersYR_L.Size = new System.Drawing.Size(100, 13);
            this.labelCustomersYR_L.TabIndex = 46;
            this.labelCustomersYR_L.Text = "Заказчик Юр.лицо";
            // 
            // Contractt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 448);
            this.Controls.Add(this.labelCustomersYR_L);
            this.Controls.Add(this.comboBoxCustomersYR_L);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label_End);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelId_Depatment);
            this.Controls.Add(this.labelId_Services);
            this.Controls.Add(this.labelId_Customers);
            this.Controls.Add(this.labelId_Company);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBoxStart);
            this.Controls.Add(this.comboBoxId_Depatment);
            this.Controls.Add(this.comboBoxId_Services);
            this.Controls.Add(this.comboBoxId_Customers);
            this.Controls.Add(this.comboBoxCompany);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewContractt);
            this.Name = "Contractt";
            this.Text = "Contractt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewContractt;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.ComboBox comboBoxId_Customers;
        private System.Windows.Forms.ComboBox comboBoxId_Services;
        private System.Windows.Forms.ComboBox comboBoxId_Depatment;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelId_Company;
        private System.Windows.Forms.Label labelId_Customers;
        private System.Windows.Forms.Label labelId_Services;
        private System.Windows.Forms.Label labelId_Depatment;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label label_End;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox comboBoxCustomersYR_L;
        private System.Windows.Forms.Label labelCustomersYR_L;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}