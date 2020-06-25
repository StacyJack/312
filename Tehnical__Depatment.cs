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
    public partial class Tehnical__Depatment : Form
    {
        public Tehnical__Depatment()
        {
            InitializeComponent();
            ShowInfo();
            ShowContract();
            ShowDevelopers();
        }
        void ShowInfo()
        {
            listViewTehnical_Depatment.Items.Clear();
            foreach (Tehnical_Depatment factory in Program.wftDb.Tehnical_Depatment)
            {


                if (factory.Work_Process == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Empioyee.ToString() ,"Остановлен", factory.Contract.C_End.ToString(),
                });
                    item.Tag = factory;
                    listViewTehnical_Depatment.Items.Add(item);
                }
                else if (factory.Work_Process == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Empioyee.ToString() ,"Запущен", factory.Contract.C_End.ToString(),
                });
                    item.Tag = factory;
                    listViewTehnical_Depatment.Items.Add(item);
                }
                else if (factory.Work_Process == 2)
                {
                    ListViewItem item = new ListViewItem(new string[]
                {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Empioyee.ToString() ,"В очереди", factory.Contract.C_End.ToString(),
                });
                    item.Tag = factory;
                    listViewTehnical_Depatment.Items.Add(item);
                }

            }
            listViewTehnical_Depatment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       

        private void listViewTehnical_Depatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTehnical_Depatment.SelectedItems.Count == 1)
            {
                Tehnical_Depatment factory = listViewTehnical_Depatment.SelectedItems[0].Tag as Tehnical_Depatment;
                comboBoxId_Employee.SelectedIndex = comboBoxId_Employee.FindString(factory.Id_Empioyee.ToString());
                comboBoxWork_Process.SelectedIndex = comboBoxWork_Process.FindString(factory.Work_Process.ToString());

            }
            else
            {
                comboBoxWork_Process.SelectedItem = null;
                comboBoxId_Employee.SelectedItem = null;
            }
        }
        void ShowContract()
        {
            comboBoxContract.Items.Clear();

            foreach (Contract factory in Program.wftDb.Contract)
            {
                if (factory.Id_Department == 0)
                {
                    string[] item = { factory.Id_Treaty.ToString() + ".", factory.Id_Services.ToString(), factory.Price_Services.name };
                    comboBoxContract.Items.Add(string.Join("", item));
                }
            }
        }
        void ShowDevelopers()
        {
            comboBoxId_Employee.Items.Clear();
            foreach (Developers factory in Program.wftDb.Developers)
            {
                string[] item = { factory.Id_Developers.ToString() + ".", factory.Surname + ".", factory.Id_Depatment.ToString() };
                comboBoxId_Employee.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            Tehnical_Depatment priceSet = new Tehnical_Depatment();
            priceSet.Id_Empioyee = Convert.ToInt32(comboBoxId_Employee.SelectedItem.ToString().Split('.')[0]);
            priceSet.Id_Contract = Convert.ToInt32(comboBoxContract.SelectedItem.ToString().Split('.')[0]);
            if (comboBoxId_Employee.SelectedIndex == 0)
            {
                priceSet.Work_Process = 0;
            }
            if (comboBoxId_Employee.SelectedIndex == 1)
            {
                priceSet.Work_Process = 1;
            }
            if (comboBoxId_Employee.SelectedIndex == 2)
            {
                priceSet.Work_Process = 2;
            }


            Program.wftDb.Tehnical_Depatment.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowInfo();
        }

       

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTehnical_Depatment.SelectedItems.Count == 1)
                {
                    Tehnical_Depatment factory = listViewTehnical_Depatment.SelectedItems[0].Tag as Tehnical_Depatment;
                    Program.wftDb.Tehnical_Depatment.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowInfo();
                }

                comboBoxContract.SelectedItem = null;
                comboBoxId_Employee.SelectedItem = null;
                comboBoxWork_Process.SelectedItem = null;

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}
