using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    public partial class Add_Sessions : Form
    {
        DBManager DBM = new DBManager();
        public Add_Sessions()
        {
            InitializeComponent();
            UpdateDG();
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateDG()
        {
            DataTable dt = DBM.GetAllSessions();
            dataGrid.DataSource = dt;
            dataGrid.Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" || NameTB.Text == "New Session")
            {
                MessageBox.Show("Please enter the name of session");
                return;
            }
            if (PriceTB.Text == "")
            {
                MessageBox.Show("Please enter the price of session");
                return;
            }
            if (NursesNumbTB.Text == "")
            {
                MessageBox.Show("Please enter number of nurses");
                return;
            }
            if (DoctorSalaryTB.Text == "")
            {
                MessageBox.Show("Please enter the salary of doctor");
                return;
            }
            int NursesSalary;
            if (NurseSalaryTB.Text == "" && Convert.ToInt32(NursesNumbTB.Text) == 0)
            {
                NursesSalary = 0;
            }
            else if (NurseSalaryTB.Text == "")
            {
                MessageBox.Show("Please enter the salary of nurse");
                return;
            }
            else
            {
                NursesSalary = Convert.ToInt32(NurseSalaryTB.Text);
            }

            DBM.AddSession(NameTB.Text, Convert.ToInt32(NursesNumbTB.Text), Convert.ToInt32(PriceTB.Text), Convert.ToInt32(DoctorSalaryTB.Text), NursesSalary);
            UpdateDG();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateDG();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //Login.show();
        }
    }
}
