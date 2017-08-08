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
    public partial class frm_lookups : Form
    {
        public frm_lookups()
        {
            InitializeComponent();
        }

        private void frm_lookups_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            GET_BRANCHES();
            GET_DEPARTMENTS();
            GET_POSITIONS();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_branch_name.Text == String.Empty)
            {
                MessageBox.Show("Branch name required");
            }
            else
            {
                if (txt_branch_id.Text != String.Empty)
                {
                    System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_BRANCH_DETAILS", txt_branch_name.Text, chk_branch_active.Checked == true ? true : false, Convert.ToInt32(txt_branch_id.Text),txt_branch_code.Text);
                    MessageBox.Show("Successfully updated branch details");

                    GET_BRANCHES();
                }
                else
                {
                    System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_BRANCH_DETAILS", txt_branch_name.Text, chk_branch_active.Checked == true ? true : false,txt_branch_code.Text);
                    MessageBox.Show("Successfully saved branch details");

                    GET_BRANCHES();
                }
               
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_dept_Click(object sender, EventArgs e)
        {
            if (txt_dept_name.Text == String.Empty)
            {
                MessageBox.Show("Department name required");
            }
            else {
                if (txt_dept_id.Text != String.Empty)
                {

                    System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_DEPARTMENT_DETAILS", txt_dept_name.Text, chk_dept_active.Checked == true ? true : false, Convert.ToInt32(txt_dept_id.Text), txt_department_code.Text);
                    MessageBox.Show("Successfully updated department details");

                    GET_DEPARTMENTS();
                }
                else {
                    System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_DEPARTMENT_DETAILS", txt_dept_name.Text, chk_dept_active.Checked == true ? true : false,txt_department_code.Text);
                    MessageBox.Show("Successfully saved department details");

                    GET_DEPARTMENTS();
                }
                
            }
        }

        private void btn_position_save_Click(object sender, EventArgs e)
        {
            if (txt_position_name.Text == String.Empty)
            {
                MessageBox.Show("Position name required");
            }
            else
            {
                if (txt_position_id.Text != String.Empty)
                {
                    System_lookups.UPDATE_LOOKUP_DETAILS("UPDATE_POSITION_DETAILS", txt_position_name.Text, chk_position_active.Checked == true ? true : false, Convert.ToInt32(txt_position_id.Text),txt_position_code.Text);
                    MessageBox.Show("Successfully updated position details");

                    GET_POSITIONS();
                }
                else
                {
                    System_lookups.NEW_LOOKUP_DETAILS("SAVE_NEW_POSITION_DETAILS", txt_position_name.Text, chk_position_active.Checked == true ? true : false,txt_position_code.Text);
                    MessageBox.Show("Successfully saved position details");

                    GET_POSITIONS();
                }

            }
        }

        protected void GET_BRANCHES() {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                gdv_branches.DataSource = dt;
                gdv_branches.Columns[0].Visible = false;
                gdv_branches.Columns[1].Visible = false;

                gdv_branches.Columns[2].HeaderText = "Branch Name";
                gdv_branches.Columns[3].HeaderText = "Branch Active?";

                gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_branches.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_branches.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_branches.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_branches.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_branches.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_branches.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_branches.DefaultCellStyle.SelectionForeColor = Color.Black;

            }
        }
         
        protected void GET_DEPARTMENTS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_DEPARTMENTS"); 
            if (dt != null)
            {
                gdv_departments.DataSource = dt;
                gdv_departments.Columns[0].Visible = false;
                gdv_departments.Columns[1].Visible = false;

                gdv_departments.Columns[2].HeaderText = "Department Name";
                gdv_departments.Columns[3].HeaderText = "Department Active?";

                gdv_departments.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_departments.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_departments.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_departments.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_departments.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_departments.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_departments.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_departments.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_departments.DefaultCellStyle.SelectionForeColor = Color.Black;

            }
        }

        protected void GET_POSITIONS() 
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_POSITIONS");
            if (dt != null)
            {
                gdv_positions.DataSource = dt;
                gdv_positions.Columns[0].Visible = false;
                gdv_positions.Columns[1].Visible = false;

                gdv_positions.Columns[2].HeaderText = "Position Name";
                gdv_positions.Columns[3].HeaderText = "Position Active?";

                gdv_positions.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_positions.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_positions.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_positions.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_positions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_positions.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_positions.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_positions.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_positions.DefaultCellStyle.SelectionForeColor = Color.Black;

            }
        }

        private void gdv_branches_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_branches.Rows.Count != 0)
            {
                txt_branch_id.Text = gdv_branches.CurrentRow.Cells[1].Value.ToString();
                txt_branch_name.Text = gdv_branches.CurrentRow.Cells[2].Value.ToString();
                txt_branch_code.Text = gdv_branches.CurrentRow.Cells[4].Value.ToString();
                chk_branch_active.Checked = (Boolean)gdv_branches.CurrentRow.Cells[3].Value;

                panel4.Enabled = false;
            }
        }

        private void gdv_departments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_departments.Rows.Count != 0)
            {
                txt_dept_id.Text = gdv_departments.CurrentRow.Cells[1].Value.ToString();
                txt_dept_name.Text = gdv_departments.CurrentRow.Cells[2].Value.ToString();
                txt_department_code.Text = gdv_departments.CurrentRow.Cells[4].Value.ToString();
                chk_dept_active.Checked = (Boolean)gdv_departments.CurrentRow.Cells[3].Value;

                panel7.Enabled = false;
            }
        }

        private void gdv_positions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_positions.Rows.Count != 0)
            {
                txt_position_id.Text = gdv_positions.CurrentRow.Cells[1].Value.ToString();
                txt_position_name.Text = gdv_positions.CurrentRow.Cells[2].Value.ToString();
                txt_position_code.Text = gdv_positions.CurrentRow.Cells[4].Value.ToString();
                chk_position_active.Checked = (Boolean)gdv_positions.CurrentRow.Cells[3].Value;

                panel6.Enabled = false;
            }
        }

        private void btn_new_dept_Click(object sender, EventArgs e)
        {
            txt_dept_id.Clear();
            txt_dept_name.Clear();
            chk_dept_active.Checked = false;
            panel7.Enabled = true;
        }

        private void btn_edit_dept_Click(object sender, EventArgs e)
        {
            panel7.Enabled = true;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_branch_id.Clear();
            txt_branch_name.Clear();
            chk_branch_active.Checked = false;
            panel4.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel4.Enabled = true;
        }

        private void btn_position_new_Click(object sender, EventArgs e)
        {
            txt_position_id.Clear();
            txt_position_name.Clear();
            chk_position_active.Checked = false;

            panel6.Enabled = true;
        }

        private void btn_position_edit_Click(object sender, EventArgs e)
        {
            panel6.Enabled = true;
        }

    }
}
