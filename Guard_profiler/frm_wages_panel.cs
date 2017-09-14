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
    public partial class frm_wages_panel : Form
    {
        public frm_wages_panel()
        {
            InitializeComponent();
        }

        private void btn_deployment_summary_Click(object sender, EventArgs e)
        {
            frm_guard_deployment_summary deployment = new frm_guard_deployment_summary();
            deployment.Show();
        }

        private void btn_clients_Click(object sender, EventArgs e)
        {
            frm_manage_clients clients = new frm_manage_clients();
            clients.Show();
        }

        private void btn_deploy_guards_batch_Click(object sender, EventArgs e)
        {
            frm_guard_deployment_summary_batch batch_deploy = new frm_guard_deployment_summary_batch();
            batch_deploy.Show();
        }

        private void btn_other_data_Click(object sender, EventArgs e)
        {
            frm_guard_deployment_additional_data additional = new frm_guard_deployment_additional_data();
            additional.Show();
        }

        private void btn_deployment_periods_Click(object sender, EventArgs e)
        {
            frm_deployment_periods periods = new frm_deployment_periods();
            periods.ShowDialog();
        }

        private void btn_public_holidays_Click(object sender, EventArgs e)
        {
            frm_manage_public_holidays holidays = new frm_manage_public_holidays();
            holidays.ShowDialog();
        }
    }
}
