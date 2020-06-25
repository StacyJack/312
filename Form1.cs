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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (Autoris.users.type == "Сотрудник") 
            {
                buttonCompany.Enabled = false;
                buttonDevelopers.Enabled = false;
                buttonUsers.Enabled = false;

            }
        }

        private void buttonPrice__Services_Click(object sender, EventArgs e)
        {
            Form price__Services = new Price__Services();
            price__Services.Show();
        }

        private void buttonTehnical_Depatment_Click(object sender, EventArgs e)
        {
            Form tehnical__Depatment = new Tehnical__Depatment();
            tehnical__Depatment.Show();
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            Form companu = new Companu();
            companu.Show();
        }

        private void buttonDevelopers_Click(object sender, EventArgs e)
        {
            Form developerss = new Developerss();
            developerss.Show();
        }

        private void buttonInformation_Depatment_Click(object sender, EventArgs e)
        {
            Form informatios__Depatment = new Information__Depatment();
            informatios__Depatment.Show();
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            Form contractt = new Contractt();
            contractt.Show();
        }

        private void buttoncCustomers_FL_Click(object sender, EventArgs e)
        {
            Form customers_FL = new Customers_FL();
            customers_FL.Show();
        }

        private void buttonCustomers_YRL_Click(object sender, EventArgs e)
        {
            Form customers_YRL = new Customers_YRL();
            customers_YRL.Show();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            Form userss = new Userss();
            userss.Show();
        }
    }
}    

   

