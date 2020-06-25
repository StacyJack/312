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
    public partial class Information__Depatment : Form
    {
        public Information__Depatment()
        {
            InitializeComponent();
            ShowInfo();
            ShowContract();
            ShowDevelopers();
        }
        void ShowInfo()
        {
            listViewInformation_Depatment.Items.Clear();
            foreach (Information_Depatment factory in Program.wftDb.Information_Depatment)
            {
                
                
                    if (factory.Work_Process == 0)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                    {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Employee.ToString() ,"Остановлен", factory.Contract.C_End.ToString(),
                    });
                        item.Tag = factory;
                        listViewInformation_Depatment.Items.Add(item);
                    }
                    else if (factory.Work_Process == 1)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                    {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Employee.ToString() ,"Запущен", factory.Contract.C_End.ToString(),
                    });
                        item.Tag = factory;
                        listViewInformation_Depatment.Items.Add(item);
                    }
                    else if (factory.Work_Process == 2)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                    {
                    factory.Id_Contract.ToString(),factory.Contract.Id_Services.ToString(),factory.Id_Employee.ToString() ,"В очереди", factory.Contract.C_End.ToString(),
                    });
                        item.Tag = factory;
                        listViewInformation_Depatment.Items.Add(item);
                    }
                
            }
            listViewInformation_Depatment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Information_Depatment priceSet = new Information_Depatment();
            priceSet.Id_Employee = Convert.ToInt32(comboBoxEmployee.SelectedItem.ToString().Split('.')[0]);
            priceSet.Id_Contract = Convert.ToInt32(comboBoxId_Contract.SelectedItem.ToString().Split('.')[0]);
            if (comboBoxEmployee.SelectedIndex ==0)
            {
                priceSet.Work_Process = 0;
            }
            if (comboBoxEmployee.SelectedIndex == 1)
            {
                priceSet.Work_Process = 1;
            }
            if (comboBoxEmployee.SelectedIndex == 2)
            {
                priceSet.Work_Process = 2;
            }


            Program.wftDb.Information_Depatment.Add(priceSet);
            Program.wftDb.SaveChanges();
            ShowInfo();
        }

        private void listViewInformation_Depatment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewInformation_Depatment.SelectedItems.Count == 1)
            {
                Information_Depatment factory = listViewInformation_Depatment.SelectedItems[0].Tag as Information_Depatment;
                comboBoxEmployee.SelectedIndex = comboBoxEmployee.FindString(factory.Id_Employee.ToString());
                comboBoxId_Contract.SelectedIndex = comboBoxId_Contract.FindString(factory.Id_Contract.ToString());
                comboBoxWork_Process.SelectedIndex = comboBoxWork_Process.FindString(factory.Work_Process.ToString());

            }
            else
            {
                comboBoxWork_Process.SelectedItem = null;
                comboBoxEmployee.SelectedItem = null;
                comboBoxId_Contract.SelectedItem = null;
            }
        }
        void ShowContract()
        {
            comboBoxId_Contract.Items.Clear();
           
            foreach (Contract factory in Program.wftDb.Contract)
            {
                if (factory.Id_Department == 1)
                {
                    string[] item = { factory.Id_Treaty.ToString() + ".", factory.Id_Services.ToString(), factory.Price_Services.name };
                    comboBoxId_Contract.Items.Add(string.Join("", item));
                }
            }
        }
        void ShowDevelopers()
        {
            comboBoxEmployee.Items.Clear();
            foreach (Developers factory in Program.wftDb.Developers)
            {
                string[] item = { factory.Id_Developers.ToString() + ".", factory.Surname+".",factory.Id_Depatment.ToString() };
                comboBoxEmployee.Items.Add(string.Join("", item));
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewInformation_Depatment.SelectedItems.Count == 1)
                {
                    Information_Depatment factory = listViewInformation_Depatment.SelectedItems[0].Tag as Information_Depatment;
                    Program.wftDb.Information_Depatment.Remove(factory);
                    Program.wftDb.SaveChanges();
                    ShowInfo();
                }

                comboBoxId_Contract.SelectedItem = null;
                comboBoxEmployee.SelectedItem = null;
                comboBoxWork_Process.SelectedItem = null;

            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
    
}
