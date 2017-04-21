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
    public partial class Progress_Sheet : Form
    {
        DBManager DBM = new DBManager();
        public Progress_Sheet()
        {
            InitializeComponent();
            DataTable dt = DBM.GetClinicTypes();
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "ClinicTypeName";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DBM.SetClinicType(comboBox.Text);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
