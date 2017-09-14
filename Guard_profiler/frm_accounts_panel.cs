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
    public partial class frm_accounts_panel : Form
    {
        public frm_accounts_panel()
        {
            InitializeComponent();
        }

        private void btn_manage_scales_Click(object sender, EventArgs e)
        {
            frm_salary_scale_guards scales = new frm_salary_scale_guards();
            scales.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_guards_salary_scale_mapping_dashboard scale_mapping = new frm_guards_salary_scale_mapping_dashboard();
            scale_mapping.ShowDialog();
        }

        private void btn_assign_scales_Click(object sender, EventArgs e)
        {
            frm_assign_salary_scales_to_guards scale = new frm_assign_salary_scales_to_guards();
            scale.Show();
        }

        private void btn_payroll_setup_Click(object sender, EventArgs e)
        {
            frm_setup_payroll payroll = new frm_setup_payroll();
            payroll.Show();
        }
    }
}
