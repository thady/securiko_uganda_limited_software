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
    public partial class frm_edit_guard_deployment_record : Form
    {
        public frm_edit_guard_deployment_record()
        {
            InitializeComponent();
        }

        private void frm_edit_guard_deployment_record_Load(object sender, EventArgs e)
        {
            Return_list_of_clients();
            Get_guard_shift_types();

            Set_static_deploy_variables();

        }

        protected void Set_static_deploy_variables()
        {
            lbl_record_guid.Text = SystemConst._record_guid;
            cbo_customer_name.SelectedValue = SystemConst._client_codee;
            cbo_customer_location.Text = SystemConst._client_location;
            cbo_working_shift.Text = SystemConst._shift_type;
            txt_fire_arm_serial.Text = SystemConst._fire_arm_serial.ToString();
            txt_ammunition_count.Text = SystemConst._ammunition_count.ToString();
            chk_public_holiday.Checked = SystemConst._is_public_holiday;
            chk_leave.Checked = SystemConst._is_leave_day_for_guard;
            lbl_branch.Text = SystemConst._branch;
            lbl_name.Text = SystemConst._guard_name;
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

        private void cbo_customer_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_client_code.Text = cbo_customer_name.Text != String.Empty ? cbo_customer_name.SelectedValue.ToString() : String.Empty;

            Return_client_locations(cbo_customer_name.SelectedValue.ToString());
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("All unsaved changes for " + lbl_name.Text + " will be lost!sure to close??", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_client_code.Text == String.Empty || cbo_customer_location.Text == String.Empty || cbo_working_shift.Text == String.Empty)
            {
                MessageBox.Show("All values shaded red are required", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (chk_absent.Checked == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Marking" + lbl_name.Text + " as absent will delete this record from the deployment list for this date.sure to proceed?", "Deploy guards", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Guard_deployment.delete_guard_marked_as_absent_from_deployment_list_per_date("delete_guard_marked_as_absent_from_deployment_list_per_date", lbl_record_guid.Text);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Visible = true;
                    }
                }
                else
                {
                    Guard_deployment.Update_guard_deployment_record("update_guard_deployment_record", lbl_record_guid.Text, txt_client_code.Text, cbo_customer_location.Text, txt_fire_arm_serial.Text, txt_ammunition_count.Text != String.Empty ? Convert.ToInt32(txt_ammunition_count.Text) : 0, cbo_working_shift.Text, chk_leave.Checked == true ? true : false);
                    MessageBox.Show("Updated deployment record for " + lbl_name.Text + " successfully", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }  
            }
        }
    }
}
