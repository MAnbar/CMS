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

    public partial class admin : Form
    {
        
        char _privilege;
        public admin(char privilege)
        {
            InitializeComponent();
            this._privilege = privilege;

            if (privilege == 'R')
            {
                this.userSettingsToolStripMenuItem.Enabled = false;
                this.addUserToolStripMenuItem.Enabled = false;
                this.addStockToolStripMenuItem.Enabled = false;
                this.addSessionTypeToolStripMenuItem.Enabled = false;
                this.editSessionTypeToolStripMenuItem.Enabled = false;
                this.editUserToolStripMenuItem.Enabled = false;
                this.stockToolStripMenuItem.Enabled = false;
                this.removeUsToolStripMenuItem.Enabled = false;
                this.attendane.Enabled = true;
                this.View_statistics.Enabled = false;
                this.calc_sal.Enabled = false;
                this.prog_sheeet_design.Enabled = false;
                this.removeStockToolStripMenuItem.Enabled = false;
                this.removeSessionTypeToolStripMenuItem.Enabled = false;
                this.menuStrip1.Enabled = true;
                this.sessionSettingsToolStripMenuItem.Enabled = false;
                this.editStockToolStripMenuItem.Enabled = false;
                this.viewToolStripMenuItem.Enabled = true;
                this.viewScheduleToolStripMenuItem.Enabled = true;
                this.viewMyScheduleToolStripMenuItem.Enabled = false;
                this.appointmentsToolStripMenuItem.Enabled = true;
                this.reserveToolStripMenuItem.Enabled = true;
                this.cancelToolStripMenuItem.Enabled = true;
                this.viewMyPatientsToolStripMenuItem.Enabled = false;
                this.add_patient.Enabled = true;
            }

            else if (privilege == 'N')
            {
                this.userSettingsToolStripMenuItem.Enabled = false;
                this.addUserToolStripMenuItem.Enabled = false;
                this.addStockToolStripMenuItem.Enabled = false;
                this.addSessionTypeToolStripMenuItem.Enabled = false;
                this.editSessionTypeToolStripMenuItem.Enabled = false;
                this.editUserToolStripMenuItem.Enabled = false;
                this.stockToolStripMenuItem.Enabled = true;
                this.removeUsToolStripMenuItem.Enabled = false;
                this.attendane.Enabled = false;
                this.View_statistics.Enabled = false;
                this.calc_sal.Enabled = false;
                this.prog_sheeet_design.Enabled = false;
                this.removeStockToolStripMenuItem.Enabled = false;
                this.removeSessionTypeToolStripMenuItem.Enabled = false;
                this.menuStrip1.Enabled = true;
                this.sessionSettingsToolStripMenuItem.Enabled = false;
                this.editStockToolStripMenuItem.Enabled = true;
                this.viewToolStripMenuItem.Enabled = true;
                this.viewScheduleToolStripMenuItem.Enabled = true;
                this.viewMyScheduleToolStripMenuItem.Enabled = true;
                this.appointmentsToolStripMenuItem.Enabled = false;
                this.reserveToolStripMenuItem.Enabled = false;
                this.cancelToolStripMenuItem.Enabled =false;
                this.viewMyPatientsToolStripMenuItem.Enabled = false;
                this.add_patient.Enabled = false;
            }

            else if (privilege =='D')
            {
                this.userSettingsToolStripMenuItem.Enabled = false;
                this.addUserToolStripMenuItem.Enabled = false;
                this.addStockToolStripMenuItem.Enabled = false;
                this.addSessionTypeToolStripMenuItem.Enabled = false;
                this.editSessionTypeToolStripMenuItem.Enabled = false;
                this.editUserToolStripMenuItem.Enabled = false;
                this.stockToolStripMenuItem.Enabled = false;
                this.removeUsToolStripMenuItem.Enabled = false;
                this.attendane.Enabled = false;
                this.View_statistics.Enabled = false;
                this.calc_sal.Enabled = false;
                this.prog_sheeet_design.Enabled = false;
                this.removeStockToolStripMenuItem.Enabled = false;
                this.removeSessionTypeToolStripMenuItem.Enabled = false;
                this.menuStrip1.Enabled = true;
                this.sessionSettingsToolStripMenuItem.Enabled = false;
                this.editStockToolStripMenuItem.Enabled = false;
                this.viewToolStripMenuItem.Enabled = true;
                this.viewScheduleToolStripMenuItem.Enabled = false;
                this.viewMyScheduleToolStripMenuItem.Enabled = true;
                this.appointmentsToolStripMenuItem.Enabled = false;
                this.reserveToolStripMenuItem.Enabled = false;
                this.cancelToolStripMenuItem.Enabled = false;
                this.viewMyPatientsToolStripMenuItem.Enabled = true;
                this.add_patient.Enabled = false;
            }

            else if (privilege == 'M')
            {
                this.userSettingsToolStripMenuItem.Enabled = true;
                this.addUserToolStripMenuItem.Enabled = true;
                this.addStockToolStripMenuItem.Enabled = true;
                this.addSessionTypeToolStripMenuItem.Enabled = true;
                this.editSessionTypeToolStripMenuItem.Enabled = true;
                this.editUserToolStripMenuItem.Enabled = true;
                this.stockToolStripMenuItem.Enabled = true;
                this.removeUsToolStripMenuItem.Enabled = true;
                this.attendane.Enabled = false;
                this.View_statistics.Enabled = true;
                this.calc_sal.Enabled = true;
                this.prog_sheeet_design.Enabled = true;
                this.removeStockToolStripMenuItem.Enabled = true;
                this.removeSessionTypeToolStripMenuItem.Enabled =true;
                this.menuStrip1.Enabled = true;
                this.sessionSettingsToolStripMenuItem.Enabled = true;
                this.editStockToolStripMenuItem.Enabled = true;
                this.viewToolStripMenuItem.Enabled = true;
                this.viewScheduleToolStripMenuItem.Enabled = true;
                this.viewMyScheduleToolStripMenuItem.Enabled = false;
                this.appointmentsToolStripMenuItem.Enabled = false;
                this.reserveToolStripMenuItem.Enabled = false;
                this.cancelToolStripMenuItem.Enabled = false;
                this.viewMyPatientsToolStripMenuItem.Enabled = false;
                this.add_patient.Enabled = false;
            }


        }

        private void removeUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Remove_user(_privilege).Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddButton(_privilege).Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editUserToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Edit_User(_privilege).Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Login().Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

