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
    public partial class Developerss : Form
    {
        public Developerss()
        {
            InitializeComponent();
            ShowDevelopers();
        }
        void ShowDevelopers()
        {
            listViewDeveloperss.Items.Clear();
            foreach (Developers factory in Program.wftDb.Developers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Developers.ToString(), factory.Name, factory.Surname,factory.Patronumic,factory.Id_Depatment.ToString(),
                });
                item.Tag = factory;
                listViewDeveloperss.Items.Add(item);
            }
            listViewDeveloperss.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Developers priceSet = new Developers();
            priceSet.Name = textBoxName.Text;
            priceSet.Surname = textBoxSurname.Text;
            priceSet.Patronumic = textBoxPatronumic.Text;


            if (comboBoxDepatment.SelectedIndex == 0)
            {
                priceSet.Id_Depatment = 0;
            }
            if (comboBoxDepatment.SelectedIndex == 1)
            {
                priceSet.Id_Depatment = 1;
            }
            Program.wftDb.Developers.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowDevelopers();
        }

        private void listViewDeveloperss_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDeveloperss.SelectedItems.Count == 1)
            {
                Developers factory = listViewDeveloperss.SelectedItems[0].Tag as Developers;
                textBoxName.Text = factory.Name;
                textBoxSurname.Text = factory.Surname;
                textBoxPatronumic.Text = factory.Patronumic;
                comboBoxDepatment.SelectedIndex = comboBoxDepatment.FindString(factory.Id_Depatment.ToString());
            }
            else
            {
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronumic.Text = "";
                comboBoxDepatment.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewDeveloperss.SelectedItems.Count == 1)
            {
                Developers factory = listViewDeveloperss.SelectedItems[0].Tag as Developers;

                factory.Name = textBoxName.Text;
                factory.Surname = textBoxSurname.Text;
                factory.Patronumic = textBoxPatronumic.Text;

                if (comboBoxDepatment.SelectedIndex == 0)
                {
                    factory.Id_Depatment = 0;
                }
                if (comboBoxDepatment.SelectedIndex == 1)
                {
                    factory.Id_Depatment = 1;
                }
                Program.wftDb.SaveChanges();
                ShowDevelopers();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewDeveloperss.SelectedItems.Count == 1)
                {
                    Developers factory = listViewDeveloperss.SelectedItems[0].Tag as Developers;
                    Program.wftDb.Developers.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowDevelopers();
                }
                textBoxName.Text = "";
                textBoxSurname.Text = "";
                textBoxPatronumic.Text = "";
                comboBoxDepatment.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsLetter(number) && !Char.IsControl(number))
            {
                e.Handled = true;
            }

        }

    }
}
