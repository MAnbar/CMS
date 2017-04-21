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
    public partial class Edit_User : Form
    {
        char p;
        DBManager db = DBManager.getInstance();
        public Edit_User(char p)
        {
            InitializeComponent();
            this.p = p;
            DataTable dt1 = db.GetAllUsers();
            if (dt1 != null)
            {
                dataGridView1.DataSource = dt1;
           
                comboBox1.DataSource = dt1;
                comboBox1.DisplayMember = "StaffID";
                comboBox1.ValueMember = "StaffID";
                comboBox1.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //name, pass, id, phome,pos
            int r = 0;
            r = db.EditUser(textBox1.Text, textBox2.Text, (int)comboBox1.SelectedValue, textBox3.Text, char.Parse(textBox4.Text));
            if (r == 1)
            {
                MessageBox.Show("User edited successfully");
            }
            else if (r == -1)
            {
                MessageBox.Show("Failed to edit user");
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
