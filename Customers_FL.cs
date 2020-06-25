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
    public partial class Customers_FL : Form
    {
        public Customers_FL()
        {
            InitializeComponent();
            ShowPCustomers();
        }
        void ShowPCustomers()
        {
            listViewCustomers_FL.Items.Clear();
            foreach (Customers_F_L factory in Program.wftDb.Customers_F_L)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Customers.ToString(), factory.Name, factory.Surname,factory.Patronumic,factory.Phone
                });
                item.Tag = factory;
                listViewCustomers_FL.Items.Add(item);
            }
            listViewCustomers_FL.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Customers_F_L priceSet = new Customers_F_L();
            priceSet.Name = textBoxName.Text;
            priceSet.Surname = textBoxSurname.Text;
            priceSet.Patronumic = textBoxPatronumic.Text;
            priceSet.Phone = textBoxPhone.Text;



            Program.wftDb.Customers_F_L.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowPCustomers();
        }

        private void listViewCustomers_FL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomers_FL.SelectedItems.Count == 1)
            {
                Customers_F_L factory = listViewCustomers_FL.SelectedItems[0].Tag as Customers_F_L;
                textBoxName.Text = factory.Name;
                textBoxSurname.Text = factory.Surname;
                textBoxPatronumic.Text = factory.Patronumic;
                textBoxPhone.Text = factory.Phone;
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronumic.Text = "";
                textBoxPhone.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewCustomers_FL.SelectedItems.Count == 1)
            {
                Customers_F_L factory = listViewCustomers_FL.SelectedItems[0].Tag as Customers_F_L;

                factory.Name = textBoxName.Text;
                factory.Surname = textBoxSurname.Text;
                factory.Patronumic = textBoxPatronumic.Text;
                factory.Phone = textBoxPhone.Text;


                Program.wftDb.SaveChanges();
                ShowPCustomers();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewCustomers_FL.SelectedItems.Count == 1)
                {
                    Customers_F_L factory = listViewCustomers_FL.SelectedItems[0].Tag as Customers_F_L;
                    Program.wftDb.Customers_F_L.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowPCustomers();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronumic.Text = "";
                textBoxPhone.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textboxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !Char.IsControl(number) )
            {
                e.Handled = true;
            }
        }

        private void textboxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number) )
            {
                e.Handled = true;
            }
        }
    }
}
