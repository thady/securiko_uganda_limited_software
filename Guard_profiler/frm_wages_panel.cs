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
    }
}
