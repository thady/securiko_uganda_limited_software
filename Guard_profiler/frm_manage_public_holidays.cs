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
    public partial class frm_manage_public_holidays : Form
    {
        public frm_manage_public_holidays()
        {
            InitializeComponent();
        }

        private void frm_manage_public_holidays_Load(object sender, EventArgs e)
        {
            //set the current deployment period
            dt_start_date.Value = SystemConst._deployment_start_date;
            dt_end_date.Value = SystemConst._deployment_end_date;

            get_list_of_public_holidays();
        }

        protected void get_list_of_public_holidays()
        {
            DataTable dt = Guard_deployment.return_list_of_public_holidays("return_list_of_public_holidays");
            if (dt.Rows.Count > 0)
            {
                gdv_public_holidays.DataSource = dt;

                gdv_public_holidays.Columns["record_guid"].Visible = false;
                gdv_public_holidays.Columns["deployment_period_id"].Visible = false;

                gdv_public_holidays.Columns["public_holiday_name"].HeaderText = "Public Holiday Name";
                gdv_public_holidays.Columns["public_holiday_date"].HeaderText = "Public Holiday Date";

                gdv_public_holidays.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_public_holidays.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_public_holidays.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_public_holidays.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_public_holidays.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_public_holidays.DefaultCellStyle.SelectionBackColor = Color.Cyan;
                gdv_public_holidays.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_public_holidays.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 11F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_public_holidays.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_public_holidays.EnableHeadersVisualStyles = false;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_public_holiday_name.Text == String.Empty)
            {
                MessageBox.Show("Missing public holiday name", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_public_holiday_name.Text.Length < 2)
            {
                MessageBox.Show("Type in a valid public holiday name", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dt_public_holiday_date.Value.Date < dt_start_date.Value.Date || dt_public_holiday_date.Value.Date > dt_end_date.Value.Date)
            {
                MessageBox.Show("Public holiday must be in range of current deployment period", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txt_record_guid.Text != String.Empty)
            {
                //update public holiday
                Guard_deployment.update_public_holiday_details("update_public_holiday_details", txt_record_guid.Text, txt_public_holiday_name.Text, dt_public_holiday_date.Value.Date);
                MessageBox.Show("Successfully updated public holiday", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Information);
                get_list_of_public_holidays();
            }
            else
            {
                Guard_deployment.save_new_public_holiday("save_new_public_holiday", Convert.ToInt32(SystemConst._active_deployment_id), txt_public_holiday_name.Text, dt_public_holiday_date.Value.Date);
                MessageBox.Show("Successfully saved public holiday", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Information);
                get_list_of_public_holidays();
            }
        }

        private void gdv_public_holidays_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_public_holidays.Rows.Count > 0)
            {
                txt_public_holiday_name.Text = gdv_public_holidays.CurrentRow.Cells[2].Value.ToString();
                dt_public_holiday_date.Value = Convert.ToDateTime(gdv_public_holidays.CurrentRow.Cells[3].Value);
                txt_record_guid.Text = gdv_public_holidays.CurrentRow.Cells[0].Value.ToString();

                txt_public_holiday_name.ReadOnly = true;
                dt_public_holiday_date.Enabled = false;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txt_record_guid.Text == String.Empty) { MessageBox.Show("Select a record first", "Public Holidays", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                txt_public_holiday_name.ReadOnly = false;
                dt_public_holiday_date.Enabled = true;
                
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_public_holiday_name.ReadOnly = false;
            dt_public_holiday_date.Enabled = true;

            txt_record_guid.Clear();
            txt_public_holiday_name.Clear();
            dt_public_holiday_date.Value = DateTime.Today;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this public holiday", "Delete Public holiday", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Guard_deployment.delete_public_holiday("delete_public_holiday", txt_record_guid.Text);
                get_list_of_public_holidays();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
            }
        }
    }
}
