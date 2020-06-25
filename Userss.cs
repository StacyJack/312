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
    public partial class Userss : Form
    {
        public Userss()
        {
            InitializeComponent();
            ShowUser();
        }
        void ShowUser()
        {
            listViewUserss.Items.Clear();
            foreach (Users factory in Program.wftDb.Users)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id.ToString(), factory.Login, factory.Password,factory.Type,
                });
                item.Tag = factory;
                listViewUserss.Items.Add(item);
            }
            listViewUserss.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Users priceSet = new Users();
            priceSet.Login = textBoxLogin.Text;
            priceSet.Password = textBoxPassword.Text;

            if (comboBoxType.SelectedIndex == 0)
            {
                priceSet.Type = "Администратор";
            }
            if (comboBoxType.SelectedIndex == 1)
            {
                priceSet.Type = "Сотрудник";
            }

            Program.wftDb.Users.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowUser();
        }

        private void listViewUserss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUserss.SelectedItems.Count == 1)
            {
                Users factory = listViewUserss.SelectedItems[0].Tag as Users;
                textBoxLogin.Text = factory.Login.ToString();
                textBoxPassword.Text = factory.Password.ToString();

                comboBoxType.SelectedIndex = comboBoxType.FindString(factory.Type.ToString());
            }
            else
            {
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                comboBoxType.Text = null;

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {


            if (comboBoxType.SelectedItem != null)
            {
                Users orders = listViewUserss.SelectedItems[0].Tag as Users;

                orders.Login = textBoxLogin.Text;
                orders.Password = textBoxPassword.Text;
                if (comboBoxType.SelectedIndex == 0)
                {
                    orders.Type = "Администратор";
                }
                if (comboBoxType.SelectedIndex == 1)
                {
                    orders.Type = "Сотрудник";
                }

                Program.wftDb.SaveChanges();
                ShowUser();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUserss.SelectedItems.Count == 1)
                {
                    Users factory = listViewUserss.SelectedItems[0].Tag as Users;
                    Program.wftDb.Users.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowUser();
                }
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";

                comboBoxType.SelectedItem = null;

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
