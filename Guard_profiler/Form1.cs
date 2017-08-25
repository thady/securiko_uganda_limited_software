using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frmMain : Form
    {
        Timer t = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void guardProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_hr_panel hr_panel = new frm_hr_panel();
            hr_panel.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_users users = new frm_users();
            users.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("For security purposes,the system will exit.All unsaved changes may be lost,proceed??", "LogOut", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcrystal_report_single single = new frmcrystal_report_single();
            single.Show();
        }

        private void manageDepartmentsBranchesPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lookups lookups = new frm_lookups();
            lookups.Show();
        }

        private void leaveManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_employment_record record = new frm_employment_record();
            record.Show();
        }

        private void removeNumberFromGuardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_free_guard_number guard_number = new frm_free_guard_number();
            guard_number.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            update_first_last_names n = new update_first_last_names();
            n.Show();
        }

        private void activeGuardsReportsByBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        protected void WELCOME_GREET_USER()
        {
            if(DateTime.Now.Hour<12){
                lbl_name_message.Text = "Good Morning " + SystemConst.Get_username();
                //lbl_time.Text = "Login Time:" + Convert.ToString(DateTime.Now);
                panel_user.Visible = true;
            }
            else if (DateTime.Now.Hour < 17)
            {
                lbl_name_message.Text = "Good Afternoon " + SystemConst.Get_username();
                //lbl_time.Text = "Login Time:" + Convert.ToString(DateTime.Now);
                panel_user.Visible = true;
            }
            else
            {
                lbl_name_message.Text = "Good Evening " + SystemConst.Get_username();
                //lbl_time.Text = "Login Time:"+ Convert.ToString(DateTime.Now);
                panel_user.Visible = true;
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            WELCOME_GREET_USER();
            StartTimer();
        }

        private void frmMain_MouseHover(object sender, EventArgs e)
        {
            WELCOME_GREET_USER();
            StartTimer();
        }

        protected void StartTimer() {
            t = new Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        protected void t_Tick(object sender, EventArgs e)
        {
            lbl_clock.Text = DateTime.Now.ToString();
            lbl_user_session_name.Text = "Login session for: " + SystemConst.Get_username();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void activeGuardsByBranchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_guard_lists lists = new frm_guard_lists();
            lists.ShowDialog();
        }

        private void allGuardsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sg_list_report report = new frm_sg_list_report();
            report.ShowDialog();
        }

        private void transferGuardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_archieved_guards archieve = new frm_archieved_guards();
            archieve.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_transfer_guards transfer = new frm_transfer_guards();
            transfer.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frm_kampal_guards_filter kamp = new frm_kampal_guards_filter();
            kamp.ShowDialog();
        }

        private void archievedGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_archieve_lists archieve = new frm_archieve_lists();
            archieve.ShowDialog();
        }

        private void updatePositionCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_update_guard_position_codes codes = new frm_update_guard_position_codes();
            codes.ShowDialog();
        }

        private void guardProfilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sg_profiles profiles = new sg_profiles();
            profiles.Show();
        }

        private void guardsSalaryScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_salary_scale_guards scales = new frm_salary_scale_guards();
            scales.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frm_guards_salary_scale_mapping_dashboard scale_mapping = new frm_guards_salary_scale_mapping_dashboard();
            scale_mapping.ShowDialog();
        }

        private void otherEmployeeSalaryScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_assign_salary_scales_to_guards scale = new frm_assign_salary_scales_to_guards();
            scale.Show();
        }

        private void nonGuardProfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frm_accounts_panel accounts = new frm_accounts_panel();
            accounts.ShowDialog();
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            frm_wages_panel wages = new frm_wages_panel();
            wages.ShowDialog();
        }
    }
}
