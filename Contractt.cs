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
    public partial class Contractt : Form
    {
        public Contractt()
        {
            InitializeComponent();
            ShowContract();
            ShowCustomers1();
            ShowCustomers();
            ShowPrice();
            ShowCompany();

        }
        void ShowContract()
        {
            listViewContractt.Items.Clear();
            foreach (Contract factory in Program.wftDb.Contract)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Treaty.ToString(), factory.Id_Company.ToString(), factory.Id_Customers.ToString(),factory.Id_CustomersYR_L.ToString(),
                    factory.Id_Services.ToString(),factory.Id_Department.ToString(),factory.Start.ToString(),factory.C_End.ToString(),factory.Price.ToString(),
                });
                item.Tag = factory;
                listViewContractt.Items.Add(item);
            }
            listViewContractt.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomersYR_L.SelectedItem != null )
            {
                Contract orders = new Contract();

                orders.Id_CustomersYR_L = Convert.ToInt32(comboBoxCustomersYR_L.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Company = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Services = Convert.ToInt32(comboBoxId_Services.SelectedItem.ToString().Split('.')[0]);

                orders.Price = Convert.ToInt32(textBoxPrice.Text);
                orders.Start = Convert.ToDateTime(textBoxStart.Text);
                orders.C_End = Convert.ToDateTime(textBox2.Text);
                if (comboBoxId_Depatment.SelectedIndex == 0)
                {
                    orders.Id_Department = 0;
                }
                if (comboBoxId_Depatment.SelectedIndex == 1)
                {
                    orders.Id_Department = 1;
                }
                Program.wftDb.Contract.Add(orders);
                Program.wftDb.SaveChanges();
                ShowContract();
            }
            else if (comboBoxId_Customers.SelectedItem != null )
            {
                Contract orders = new Contract();
                orders.Id_Customers = Convert.ToInt32(comboBoxId_Customers.SelectedItem.ToString().Split('.')[0]);

                orders.Id_Customers = Convert.ToInt32(comboBoxId_Customers.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Company = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                orders.Id_Services = Convert.ToInt32(comboBoxId_Services.SelectedItem.ToString().Split('.')[0]);

                orders.Price = Convert.ToInt32(textBoxPrice.Text);
                orders.Start = Convert.ToDateTime(textBoxStart.Text);
                orders.C_End = Convert.ToDateTime(textBox2.Text);
                if (comboBoxId_Depatment.SelectedIndex == 0)
                {
                    orders.Id_Department = 0;
                }
                if (comboBoxId_Depatment.SelectedIndex == 1)
                {
                    orders.Id_Department = 1;
                }
                Program.wftDb.Contract.Add(orders);
                Program.wftDb.SaveChanges();
                ShowContract();


            }

            else
            {
                MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void listViewContractt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewContractt.SelectedItems.Count == 1)
            {
                Contract factory = listViewContractt.SelectedItems[0].Tag as Contract;
                textBoxStart.Text = factory.Start.ToString();
                textBox2.Text = factory.C_End.ToString();
                textBoxPrice.Text = Convert.ToString(factory.Price);
                comboBoxCompany.SelectedIndex = comboBoxCompany.FindString(factory.Id_Company.ToString());
                comboBoxId_Customers.SelectedIndex = comboBoxId_Customers.FindString(factory.Id_Customers.ToString());
                comboBoxCustomersYR_L.SelectedIndex = comboBoxCustomersYR_L.FindString(factory.Id_Customers.ToString());
                comboBoxId_Services.SelectedIndex = comboBoxId_Services.FindString(factory.Id_Services.ToString());
                comboBoxId_Depatment.SelectedIndex = comboBoxId_Depatment.FindString(factory.Id_Department.ToString());
            }
            else
            {
                textBoxStart.Text = "";
                textBox2.Text = "";
                textBoxPrice.Text = "";
                comboBoxId_Depatment.SelectedItem = null;
                comboBoxId_Services.SelectedItem = null;
                comboBoxId_Customers.SelectedItem = null;
                comboBoxCustomersYR_L.SelectedItem = null;
                comboBoxCompany.SelectedItem = null;
            }
        }
        void ShowCustomers()
        {
            comboBoxId_Customers.Items.Clear();
            foreach (Customers_F_L factory in Program.wftDb.Customers_F_L)
            {
                string[] item = { factory.Id_Customers.ToString() + ".", factory.Surname };
                comboBoxId_Customers.Items.Add(string.Join("", item));
            }
        }
        void ShowCustomers1()
        {
            comboBoxCustomersYR_L.Items.Clear();
            foreach (Customers_YR_L factory in Program.wftDb.Customers_YR_L)
            {
                string[] item = { factory.Id_Customer.ToString() + ".", factory.Name_Company };
                comboBoxCustomersYR_L.Items.Add(string.Join("", item));
            }
        }
        void ShowPrice()
        {
            comboBoxId_Services.Items.Clear();
            foreach (Price_Services factory in Program.wftDb.Price_Services)
            {
                string[] item = { factory.Id_Services.ToString() + ".", factory.Id_Department.ToString() };
                comboBoxId_Services.Items.Add(string.Join("", item));
            }
        }
        void ShowCompany()
        {
            comboBoxCompany.Items.Clear();
            foreach (Company factory in Program.wftDb.Company)
            {
                string[] item = { factory.Id_Company.ToString() + ".", factory.Name };
                comboBoxCompany.Items.Add(string.Join("", item));
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewContractt.SelectedItems.Count == 1)
            {
                if (comboBoxCustomersYR_L.SelectedItem != null)
                {
                    Contract orders = listViewContractt.SelectedItems[0].Tag as Contract;
                    orders.Id_Customers = null;

                    orders.Id_CustomersYR_L = Convert.ToInt32(comboBoxCustomersYR_L.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Company = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Services = Convert.ToInt32(comboBoxId_Services.SelectedItem.ToString().Split('.')[0]);

                    orders.Price = Convert.ToInt32(textBoxPrice.Text);
                    orders.Start = Convert.ToDateTime(textBoxStart.Text);
                    orders.C_End = Convert.ToDateTime(textBox2.Text);
                    if (comboBoxId_Depatment.SelectedIndex == 0)
                    {
                        orders.Id_Department = 0;
                    }
                    if (comboBoxId_Depatment.SelectedIndex == 1)
                    {
                        orders.Id_Department = 1;
                    }
                   
                    Program.wftDb.SaveChanges();
                    ShowContract();
                }
                else if (comboBoxId_Customers.SelectedItem != null)
                {
                    Contract orders = listViewContractt.SelectedItems[0].Tag as Contract;
                    orders.Id_CustomersYR_L = null;
                    orders.Id_Customers = Convert.ToInt32(comboBoxId_Customers.SelectedItem.ToString().Split('.')[0]);

                    orders.Id_Customers = Convert.ToInt32(comboBoxId_Customers.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Company = Convert.ToInt32(comboBoxCompany.SelectedItem.ToString().Split('.')[0]);
                    orders.Id_Services = Convert.ToInt32(comboBoxId_Services.SelectedItem.ToString().Split('.')[0]);

                    orders.Price = Convert.ToInt32(textBoxPrice.Text);
                    orders.Start = Convert.ToDateTime(textBoxStart.Text);
                    orders.C_End = Convert.ToDateTime(textBox2.Text);
                    if (comboBoxId_Depatment.SelectedIndex == 0)
                    {
                        orders.Id_Department = 0;
                    }
                    if (comboBoxId_Depatment.SelectedIndex == 1)
                    {
                        orders.Id_Department = 1;
                    }
                  
                    Program.wftDb.SaveChanges();
                    ShowContract();


                }

                else
                {
                    MessageBox.Show("Не все данные введены!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewContractt.SelectedItems.Count == 1)
                {
                    Contract factory = listViewContractt.SelectedItems[0].Tag as Contract;
                    Program.wftDb.Contract.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowContract();
                }
                textBoxStart.Text = "";
                textBox2.Text = "";
                textBoxPrice.Text = "";
                comboBoxId_Depatment.SelectedItem = null;
                comboBoxId_Services.SelectedItem = null;
                comboBoxId_Customers.SelectedItem = null;
                comboBoxCustomersYR_L.SelectedItem = null;
                comboBoxCompany.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxDeid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number) && number !='.')
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }
        }
    }
}
