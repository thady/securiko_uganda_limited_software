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
        //static variable to keep of weekend days selected
        static bool _is_weekend = false;
        static bool _is_public_holiday = false;

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

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

        //return guards for batch deploy....
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
                gdv_deployment_summary.Columns["is_weekend"].Visible = false;

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

                //set batch save status as not saved
                chk_save_status.Checked = false;
            }
            else
            {

                gdv_deployment_summary.DataSource = dt;
            }
        }

        //return guards for particular deploy date which was already saved
        protected void Get_list_of_guards_for_selected_deploy_date()
        {
            if (dt_deployment_date.Checked == false)
            {
                MessageBox.Show("Select a deployment date", "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable dt = Guard_deployment.select_list_of_guards_by_branch_and_date_for_selected_date("select_list_of_guards_by_branch_and_date_for_selected_date", cbo_branch.Text, dt_deployment_date.Value.Date);
                if (dt.Rows.Count > 0)
                {
                    //set value of deployment date
                    DataRow dtRow = dt.Rows[0];
                    gdv_deployment_summary.DataSource = dt;

                    gdv_deployment_summary.Columns["deploy_type"].Visible = false;
                    gdv_deployment_summary.Columns["branch_name"].Visible = false;
                    gdv_deployment_summary.Columns["guard_auto_id"].Visible = false;
                    gdv_deployment_summary.Columns["firearm_serial"].Visible = false;
                    gdv_deployment_summary.Columns["number_of_ammunitions"].Visible = false;
                    gdv_deployment_summary.Columns["is_leave_day_for_guard"].Visible = false;
                    gdv_deployment_summary.Columns["is_public_holiday"].Visible = false;
                    gdv_deployment_summary.Columns["record_guid"].Visible = false;
                    gdv_deployment_summary.Columns["is_weekend"].Visible = false;

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

                    //set this batch as saved already
                    chk_save_status.Checked = true;
                }
                else
                {
                    gdv_deployment_summary.DataSource = dt;
                }
            }  
        }

        protected void Save_or_Update_batch_deployment()
        {
            if (gdv_deployment_summary.Rows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("This might take a while.Save Batch Deploy?", " Batch Deploy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < gdv_deployment_summary.Rows.Count; i++)
                    {
                        string guard_number = gdv_deployment_summary.Rows[i].Cells[1].Value.ToString();
                        string guard_name = gdv_deployment_summary.Rows[i].Cells[0].Value.ToString();
                        DateTime deployment_date = Convert.ToDateTime(gdv_deployment_summary.Rows[i].Cells[2].Value);
                        string deploy_type = gdv_deployment_summary.Rows[i].Cells[8].Value.ToString();
                        string branch_name = gdv_deployment_summary.Rows[i].Cells[9].Value.ToString();
                        string client_code = gdv_deployment_summary.Rows[i].Cells[5].Value.ToString();
                        string client_location = gdv_deployment_summary.Rows[i].Cells[6].Value.ToString();
                        string fire_arm_serial = gdv_deployment_summary.Rows[i].Cells[11].Value.ToString();
                        int ammunition_count = Convert.ToInt32(gdv_deployment_summary.Rows[i].Cells[12].Value.ToString());
                        string shift_type = gdv_deployment_summary.Rows[i].Cells[7].Value.ToString();
                        bool is_leave_day_for_guard = Convert.ToBoolean(gdv_deployment_summary.Rows[i].Cells[13].Value);
                        
                        //call function to save this batch record
                        Guard_deployment.Save_new_deployment_record("save_new_deployment_record", dt_start_date.Value.Date, dt_end_date.Value.Date, SystemConst._username, guard_number, deployment_date,
                        deploy_type, branch_name, client_code, client_location, guard_name, fire_arm_serial, ammunition_count, shift_type, is_leave_day_for_guard,_is_public_holiday,
                        _is_weekend);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }

                MessageBox.Show("Successfully deployed all guards in " + cbo_branch.Text + " for this date" , "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                chk_save_status.Checked = true;
                //Return_list_of_deployments_by_deploy_id();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Save_or_Update_batch_deployment();
        }

        private void chk_apply_to_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_apply_to_all.Checked == true & cbo_working_shift.Text != String.Empty)
            {
                for (int i = 0; i < gdv_deployment_summary.Rows.Count; i++)
                {
                    gdv_deployment_summary.Rows[i].Cells[7].Value = cbo_working_shift.Text;
                }
            }
            else
            {
                btn_guard_list_Click(btn_guard_list, null);
            }
        }

        private void cbo_working_shift_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_working_shift.Text != String.Empty)
            {
                if (chk_apply_to_all.Checked == true)
                {
                    chk_apply_to_all_CheckedChanged(chk_apply_to_all, null);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Get_list_of_guards_for_selected_deploy_date();
        }

        private void gdv_deployment_summary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chk_save_status.Checked == false)
            {
                MessageBox.Show("Save deployment batch before editing", "Batch Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //set static params in sysconst class
                SystemConst._client_codee = gdv_deployment_summary.CurrentRow.Cells[4].Value.ToString();
                SystemConst._client_location = gdv_deployment_summary.CurrentRow.Cells[5].Value.ToString();
                SystemConst._fire_arm_serial = gdv_deployment_summary.CurrentRow.Cells[10].Value.ToString();
                SystemConst._ammunition_count = Convert.ToInt32(gdv_deployment_summary.CurrentRow.Cells[11].Value.ToString());
                SystemConst._shift_type = gdv_deployment_summary.CurrentRow.Cells[6].Value.ToString();
                SystemConst._is_leave_day_for_guard = Convert.ToBoolean(gdv_deployment_summary.CurrentRow.Cells[12].Value);
                SystemConst._is_public_holiday = Convert.ToBoolean(gdv_deployment_summary.CurrentRow.Cells[13].Value);
                SystemConst._record_guid = gdv_deployment_summary.CurrentRow.Cells[14].Value.ToString();
                SystemConst._guard_name = gdv_deployment_summary.CurrentRow.Cells[0].Value.ToString();
                SystemConst._branch = gdv_deployment_summary.CurrentRow.Cells[8].Value.ToString();
                //show edit screen
                frm_edit_guard_deployment_record edit = new frm_edit_guard_deployment_record();
                edit.ShowDialog();
            }
            
        }

        private void dt_deployment_date_ValueChanged(object sender, EventArgs e)
        {
            //check if selected date is a weekend
            if (dt_deployment_date.Value.Date.DayOfWeek == DayOfWeek.Saturday || dt_deployment_date.Value.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                _is_weekend = true;
            }
            else
            {
                _is_weekend = false;
            }

            //check if selected date is a public holiday
            if (Guard_deployment.check_if_deployment_date_is_public_holiday("check_if_deployment_date_is_public_holiday", dt_deployment_date.Value.Date) > 0)
            {
                _is_public_holiday = true;
            }
            else
            {
                _is_public_holiday = false;
            }
        }
    }
}
