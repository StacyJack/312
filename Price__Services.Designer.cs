namespace _312
{
    partial class Price__Services
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
            this.listViewPrice_Services = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxDepatment = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelDepatment = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewPrice_Services
            // 
            this.listViewPrice_Services.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPrice_Services.FullRowSelect = true;
            this.listViewPrice_Services.GridLines = true;
            this.listViewPrice_Services.HideSelection = false;
            this.listViewPrice_Services.Location = new System.Drawing.Point(184, 12);
            this.listViewPrice_Services.MultiSelect = false;
            this.listViewPrice_Services.Name = "listViewPrice_Services";
            this.listViewPrice_Services.Size = new System.Drawing.Size(613, 282);
            this.listViewPrice_Services.TabIndex = 21;
            this.listViewPrice_Services.UseCompatibleStateImageBehavior = false;
            this.listViewPrice_Services.View = System.Windows.Forms.View.Details;
            this.listViewPrice_Services.SelectedIndexChanged += new System.EventHandler(this.listViewPrice_Services_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id услуги";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Название услуги";
            this.columnHeader2.Width = 299;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отдел разработки";
            this.columnHeader3.Width = 233;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(327, 369);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(91, 30);
            this.buttonAdd.TabIndex = 22;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(448, 369);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(91, 30);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(570, 369);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(91, 30);
            this.buttonDel.TabIndex = 24;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(5, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // comboBoxDepatment
            // 
            this.comboBoxDepatment.FormattingEnabled = true;
            this.comboBoxDepatment.Items.AddRange(new object[] {
            "Технический отдел",
            "Информационный отдел"});
            this.comboBoxDepatment.Location = new System.Drawing.Point(5, 96);
            this.comboBoxDepatment.Name = "comboBoxDepatment";
            this.comboBoxDepatment.Size = new System.Drawing.Size(160, 21);
            this.comboBoxDepatment.TabIndex = 26;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(2, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(93, 13);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "Название услуги";
            // 
            // labelDepatment
            // 
            this.labelDepatment.AutoSize = true;
            this.labelDepatment.Location = new System.Drawing.Point(2, 80);
            this.labelDepatment.Name = "labelDepatment";
            this.labelDepatment.Size = new System.Drawing.Size(100, 13);
            this.labelDepatment.TabIndex = 28;
            this.labelDepatment.Text = "Отдел разработки";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_312.Properties.Resources.unnamed__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-56, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Price__Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDepatment);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.comboBoxDepatment);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewPrice_Services);
            this.Name = "Price__Services";
            this.Text = "Price__Services";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPrice_Services;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxDepatment;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDepatment;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}