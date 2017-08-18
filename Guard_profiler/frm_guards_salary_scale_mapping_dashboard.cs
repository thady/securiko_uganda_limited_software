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
    public partial class frm_guards_salary_scale_mapping_dashboard : Form
    {
        public frm_guards_salary_scale_mapping_dashboard()
        {
            InitializeComponent();
        }

        private void frm_guards_salary_scale_mapping_dashboard_Load(object sender, EventArgs e)
        {
            Return_guard_salary_mappings();
        }

        protected void Return_guard_salary_mappings()
        {
            DataTable dt = Salary_scales.return_guard_salary_mappings("return_guard_salary_mappings");
            if (dt.Rows.Count > 0)
            {
                gdv_guard_salaries.DataSource = dt;

                gdv_guard_salaries.Columns[0].HeaderText = "Guard Name";
                gdv_guard_salaries.Columns[1].HeaderText = "Branch";
                gdv_guard_salaries.Columns[2].HeaderText = "Duration Served(Years):0 Means Less than a year";
                gdv_guard_salaries.Columns[3].HeaderText = "Posible Salary Scale";

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
    }
}
