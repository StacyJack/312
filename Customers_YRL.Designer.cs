namespace _312
{
    partial class Customers_YRL
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
            this.listViewCustomers_YRL = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxName_Company = new System.Windows.Forms.TextBox();
            this.labelName_Company = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMaill = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMaill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewCustomers_YRL
            // 
            this.listViewCustomers_YRL.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCustomers_YRL.FullRowSelect = true;
            this.listViewCustomers_YRL.GridLines = true;
            this.listViewCustomers_YRL.HideSelection = false;
            this.listViewCustomers_YRL.Location = new System.Drawing.Point(175, 12);
            this.listViewCustomers_YRL.MultiSelect = false;
            this.listViewCustomers_YRL.Name = "listViewCustomers_YRL";
            this.listViewCustomers_YRL.Size = new System.Drawing.Size(613, 282);
            this.listViewCustomers_YRL.TabIndex = 26;
            this.listViewCustomers_YRL.UseCompatibleStateImageBehavior = false;
            this.listViewCustomers_YRL.View = System.Windows.Forms.View.Details;
            this.listViewCustomers_YRL.SelectedIndexChanged += new System.EventHandler(this.listViewCustomers_YRL_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id заказчика";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название организации";
            this.columnHeader2.Width = 205;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Телефон";
            this.columnHeader3.Width = 151;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Почта";
            this.columnHeader4.Width = 156;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(330, 349);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(478, 349);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 28;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(616, 349);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 29;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxName_Company
            // 
            this.textBoxName_Company.Location = new System.Drawing.Point(12, 33);
            this.textBoxName_Company.Name = "textBoxName_Company";
            this.textBoxName_Company.Size = new System.Drawing.Size(140, 20);
            this.textBoxName_Company.TabIndex = 30;
            // 
            // labelName_Company
            // 
            this.labelName_Company.AutoSize = true;
            this.labelName_Company.Location = new System.Drawing.Point(10, 18);
            this.labelName_Company.Name = "labelName_Company";
            this.labelName_Company.Size = new System.Drawing.Size(125, 13);
            this.labelName_Company.TabIndex = 31;
            this.labelName_Company.Text = "Название организации";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(12, 78);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(140, 20);
            this.textBoxPhone.TabIndex = 32;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxPhone_KeyPress);
            // 
            // textBoxMaill
            // 
            this.textBoxMaill.Location = new System.Drawing.Point(12, 123);
            this.textBoxMaill.Name = "textBoxMaill";
            this.textBoxMaill.Size = new System.Drawing.Size(140, 20);
            this.textBoxMaill.TabIndex = 33;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(12, 62);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 34;
            this.labelPhone.Text = "Телефон";
            // 
            // labelMaill
            // 
            this.labelMaill.AutoSize = true;
            this.labelMaill.Location = new System.Drawing.Point(12, 107);
            this.labelMaill.Name = "labelMaill";
            this.labelMaill.Size = new System.Drawing.Size(37, 13);
            this.labelMaill.TabIndex = 35;
            this.labelMaill.Text = "Почта";
            // 
            // Customers_YRL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.labelMaill);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxMaill);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelName_Company);
            this.Controls.Add(this.textBoxName_Company);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewCustomers_YRL);
            this.Name = "Customers_YRL";
            this.Text = "Customers_YRL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewCustomers_YRL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxName_Company;
        private System.Windows.Forms.Label labelName_Company;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxMaill;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMaill;
    }
}