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
    public partial class frm_setup_payroll : Form
    {
        public frm_setup_payroll()
        {
            InitializeComponent();
        }

        private void frm_setup_payroll_Load(object sender, EventArgs e)
        {
            //set the current deployment period
            dt_start_date.Value = SystemConst._deployment_start_date;
            dt_end_date.Value = SystemConst._deployment_end_date;

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            GET_BRANCHES();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = String.Empty;
                dtRow["active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_branch.DataSource = dt;
                cbo_branch.DisplayMember = "branch";
                cbo_branch.ValueMember = "branch_code";
            }
        }
    }
}
