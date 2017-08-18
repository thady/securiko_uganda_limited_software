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
    public partial class frm_salary_scale_guards : Form
    {
        public frm_salary_scale_guards()
        {
            InitializeComponent();
        }

        private void frm_salary_scale_guards_Load(object sender, EventArgs e)
        {
            get_list_of_salary_scales_for_guards();
        }

        protected void save_or_update_salary_scale_guards()
        {
            if (txt_scale_name.Text == String.Empty || txt_year_maximum.Text == String.Empty || txt_year_minimum.Text == String.Empty || txt_amt.Text == String.Empty)
            {
                MessageBox.Show("All fields are required", "save scale details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Salary_scales.save_or_update_salary_scale_guards("save_or_update_salary_scale_guards", txt_scale_name.Text, Convert.ToInt32(txt_year_minimum.Text),
                Convert.ToInt32(txt_year_maximum.Text), float.Parse(txt_amt.Text), txt_record_guid.Text != String.Empty?txt_record_guid.Text:null);
                MessageBox.Show("New salary saved successfully", "save scale details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save_or_update_salary_scale_guards();
        }

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

                gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_salary_scales.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_salary_scales.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_salary_scales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_salary_scales.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_salary_scales.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_salary_scales.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_salary_scales.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_salary_scales.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }
            }
        }

        protected void auto_assign_salary_scale_to_guard()
        {
            DataTable dt = Salary_scales.return_number_of_years_served_for_each_gaurd("return_number_of_years_served_for_each_gaurd");
            if (dt.Rows.Count > 0)
            {
                //loop through all rows to map with salary scale id
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dtRow = dt.Rows[i];
                    int guard_auto_id = Convert.ToInt32(dtRow["auto_id"].ToString());
                    string guard_number = (String)dtRow["guard_number"];
                    int Duration = Convert.ToInt32(dtRow["Duration"].ToString());

                    //save or update scale-guard mapping
                    try
                    {
                        Salary_scales.auto_assign_salary_scale_to_guard("auto_assign_salary_scale_to_guard", Duration, guard_auto_id, guard_number);
                    }
                    catch (Exception ex) { throw ex; }
                }

                MessageBox.Show("All Guards salary scales successfully updated", "Update salary scales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_update_salaries_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This might take a while,proceed?", "Update guard salary scales", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;
                auto_assign_salary_scale_to_guard();
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
