using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guard_profiler
{
    public partial class frm_hr_panel : Form
    {
        public frm_hr_panel()
        {
            InitializeComponent();
        }

        private void btn_guard_profiles_Click(object sender, EventArgs e)
        {
            sg_profiles profiles = new sg_profiles();
            profiles.Show();
        }

        private void btn_emp_records_Click(object sender, EventArgs e)
        {
            frm_employment_record record = new frm_employment_record();
            record.Show();
        }

        private void btn_transfer_guards_Click(object sender, EventArgs e)
        {
            frm_transfer_guards transfer = new frm_transfer_guards();
            transfer.Show();
        }

        private void btn_archived_guards_Click(object sender, EventArgs e)
        {
            frm_archieved_guards archieve = new frm_archieved_guards();
            archieve.Show();
        }

        private void activeGuardsByBranchReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_guard_lists lists = new frm_guard_lists();
            lists.ShowDialog();
        }

        private void kampalaGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_kampal_guards_filter kamp = new frm_kampal_guards_filter();
            kamp.ShowDialog();
        }

        private void allGuardsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_sg_list_report report = new frm_sg_list_report();
            report.ShowDialog();
        }

        private void archivedGuardsReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_archieve_lists archieve = new frm_archieve_lists();
            archieve.ShowDialog();
        }
    }
}
