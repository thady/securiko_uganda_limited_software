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
    public partial class frm_assign_salary_scales_to_guards : Form
    {
        public frm_assign_salary_scales_to_guards()
        {
            InitializeComponent();
        }

        private void frm_assign_salary_scales_to_guards_Load(object sender, EventArgs e)
        {
            get_list_of_salary_scales_for_guards();
            Return_guard_salary_mappings();


            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        //return list of salary scales
        protected void get_list_of_salary_scales_for_guards()
        {
            DataTable dt = Salary_scales.return_salary_scales("return_salary_scales");
            if (dt.Rows.Count > 0)
            {
                gdv_salary_scales.DataSource = dt;

                gdv_salary_scales.Columns[0].Visible = false;
                gdv_salary_scales.Columns[1].Visible = false;
                gdv_salary_scales.Columns[2].Visible = false;
                gdv_salary_scales.Columns["basic_amount"].HeaderText = "Basic Amount";
                gdv_salary_scales.Columns["salary_amount"].HeaderText = "Salary Amount";
                gdv_salary_scales.Columns["scale_name"].HeaderText = "Scale Name";
                gdv_salary_scales.Columns["transport_amount"].HeaderText = "Transport Amount";
                gdv_salary_scales.Columns["housing_amount"].HeaderText = "Housing Amount";

                gdv_salary_scales.Columns["scale_name"].Width = 220;
                gdv_salary_scales.Columns["salary_amount"].DefaultCellStyle.ForeColor = Color.Blue;

                gdv_salary_scales.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_salary_scales.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_salary_scales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_salary_scales.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.Blue;
                gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_salary_scales.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_salary_scales.EnableHeadersVisualStyles = false;
            }
        }

        //return scale mapping
        protected void Return_guard_salary_mappings()
        {
            DataTable dt = Salary_scales.return_guard_salary_mappings("return_manual_guard_salary_scale_mappings");
            if (dt.Rows.Count > 0)
            {
                gdv_guard_salaries.DataSource = dt;

                gdv_guard_salaries.Columns["full_name"].HeaderText = "Guard Name";
                gdv_guard_salaries.Columns["branch"].HeaderText = "Branch";
                gdv_guard_salaries.Columns["Duration"].HeaderText = "Duration Served(Years)";
                gdv_guard_salaries.Columns["salary_amount"].HeaderText = "Salary Amt"; 

                gdv_guard_salaries.Columns["auto_id"].Visible = false;
                gdv_guard_salaries.Columns["guard_number"].Visible = false;
                gdv_guard_salaries.Columns["scale_auto_id"].Visible = false;

                //set read only properties for these columns
                gdv_guard_salaries.Columns["full_name"].ReadOnly = true;
                gdv_guard_salaries.Columns["branch"].ReadOnly = true;
                gdv_guard_salaries.Columns["Duration"].ReadOnly = true;
                gdv_guard_salaries.Columns["salary_amount"].ReadOnly = true;

                gdv_guard_salaries.Columns["full_name"].Width = 200;
                gdv_guard_salaries.Columns["salary_amount"].DefaultCellStyle.ForeColor = Color.Blue;

                //insert the checkbox column at index 0 of the grid
                DataGridViewCheckBoxColumn chk_select_guard = new DataGridViewCheckBoxColumn();
                chk_select_guard.Name = "column_select";
                chk_select_guard.HeaderText = "Select Guard";
                chk_select_guard.FalseValue = 0;
                chk_select_guard.TrueValue = 1;
                gdv_guard_salaries.Columns.Insert(0, chk_select_guard);

                //set checkbox column to allow edits.
                gdv_guard_salaries.Columns["column_select"].ReadOnly = false;
                gdv_guard_salaries.Columns["column_select"].Width = 50;

                gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_guard_salaries.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_guard_salaries.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_guard_salaries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_guard_salaries.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_guard_salaries.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_guard_salaries.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_guard_salaries.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_guard_salaries.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_guard_salaries.EnableHeadersVisualStyles = false;
            }
        }

        private void chk_check_all_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_check_all.Checked == true)
            {
                foreach (DataGridViewRow row in gdv_guard_salaries.Rows)
                {
                    row.Cells["column_select"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in gdv_guard_salaries.Rows)
                {
                    row.Cells["column_select"].Value = false;
                }
            }
        }

        private void gdv_salary_scales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_salary_scales.Rows.Count != 0)
            {
                txt_scale_name.Text = gdv_salary_scales.CurrentRow.Cells[3].Value.ToString();
                txt_amount.Text = gdv_salary_scales.CurrentRow.Cells[4].Value.ToString();
                lbl_scale_global_id.Text = gdv_salary_scales.CurrentRow.Cells[0].Value.ToString();
                txt_auto_id.Text = gdv_salary_scales.CurrentRow.Cells[1].Value.ToString();
            }
        }

        //function below does assign salary scale to selected guards
        protected void Save_or_update_guard_salary_scale()
        {

            for (int i = 0; i < gdv_guard_salaries.Rows.Count; i++)
            {
                if ((Convert.ToBoolean(gdv_guard_salaries.Rows[i].Cells[0].Value)) == true)
                {
                    int guard_auto_id = Convert.ToInt32(gdv_guard_salaries.Rows[i].Cells[1].Value.ToString()); //guard auto id
                    string guard_number = gdv_guard_salaries.Rows[i].Cells[3].Value.ToString(); //guard number
                    int previous_scale_id = Convert.ToInt32(gdv_guard_salaries.Rows[i].Cells[7].Value.ToString());
                    int scale_id = Convert.ToInt32(txt_auto_id.Text);

                    //call function to assign scale from app code
                    Salary_scales.Salary_scale_manual_assigment_query("salary_scale_manual_assigment_query", guard_auto_id, guard_number, scale_id,SystemConst._username,previous_scale_id);
                }
            }
            //display success message after all tasks executed succesfully
            MessageBox.Show("All selected guards salary scales succesfully updated", "save scales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_assign_scales_Click(object sender, EventArgs e)
        {

            if (txt_scale_name.Text == String.Empty)
            {
                MessageBox.Show("No scale selected", "save scales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("This might take a while,proceed?", "Update guard salary scales", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    Save_or_update_guard_salary_scale();
                    this.Cursor = Cursors.Default;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do nothing
                    this.Cursor = Cursors.Default;
                }
            }
        }
    }
}
