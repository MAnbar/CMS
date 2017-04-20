using Clinic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinic_forms
{
    public partial class Calculate_Salary : Form
    {
        DBManager MyDBM = new DBManager();
        public Calculate_Salary()
        {
            InitializeComponent();
            DataTable dt = MyDBM.GetAllPositions();
            TypeCB.DataSource = dt;
            TypeCB.DisplayMember = "Pname";
            TypeCB.ValueMember = "PID";
            dt = MyDBM.GetAllStaff();
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            this.DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void Calculate_Salary_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            String Name;
            if (NameTB.Text == "")
            {
                Name = "";
            }
            else
            {
                Name = NameTB.Text;
            }
            DataTable dt;
            if (TypeCB.SelectedIndex == 0)
            {
                dt = MyDBM.GetAllStaffByName(Name);
            }
            else
            {
                dt = MyDBM.GetAllStaffByNameAndType(Name, TypeCB.SelectedValue.ToString());
            }
            DataGrid.DataSource = dt;
            DataGrid.Refresh();
            this.DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void CalulateButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentRow.Index].Cells[0].Value);
            int Salary = MyDBM.GetSalaryByID(id);
            SalaryTB.Text = Salary.ToString();
        }

        private void PaidButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentRow.Index].Cells[0].Value);
            MyDBM.SetSalaryPaidByID(id);
            SalaryTB.Text = 0.ToString();
        }
    }
}


