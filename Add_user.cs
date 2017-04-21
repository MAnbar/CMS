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
    public partial class AddButton : Form
    {
        char p;
        DBManager db = DBManager.getInstance();
        public AddButton(char p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Add_user_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            //Why ID is added ?? 
            int r = 0;
            r= db.AddUser(textBox1.Text, textBox2.Text, Int32.Parse(textBox5.Text), textBox3.Text, char.Parse(textBox4.Text) );
            if (r == 1)
            {
                MessageBox.Show("User added successfully");
            }
            else if (r == -1)
            {
                MessageBox.Show("Failed to add a new user");
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
