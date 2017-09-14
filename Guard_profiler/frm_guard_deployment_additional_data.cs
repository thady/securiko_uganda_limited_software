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
    public partial class frm_guard_deployment_additional_data : Form
    {
        public frm_guard_deployment_additional_data()
        {
            InitializeComponent();
        }

        private void frm_guard_deployment_additional_data_Load(object sender, EventArgs e)
        {

            //set the current deployment period
            dt_start_date.Value = SystemConst._deployment_start_date;
            dt_end_date.Value = SystemConst._deployment_end_date;

            GET_BRANCHES();

            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            Get_guard_list();
        }

        protected void Get_guard_list()
        {
            if (cbo_branch.Text == String.Empty)
            {
                MessageBox.Show("Select a branch to search", "Guard Deployments", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = Guard_deployment.select_list_of_guards_for_additional_deployment_data_entry("select_list_of_guards_for_additional_deployment_data_entry", cbo_branch.Text,dt_start_date.Value.Date,dt_end_date.Value.Date);
                if (dt.Rows.Count > 0)
                {
                    gdv_guards.DataSource = dt;

                    gdv_guards.Columns["auto_id"].Visible = false;
                    gdv_guards.Columns["payment_month"].Visible = false;

                    //set read only columns
                    gdv_guards.Columns["branch"].ReadOnly = true;
                    gdv_guards.Columns["guard_number"].ReadOnly = true;
                    gdv_guards.Columns["days_worked"].ReadOnly = true;
                    gdv_guards.Columns["overtime"].ReadOnly = true;
                    gdv_guards.Columns["days_absent"].ReadOnly = true;
                    gdv_guards.Columns["full_name"].ReadOnly = true;

                    //set head texts
                    gdv_guards.Columns["guard_number"].HeaderText = "Guard No.";
                    gdv_guards.Columns["full_name"].HeaderText = "Name";
                    gdv_guards.Columns["branch"].HeaderText = "Branch";
                    gdv_guards.Columns["days_worked"].HeaderText = "Days";
                    gdv_guards.Columns["overtime"].HeaderText = "Ovt";
                    gdv_guards.Columns["days_absent"].HeaderText = "Absent";
                    gdv_guards.Columns["total_advance_in_month"].HeaderText = "Advance";
                    gdv_guards.Columns["total_arrears_in_month"].HeaderText = "Arrears";
                    gdv_guards.Columns["special_cash_additions"].HeaderText = "Special";
                    gdv_guards.Columns["residential_cost"].HeaderText = "Residential";
                    gdv_guards.Columns["uniform_costs"].HeaderText = "Uniform";
                    gdv_guards.Columns["local_service_tax_cost"].HeaderText = "LST";
                    gdv_guards.Columns["other_penalties_cost"].HeaderText = "Penalty";
                    gdv_guards.Columns["other_refunds"].HeaderText = "Refund";

                    gdv_guards.Columns["full_name"].Width = 250;
                    gdv_guards.Columns["guard_number"].Width = 120;
                    gdv_guards.Columns["residential_cost"].Width = 100;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    //set gridlines style
                    this.gdv_guards.BorderStyle = BorderStyle.FixedSingle;

                    foreach (DataGridViewColumn c in gdv_guards.Columns)
                    {
                        c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
                    }

                    //set the background color of the header row
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                    gdv_guards.EnableHeadersVisualStyles = false;
                
            }
                else {
                    DataTable dtNull = null;
                    gdv_guards.DataSource = dtNull;
                }
            }
        }

        //fired to prevent users from entering text in the grid
        private void gdv_guards_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gdv_guards.CurrentCell.ColumnIndex == 8)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 9)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 10)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 11)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 12)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 13)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 14)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
            else if (gdv_guards.CurrentCell.ColumnIndex == 15)
            {
                e.Control.KeyPress += new KeyPressEventHandler(gvAppSummary_KeyPress);
            }
        }

        //prevent typing text into the grid
        private void gvAppSummary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (gdv_guards.Rows.Count > 0)
            {

                DialogResult dialogResult = MessageBox.Show("This might take a while.Proceed?", " Message Centre", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < gdv_guards.Rows.Count; i++)
                    {
                        int guard_auto_id = Convert.ToInt32(gdv_guards.Rows[i].Cells[1].Value.ToString());
                        DateTime pay_month = dt_start_date.Value.Date;
                        string guard_number = gdv_guards.Rows[i].Cells[2].Value.ToString();
                        int days_worked = gdv_guards.Rows[i].Cells[4].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[4].Value.ToString()) : 0;
                        int over_time_days_worked = gdv_guards.Rows[i].Cells[5].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[5].Value.ToString()) : 0;
                        int days_absent = gdv_guards.Rows[i].Cells[7].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[7].Value.ToString()) : 0;
                        float total_advance_in_month = gdv_guards.Rows[i].Cells[8].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[8].Value.ToString()) : 0;
                        float total_arrears_in_month = gdv_guards.Rows[i].Cells[9].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[9].Value.ToString()) : 0;
                        float special_cash_additions = gdv_guards.Rows[i].Cells[10].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[10].Value.ToString()) : 0;
                        float residential_cost = gdv_guards.Rows[i].Cells[11].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[11].Value.ToString()) : 0;
                        float uniform_costs = gdv_guards.Rows[i].Cells[12].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[12].Value.ToString()) : 0;
                        float local_service_tax_cost = gdv_guards.Rows[i].Cells[13].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[13].Value.ToString()) : 0;
                        float other_penalties_cost = gdv_guards.Rows[i].Cells[14].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[14].Value.ToString()) : 0;
                        float other_refunds = gdv_guards.Rows[i].Cells[15].Value.ToString() != String.Empty ? Convert.ToInt32(gdv_guards.Rows[i].Cells[15].Value.ToString()) : 0;

                        //save row records
                        Guard_deployment.Save_update_guard_additional_deployment_data("save_update_guard_additional_deployment_data", guard_number, pay_month, guard_auto_id, days_worked, over_time_days_worked, days_absent, total_advance_in_month,
                        total_arrears_in_month, special_cash_additions, residential_cost, uniform_costs, local_service_tax_cost, other_penalties_cost, other_refunds);
                    }

                    MessageBox.Show("All records saved successfully", "Message Centre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_search_Click(btn_search, null);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }   
            }
            else
            {
                MessageBox.Show("No records available to save", "Message Centre", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
