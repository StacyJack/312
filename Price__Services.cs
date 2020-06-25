using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _312
{
    public partial class Price__Services : Form
    {
        public Price__Services()
        {
            InitializeComponent();
            ShowPrice();
        }
        void ShowPrice()
        {
            listViewPrice_Services.Items.Clear();
            foreach (Price_Services factory in Program.wftDb.Price_Services)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Services.ToString(), factory.name, factory.Id_Department.ToString(),
                });
                item.Tag = factory;
                listViewPrice_Services.Items.Add(item);
            }
            listViewPrice_Services.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Price_Services priceSet = new Price_Services();
            priceSet.name = textBoxName.Text;
           

            if (comboBoxDepatment.SelectedIndex==0)
            {
                priceSet.Id_Department = 0;
            }
            if (comboBoxDepatment.SelectedIndex==1)
            {
                priceSet.Id_Department = 1;
            }
            Program.wftDb.Price_Services.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowPrice();
        }

        private void listViewPrice_Services_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPrice_Services.SelectedItems.Count == 1)
            {
                Price_Services factory = listViewPrice_Services.SelectedItems[0].Tag as Price_Services;
                textBoxName.Text = factory.name;
                comboBoxDepatment.SelectedIndex = comboBoxDepatment.FindString(factory.Id_Department.ToString());
            }
            else
            {
                textBoxName.Text = "";
                comboBoxDepatment.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewPrice_Services.SelectedItems.Count == 1)
            {
                Price_Services factory = listViewPrice_Services.SelectedItems[0].Tag as Price_Services;
  
                factory.name = textBoxName.Text;

                if (comboBoxDepatment.SelectedIndex == 0)
                {
                    factory.Id_Department = 0;
                }
                if (comboBoxDepatment.SelectedIndex == 1)
                {
                    factory.Id_Department = 1;
                }
                Program.wftDb.SaveChanges();
                ShowPrice();
            }

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPrice_Services.SelectedItems.Count == 1)
                {
                    Price_Services factory = listViewPrice_Services.SelectedItems[0].Tag as Price_Services;
                    Program.wftDb.Price_Services.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowPrice();
                }
                textBoxName.Text = "";
                comboBoxDepatment.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
