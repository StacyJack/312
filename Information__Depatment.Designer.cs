namespace _312
{
    partial class Information__Depatment
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
            this.listViewInformation_Depatment = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDel = new System.Windows.Forms.Button();
            this.labelWork_Process = new System.Windows.Forms.Label();
            this.comboBoxWork_Process = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxId_Contract = new System.Windows.Forms.ComboBox();
            this.labelId_Contract = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewInformation_Depatment
            // 
            this.listViewInformation_Depatment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewInformation_Depatment.FullRowSelect = true;
            this.listViewInformation_Depatment.GridLines = true;
            this.listViewInformation_Depatment.HideSelection = false;
            this.listViewInformation_Depatment.Location = new System.Drawing.Point(175, 12);
            this.listViewInformation_Depatment.MultiSelect = false;
            this.listViewInformation_Depatment.Name = "listViewInformation_Depatment";
            this.listViewInformation_Depatment.Size = new System.Drawing.Size(613, 282);
            this.listViewInformation_Depatment.TabIndex = 23;
            this.listViewInformation_Depatment.UseCompatibleStateImageBehavior = false;
            this.listViewInformation_Depatment.View = System.Windows.Forms.View.Details;
            this.listViewInformation_Depatment.SelectedIndexChanged += new System.EventHandler(this.listViewInformation_Depatment_SelectedIndexChanged);
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
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(654, 347);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 26;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // labelWork_Process
            // 
            this.labelWork_Process.AutoSize = true;
            this.labelWork_Process.Location = new System.Drawing.Point(9, 144);
            this.labelWork_Process.Name = "labelWork_Process";
            this.labelWork_Process.Size = new System.Drawing.Size(81, 13);
            this.labelWork_Process.TabIndex = 32;
            this.labelWork_Process.Text = "Статус работы";
            // 
            // comboBoxWork_Process
            // 
            this.comboBoxWork_Process.FormattingEnabled = true;
            this.comboBoxWork_Process.Items.AddRange(new object[] {
            "Остановлен",
            "Запущен",
            "В очереди"});
            this.comboBoxWork_Process.Location = new System.Drawing.Point(12, 160);
            this.comboBoxWork_Process.Name = "comboBoxWork_Process";
            this.comboBoxWork_Process.Size = new System.Drawing.Size(157, 21);
            this.comboBoxWork_Process.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_312.Properties.Resources.unnamed__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(12, 87);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(157, 21);
            this.comboBoxEmployee.TabIndex = 35;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(9, 71);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(72, 13);
            this.labelEmployee.TabIndex = 36;
            this.labelEmployee.Text = "Разработчик";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(408, 347);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxId_Contract
            // 
            this.comboBoxId_Contract.FormattingEnabled = true;
            this.comboBoxId_Contract.Items.AddRange(new object[] {
            "Остановлен",
            "Запущен",
            "В очереди"});
            this.comboBoxId_Contract.Location = new System.Drawing.Point(12, 27);
            this.comboBoxId_Contract.Name = "comboBoxId_Contract";
            this.comboBoxId_Contract.Size = new System.Drawing.Size(157, 21);
            this.comboBoxId_Contract.TabIndex = 38;
            // 
            // labelId_Contract
            // 
            this.labelId_Contract.AutoSize = true;
            this.labelId_Contract.Location = new System.Drawing.Point(12, 13);
            this.labelId_Contract.Name = "labelId_Contract";
            this.labelId_Contract.Size = new System.Drawing.Size(69, 13);
            this.labelId_Contract.TabIndex = 39;
            this.labelId_Contract.Text = "Id Договора";
            // 
            // Information__Depatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelId_Contract);
            this.Controls.Add(this.comboBoxId_Contract);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxWork_Process);
            this.Controls.Add(this.labelWork_Process);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listViewInformation_Depatment);
            this.Name = "Information__Depatment";
            this.Text = "Information__Depatment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewInformation_Depatment;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Label labelWork_Process;
        private System.Windows.Forms.ComboBox comboBoxWork_Process;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxId_Contract;
        private System.Windows.Forms.Label labelId_Contract;
    }
}