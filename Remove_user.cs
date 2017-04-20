using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Remove_user : Form
    {
        char p;
        DBManager db = DBManager.getInstance();
        public Remove_user(char p)
        {
            this.p = p;
            InitializeComponent();
            DataTable dt= db.GetAllUsers();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void Id_remove_Click(object sender, EventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
            int r = 0;
            r = db.RemoveUser(ID);
            if (r == 1)
            {
                MessageBox.Show("User removed successfully");
            }
            else
            {
                MessageBox.Show("User removal failed");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new admin(p).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }
    }
}
