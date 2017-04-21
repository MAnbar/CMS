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
    public partial class Edit_Sessions : Form
    {
        DBManager DBM = new DBManager();
        public Edit_Sessions()
        {
            InitializeComponent();
            UpdateDG();
        }

        private void UpdateDG()
        {
            DataTable dt = DBM.GetAllSessions();
            dataGrid.DataSource = dt;
            dataGrid.Refresh();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            int row = dataGrid.CurrentRow.Index;
            int TypeID = Convert.ToInt32(dataGrid.Rows[row].Cells[0].Value);
            string TypeName = dataGrid.Rows[row].Cells[1].Value.ToString();
            int NoOfNurses = Convert.ToInt32(dataGrid.Rows[row].Cells[2].Value);
            int price = Convert.ToInt32(dataGrid.Rows[row].Cells[3].Value);
            int DSal = Convert.ToInt32(dataGrid.Rows[row].Cells[4].Value);
            int NSal = Convert.ToInt32(dataGrid.Rows[row].Cells[5].Value);

            DBM.EditSessions(TypeID, TypeName, NoOfNurses, price, DSal, NSal);
            UpdateDG();
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
    }
}
