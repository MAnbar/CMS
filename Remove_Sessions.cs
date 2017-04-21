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
    public partial class Remove_Sessions : Form
    {
        DBManager DBM = new DBManager();
        public Remove_Sessions()
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
            int id = Convert.ToInt32(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[0].Value);
            DBM.RemoveSessions(id);
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
