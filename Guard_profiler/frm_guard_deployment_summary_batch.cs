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
    public partial class frm_guard_deployment_summary_batch : Form
    {
        public frm_guard_deployment_summary_batch()
        {
            InitializeComponent();
        }

        private void frm_guard_deployment_summary_batch_Load(object sender, EventArgs e)
        {
            //set the current deployment period
            dt_start_date.Value = SystemConst._deployment_start_date;
            dt_end_date.Value = SystemConst._deployment_end_date;

            Get_guard_shift_types();
            GET_BRANCHES();
        }


        //guard shift types
        protected void Get_guard_shift_types()
        {
            DataTable dt = Guard_deployment.Return_guard_shift_types("return_guard_shift_types");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["shift_name"] = String.Empty;
                dtRow["shift_id"] = -1;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_working_shift.DataSource = dt;
                cbo_working_shift.DisplayMember = "shift_name";
                cbo_working_shift.ValueMember = "shift_id";
            }
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

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guard_list_Click(object sender, EventArgs e)
        {
            if (cbo_branch.Text == String.Empty)
            {
                MessageBox.Show("No Branch selected", "Batch Deploy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                get_list_of_guards_for_batch_deploy();
            } 
        }

        protected void get_list_of_guards_for_batch_deploy()
        {
            DataTable dt = Guard_deployment.select_list_of_guards_by_branch_and_date_for_batch_deployment("select_list_of_guards_by_branch_and_date_for_batch_deployment", cbo_branch.Text);
            if (dt.Rows.Count > 0)
            {
                //set value of deployment date
                DataRow dtRow = dt.Rows[0];
                dt_deployment_date.Value = Convert.ToDateTime(dtRow["next_deploy_date"]);
                gdv_deployment_summary.DataSource = dt;

                gdv_deployment_summary.Columns["deploy_type"].Visible = false;
                gdv_deployment_summary.Columns["branch_name"].Visible = false;
                gdv_deployment_summary.Columns["guard_auto_id"].Visible = false;
                gdv_deployment_summary.Columns["firearm_serial"].Visible = false;
                gdv_deployment_summary.Columns["number_of_ammunitions"].Visible = false;
                gdv_deployment_summary.Columns["is_leave_day_for_guard"].Visible = false;
                gdv_deployment_summary.Columns["is_public_holiday"].Visible = false;
                gdv_deployment_summary.Columns["deploy_date"].Visible = false;

                gdv_deployment_summary.Columns["guard_name"].HeaderText = "Guard";
                gdv_deployment_summary.Columns["guard_number"].HeaderText = "Guard";
                gdv_deployment_summary.Columns["next_deploy_date"].HeaderText = "Day";
                gdv_deployment_summary.Columns["client_name"].HeaderText = "Client";
                gdv_deployment_summary.Columns["client_code"].HeaderText = "Client Code";
                gdv_deployment_summary.Columns["client_location"].HeaderText = "Location";
                gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";

                gdv_deployment_summary.Columns["guard_name"].Width = 250;

                gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;
                gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_deployment_summary.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_deployment_summary.EnableHeadersVisualStyles = false;
            }
            else
            {
                gdv_deployment_summary.DataSource = dt;
            }
        }
    }
}
