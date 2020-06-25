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
    public partial class Companu : Form
    {
        public Companu()
        {
            InitializeComponent();
            ShowPCompany();
        }
        void ShowPCompany()
        {
            listViewCompanu.Items.Clear();
            foreach (Company factory in Program.wftDb.Company)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Company.ToString(), factory.Name, factory.Address,
                });
                item.Tag = factory;
                listViewCompanu.Items.Add(item);
            }
            listViewCompanu.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Company priceSet = new Company();
            priceSet.Name = textBoxName.Text;
            priceSet.Address = textBoxAddress.Text;



            Program.wftDb.Company.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowPCompany();
        }

        private void listViewCompanu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCompanu.SelectedItems.Count == 1)
            {
                Company factory = listViewCompanu.SelectedItems[0].Tag as Company;
                textBoxName.Text = factory.Name;
                textBoxAddress.Text = factory.Address;
            }
            else
            {
                textBoxName.Text = "";
                textBoxAddress.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCompanu.SelectedItems.Count == 1)
            {
                Company factory = listViewCompanu.SelectedItems[0].Tag as Company;

                factory.Name = textBoxName.Text;
                factory.Address = textBoxAddress.Text;


                Program.wftDb.SaveChanges();
                ShowPCompany();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCompanu.SelectedItems.Count == 1)
                {
                    Company factory = listViewCompanu.SelectedItems[0].Tag as Company;
                    Program.wftDb.Company.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowPCompany();
                }
                textBoxName.Text = "";
                textBoxAddress.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
