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
    public enum Privileges
    {
        R = 4,
        N = 3,
        D = 2,
        M= 1 //Highest priority

    }

    public partial class Login : Form
    {
        private bool _loggedin = false;
        DBManager db = DBManager.getInstance();
        public Login()
        {
            InitializeComponent();
        }

        private void UTBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Char p;
 
            if (CheckTBoxes())
            {
                DataTable dt = db.GetPriv(UTBox.Text, PTBox.Text);
                if (dt == null)
                {
                    MessageBox.Show("Wrong ID or Password");
                    UTBox.Clear();
                    PTBox.Clear();
                    return;
                }

                p=Char.Parse((string)dt.Rows[0][0]);
             
                // MessageBox.Show("Login Successful");

                _loggedin = true;
                admin func = new admin(p);
                func.Show(this);
                UTBox.Clear();
                PTBox.Clear();
                this.Hide();

                return;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public bool CheckTBoxes()
        {
            if (UTBox.Text == "")
            {
                MessageBox.Show("Enter A Username");
                return false;
            }
            if (PTBox.Text == "")
            {
                MessageBox.Show("Enter A Password");
                return false;
            }
            return true;
        }

    }
}
