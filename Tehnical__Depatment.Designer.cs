namespace _312
{
    partial class Tehnical__Depatment
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
            this.buttonDel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxWork_Process = new System.Windows.Forms.ComboBox();
            this.labelWork_Process = new System.Windows.Forms.Label();
            this.listViewTehnical_Depatment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelId_Contract = new System.Windows.Forms.Label();
            this.comboBoxContract = new System.Windows.Forms.ComboBox();
            this.comboBoxId_Employee = new System.Windows.Forms.ComboBox();
            this.labelId_Employee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(616, 356);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 25;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_312.Properties.Resources.unnamed__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxWork_Process
            // 
            this.comboBoxWork_Process.FormattingEnabled = true;
            this.comboBoxWork_Process.Items.AddRange(new object[] {
            "Остановлен",
            "Запущен",
            "В очереди"});
            this.comboBoxWork_Process.Location = new System.Drawing.Point(12, 124);
            this.comboBoxWork_Process.Name = "comboBoxWork_Process";
            this.comboBoxWork_Process.Size = new System.Drawing.Size(138, 21);
            this.comboBoxWork_Process.TabIndex = 28;
            // 
            // labelWork_Process
            // 
            this.labelWork_Process.AutoSize = true;
            this.labelWork_Process.Location = new System.Drawing.Point(9, 108);
            this.labelWork_Process.Name = "labelWork_Process";
            this.labelWork_Process.Size = new System.Drawing.Size(81, 13);
            this.labelWork_Process.TabIndex = 30;
            this.labelWork_Process.Text = "Статус работы";
            // 
            // listViewTehnical_Depatment
            // 
            this.listViewTehnical_Depatment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewTehnical_Depatment.FullRowSelect = true;
            this.listViewTehnical_Depatment.GridLines = true;
            this.listViewTehnical_Depatment.HideSelection = false;
            this.listViewTehnical_Depatment.Location = new System.Drawing.Point(165, 12);
            this.listViewTehnical_Depatment.MultiSelect = false;
            this.listViewTehnical_Depatment.Name = "listViewTehnical_Depatment";
            this.listViewTehnical_Depatment.Size = new System.Drawing.Size(613, 282);
            this.listViewTehnical_Depatment.TabIndex = 31;
            this.listViewTehnical_Depatment.UseCompatibleStateImageBehavior = false;
            this.listViewTehnical_Depatment.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id Договора";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Id услуги";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Разработчик";
            this.columnHeader3.Width = 129;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус работы";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Дата сдачи";
            this.columnHeader5.Width = 114;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(413, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 38;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // labelId_Contract
            // 
            this.labelId_Contract.AutoSize = true;
            this.labelId_Contract.Location = new System.Drawing.Point(12, 12);
            this.labelId_Contract.Name = "labelId_Contract";
            this.labelId_Contract.Size = new System.Drawing.Size(72, 13);
            this.labelId_Contract.TabIndex = 39;
            this.labelId_Contract.Text = "Id_Договора";
            // 
            // comboBoxContract
            // 
            this.comboBoxContract.FormattingEnabled = true;
            this.comboBoxContract.Items.AddRange(new object[] {
            "Остановлен",
            "Запущен",
            "В очереди"});
            this.comboBoxContract.Location = new System.Drawing.Point(12, 28);
            this.comboBoxContract.Name = "comboBoxContract";
            this.comboBoxContract.Size = new System.Drawing.Size(138, 21);
            this.comboBoxContract.TabIndex = 40;
            // 
            // comboBoxId_Employee
            // 
            this.comboBoxId_Employee.FormattingEnabled = true;
            this.comboBoxId_Employee.Items.AddRange(new object[] {
            "Остановлен",
            "Запущен",
            "В очереди"});
            this.comboBoxId_Employee.Location = new System.Drawing.Point(12, 71);
            this.comboBoxId_Employee.Name = "comboBoxId_Employee";
            this.comboBoxId_Employee.Size = new System.Drawing.Size(138, 21);
            this.comboBoxId_Employee.TabIndex = 41;
            // 
            // labelId_Employee
            // 
            this.labelId_Employee.AutoSize = true;
            this.labelId_Employee.Location = new System.Drawing.Point(10, 55);
            this.labelId_Employee.Name = "labelId_Employee";
            this.labelId_Employee.Size = new System.Drawing.Size(78, 13);
            this.labelId_Employee.TabIndex = 42;
            this.labelId_Employee.Text = "Разработчика";
            // 
            // Tehnical__Depatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelId_Employee);
            this.Controls.Add(this.comboBoxId_Employee);
            this.Controls.Add(this.comboBoxContract);
            this.Controls.Add(this.labelId_Contract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewTehnical_Depatment);
            this.Controls.Add(this.labelWork_Process);
            this.Controls.Add(this.comboBoxWork_Process);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDel);
            this.Name = "Tehnical__Depatment";
            this.Text = "Tehnical__Depatment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxWork_Process;
        private System.Windows.Forms.Label labelWork_Process;
        private System.Windows.Forms.ListView listViewTehnical_Depatment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelId_Contract;
        private System.Windows.Forms.ComboBox comboBoxContract;
        private System.Windows.Forms.ComboBox comboBoxId_Employee;
        private System.Windows.Forms.Label labelId_Employee;
    }
}