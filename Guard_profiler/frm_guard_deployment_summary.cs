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
    public partial class frm_guard_deployment_summary : Form
    {
        public frm_guard_deployment_summary()
        {
            InitializeComponent();
        }

        private void frm_guard_deployment_summary_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
            GET_ACTIVE_GUARDS();
            Return_list_of_clients();
            Get_guard_shift_types();

            Return_list_of_deployments_by_deploy_id();//list of deployments made sofar for the current month

            cbo_deploy_type.Text = "Normal";//set deploy type to norma...will refactor this line later

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            //set the current deployment period
            dt_start_date.Value = SystemConst._deployment_start_date;
            dt_end_date.Value = SystemConst._deployment_end_date;
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

        protected void GET_ACTIVE_GUARDS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_LIST_OF_ACTIVE_GUARDS");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["full_name"] = String.Empty;
                dtRow["guard_number"] = String.Empty;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_guard_name.DataSource = dt;
                cbo_guard_name.DisplayMember = "full_name";
                cbo_guard_name.ValueMember = "guard_number";
            }
        }

        protected void GET_ACTIVE_GUARDS_BY_BRANCH(String branch_name)
        {
            DataTable dt = System_lookups.SELECT_LIST_OF_ACTIVE_GUARDS_BY_BRANCH("SELECT_LIST_OF_ACTIVE_GUARDS_BY_BRANCH", branch_name);
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["full_name"] = String.Empty;
                dtRow["guard_number"] = String.Empty;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_guard_name.DataSource = dt;
                cbo_guard_name.DisplayMember = "full_name";
                cbo_guard_name.ValueMember = "guard_number";
            }
        }

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.Text != String.Empty)
            {
                txt_branch_code.Text = cbo_branch.SelectedValue.ToString();
                GET_ACTIVE_GUARDS_BY_BRANCH(cbo_branch.Text);
            }
            else
            {
                txt_branch_code.Text = String.Empty;
                GET_ACTIVE_GUARDS();
            }
        }

        private void cbo_guard_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_guard_name.Text != String.Empty)
            {
                txt_guard_number.Text = cbo_guard_name.SelectedValue.ToString();

            }
            else
            {
                txt_guard_number.Text = String.Empty;
            }
        }

        //return client list
        protected void Return_list_of_clients()
        {
            DataTable dt = Clients.Return_list_of_clients("return_list_of_clients");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["client_name"] = String.Empty;
                dtRow["client_code"] = String.Empty;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_customer_name.DataSource = dt;
                cbo_customer_name.DisplayMember = "client_name";
                cbo_customer_name.ValueMember = "client_code";
            }
        }

        private void cbo_customer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_client_code.Text = cbo_customer_name.Text != String.Empty ? cbo_customer_name.SelectedValue.ToString() : String.Empty;

            Return_client_locations(cbo_customer_name.SelectedValue.ToString());
        }

        //Client locations
        protected void Return_client_locations(string client_code)
        {
            DataTable dt = Clients.Return_client_location_list("return_client_location_list_by_client_code", client_code);
            if (dt.Rows.Count > 0)
            {
               
                DataRow dtRow = dt.NewRow();
                dtRow["location_name"] = String.Empty;
                dtRow["record_guid"] = String.Empty;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_customer_location.DataSource = dt;
                cbo_customer_location.DisplayMember = "location_name";
                cbo_customer_location.ValueMember = "record_guid";
            }
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save_guard_deployment_record();
        }

        protected void Save_guard_deployment_record()
        {
            if (dt_start_date.Checked == false || dt_end_date.Checked == false || dt_deployment_date.Checked == false ||
                cbo_deploy_type.Text == String.Empty || cbo_branch.Text == String.Empty || cbo_customer_name.Text == String.Empty || cbo_customer_location.Text == String.Empty ||
                cbo_guard_name.Text == String.Empty || cbo_working_shift.Text == String.Empty)
            {
                MessageBox.Show("Fill in all required values", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Guard_deployment.Save_new_deployment_record("save_new_deployment_record", dt_start_date.Value.Date, dt_end_date.Value.Date, SystemConst._username, txt_guard_number.Text, dt_deployment_date.Value.Date,
            cbo_deploy_type.Text, cbo_branch.Text, txt_client_code.Text, cbo_customer_location.Text, cbo_guard_name.Text, txt_fire_arm_serial.Text, txt_ammunition_count.Text != String.Empty ? Convert.ToInt32(txt_ammunition_count.Text) : 0, cbo_working_shift.Text, chk_leave.Checked == true ? true : false,
            chk_public_holiday.Checked == true ? true : false);

                MessageBox.Show("Successfully deployed guard for this date", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Return_list_of_deployments_by_deploy_id();
            }
        }

        protected void Return_list_of_deployments_by_deploy_id()
        {
            DataTable dt = Guard_deployment.Return_list_of_deployments_by_deploy_id("return_list_of_deployments_by_deploy_id");
            if (dt.Rows.Count > 0)
            {
                gdv_deployment_summary.DataSource = dt;

                gdv_deployment_summary.Columns["deploy_details_id"].Visible = false;
                gdv_deployment_summary.Columns["guard_name"].HeaderText= "Guard";
                gdv_deployment_summary.Columns["branch_name"].HeaderText = "Branch";
                gdv_deployment_summary.Columns["deploy_date"].HeaderText = "Date";
                gdv_deployment_summary.Columns["deploy_type"].HeaderText = "Deploy Type";
                gdv_deployment_summary.Columns["shift_type"].HeaderText = "Shift";

                gdv_deployment_summary.Columns["deploy_date"].Width = 40;
                gdv_deployment_summary.Columns["guard_name"].Width = 150;

                gdv_deployment_summary.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_deployment_summary.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_deployment_summary.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_deployment_summary.DefaultCellStyle.SelectionBackColor = Color.Brown;
                gdv_deployment_summary.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_deployment_summary.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_deployment_summary.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_deployment_summary.EnableHeadersVisualStyles = false;
            }
        }
    }
}
