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
    public partial class frm_deployment_periods : Form
    {
        public frm_deployment_periods()
        {
            InitializeComponent();
        }

        private void frm_deployment_periods_Load(object sender, EventArgs e)
        {
            //return list of deployment periods
            return_deployment_periods();


        }

        protected void return_deployment_periods()
        {
            DataTable dt = Guard_deployment.Return_list_of_deployment_periods("return_list_of_deployment_periods");
            if (dt.Rows.Count > 0)
            {
                gdv_deployment_periods.DataSource = dt;

                gdv_deployment_periods.Columns["deploy_id"].Visible = false;

                gdv_deployment_periods.Columns["deploy_start_date"].HeaderText = "Deployment start date";
                gdv_deployment_periods.Columns["deploy_end_date"].HeaderText = "Deployment end date";
                gdv_deployment_periods.Columns["created_by"].HeaderText = "Created by";
                gdv_deployment_periods.Columns["active_deployment"].HeaderText = "Active Deployment";

                gdv_deployment_periods.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_deployment_periods.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_deployment_periods.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_deployment_periods.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_deployment_periods.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                gdv_deployment_periods.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_deployment_periods.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_deployment_periods.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_deployment_periods.EnableHeadersVisualStyles = false;
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dt_start_date.Value = DateTime.Today;
            dt_end_date.Value = DateTime.Today;
            chk_active.Checked = false;
            lbl_guid.Text = "lbl_guid";
        }

        private void gdv_deployment_periods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_deployment_periods.Rows.Count > 0)
            {
                dt_start_date.Value = Convert.ToDateTime(gdv_deployment_periods.CurrentRow.Cells[1].Value);
                dt_end_date.Value = Convert.ToDateTime(gdv_deployment_periods.CurrentRow.Cells[2].Value);
                chk_active.Checked = Convert.ToBoolean(gdv_deployment_periods.CurrentRow.Cells[4].Value);
                lbl_guid.Text = gdv_deployment_periods.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            Save_deployment_periods();
        }

        protected void Save_deployment_periods()
        {
            if (dt_start_date.Value.Date.Day != 1 && (dt_end_date.Value.Date.Day != 30 || dt_end_date.Value.Date.Day != 31))
            {
                MessageBox.Show("Please select first and last days of the month only", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (lbl_guid.Text == "lbl_guid" && chk_active.Checked == true)
                {
                    if (Guard_deployment.check_if_deployment_period_already_exists("check_if_deployment_period_already_exists", dt_start_date.Value.Date, dt_end_date.Value.Date) > 0)
                    {
                        MessageBox.Show("Deployment period already exists!!", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("This will save and set this deployment period as the active deployment,are you sure to proceed?", "Deployments", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //call save function
                            Guard_deployment.Save_new_deployment_period("save_new_deployment_period", dt_start_date.Value.Date, dt_end_date.Value.Date, chk_active.Checked == true ? true : false);
                            return_deployment_periods();
                            Set_current_deployment_periods();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do nothing
                            this.Visible = true;
                        }
                    }  
                }
                else if (lbl_guid.Text == "lbl_guid" && chk_active.Checked == false)
                {
                    if (Guard_deployment.check_if_deployment_period_already_exists("check_if_deployment_period_already_exists", dt_start_date.Value.Date, dt_end_date.Value.Date) > 0)
                    {
                        MessageBox.Show("Deployment period already exists!!", "Deployment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Guard_deployment.Save_new_deployment_period("save_new_deployment_period", dt_start_date.Value.Date, dt_end_date.Value.Date, chk_active.Checked == true ? true : false);
                        return_deployment_periods();
                    } 
                }
                else if (lbl_guid.Text != "lbl_guid" && chk_active.Checked == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure to set this as the current deployment period?", "Deployments", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //call update function
                        Guard_deployment.Set_active_deployment("set_active_deployment", Convert.ToInt32(lbl_guid.Text), chk_active.Checked == true ? true : false);
                        return_deployment_periods();
                        Set_current_deployment_periods();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                        this.Visible = true;
                    }
                }
                else if (lbl_guid.Text != "lbl_guid" && chk_active.Checked == false)
                {
                   // MessageBox.Show("You cannot unset a deployment period before setting one,please set another deployment period and this will be unset automatically", "Deployments", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //set deployment periods
        protected void Set_current_deployment_periods()
        {
            DataTable dt = Guard_deployment.Select_active_deployment_period("select_active_deployment_period");
            if (dt.Rows.Count > 0)
            {
                DataRow dtRow = dt.Rows[0];
                SystemConst._active_deployment_id = Convert.ToInt32(dtRow["deploy_id"].ToString()).ToString();
                SystemConst._deployment_start_date = Convert.ToDateTime(dtRow["deploy_start_date"]);
                SystemConst._deployment_end_date = Convert.ToDateTime(dtRow["deploy_end_date"]);
            }
        }
    }
}

