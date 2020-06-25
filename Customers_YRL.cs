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
    public partial class Customers_YRL : Form
    {
        public Customers_YRL()
        {
            InitializeComponent();
            ShowPCustomers1();
        }
        void ShowPCustomers1()
        {
            listViewCustomers_YRL.Items.Clear();
            foreach (Customers_YR_L factory in Program.wftDb.Customers_YR_L)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Customer.ToString(), factory.Name_Company, factory.Phone,factory.maill,
                });
                item.Tag = factory;
                listViewCustomers_YRL.Items.Add(item);
            }
            listViewCustomers_YRL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customers_YR_L priceSet = new Customers_YR_L();
            priceSet.Name_Company = textBoxName_Company.Text;
            priceSet.Phone = textBoxPhone.Text;
            priceSet.maill = textBoxMaill.Text;
           



            Program.wftDb.Customers_YR_L.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowPCustomers1();
        }

        private void listViewCustomers_YRL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomers_YRL.SelectedItems.Count == 1)
            {
                Customers_YR_L factory = listViewCustomers_YRL.SelectedItems[0].Tag as Customers_YR_L;
                textBoxName_Company.Text = factory.Name_Company;
                textBoxPhone.Text = factory.Phone;
                textBoxMaill.Text = factory.maill;

            }
            else
            {
                textBoxName_Company.Text = "";
                textBoxPhone.Text = "";
                textBoxMaill.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCustomers_YRL.SelectedItems.Count == 1)
            {
                Customers_YR_L factory = listViewCustomers_YRL.SelectedItems[0].Tag as Customers_YR_L;

                factory.Name_Company = textBoxName_Company.Text;
                factory.Phone = textBoxPhone.Text;
                factory.maill = textBoxMaill.Text;



                Program.wftDb.SaveChanges();
                ShowPCustomers1();
            }   
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustomers_YRL.SelectedItems.Count == 1)
                {
                    Customers_YR_L factory = listViewCustomers_YRL.SelectedItems[0].Tag as Customers_YR_L;
                    Program.wftDb.Customers_YR_L.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowPCustomers1();
                }
                textBoxName_Company.Text = "";
                textBoxPhone.Text = "";
                textBoxMaill.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textboxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
