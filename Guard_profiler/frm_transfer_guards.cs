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
    public partial class frm_transfer_guards : Form
    {
        public frm_transfer_guards()
        {
            InitializeComponent();
        }

        private void frm_transfer_guards_Load(object sender, EventArgs e)
        {
            GET_GUARD_LIST();
            GET_BRANCHES();
            GET_BRANCHES_NEW();
            GET_BRANCHES_SEARCH();
        }

        protected void GET_GUARD_LIST()
        {
            try
            {
                DataTable dt = App_code.sg_Profiles.RETURN_OFFICER_LIST("SELECT_LIST_OF_GUARDS_WITH_GUARD_NUMBER");
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;

                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[5].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "Guard Number";
                    gdv_guards.Columns[2].HeaderText = "Name";
                    gdv_guards.Columns[3].HeaderText = "Department";
                    gdv_guards.Columns[4].HeaderText = "Position";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        protected void GET_BRANCHES_NEW() 
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
                cbo_new_branch.DataSource = dt;
                cbo_new_branch.DisplayMember = "branch";
                cbo_new_branch.ValueMember = "branch_code";

            }
        }

        protected void GET_BRANCHES_SEARCH() 
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
                cbo_branch_search.DataSource = dt;
                cbo_branch_search.DisplayMember = "branch";
                cbo_branch_search.ValueMember = "branch_code";

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_guards.Rows.Count > 0)
            {
                txt_guid.Text = gdv_guards.CurrentRow.Cells[0].Value.ToString();
                cbo_branch.Text = gdv_guards.CurrentRow.Cells[5].Value.ToString();
                txt_full_name.Text = gdv_guards.CurrentRow.Cells[2].Value.ToString();
                txt_guard_number.Text = gdv_guards.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void cbo_new_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.Text != String.Empty)
            {
                txt_guard_number_auto_code.Text = cbo_new_branch.SelectedValue.ToString();
            }
            else
            {
                txt_guard_number_auto_code.Clear();
            }
        }

        private void txt_guard_number_static_code_TextChanged(object sender, EventArgs e)
        {
            if (txt_guard_number_auto_code.Text != String.Empty && txt_guard_number_static_code.Text != String.Empty)
            {
                txt_guard_number_complete.Text = txt_guard_number_auto_code.Text + "" + txt_guard_number_static_code.Text;
            }
            else
            {
                txt_guard_number_complete.Clear();
            }
        }

        private void cbo_new_branch_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select Guard for transfer");
            }
        }

        private void btn_transfer_Click(object sender, EventArgs e)
        {
            if (cbo_new_branch.Text == String.Empty || txt_guard_number_static_code.Text == String.Empty || txt_guard_number_complete.Text == String.Empty)
            {
                MessageBox.Show("Select Guard's new branch and supply a correct guard number to execute transfer","Transfer Guards",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to transfer " + txt_full_name.Text + " from " + cbo_branch.Text + " to " + cbo_new_branch.Text + "?", "Transfer Guards", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    int guard_number_exists = sg_Profiles.CHECK_IF_GUARD_NUMBER_IS_ASSIGNED("CHECK_IF_GUARD_NUMBER_IS_ASSIGNED", txt_guard_number_complete.Text);
                    if (guard_number_exists > 0)
                    {
                        MessageBox.Show("The guard number you have selected already belongs to an active guard in " + cbo_new_branch.Text + " Branch.");
                    }
                    else
                    {
                        sg_Profiles.EXECUTE_GUARD_TRANSFER("EXECUTE_GUARD_TRANSFER", txt_guid.Text, txt_guard_number_complete.Text, cbo_new_branch.Text);
                        sg_Profiles.INSERT_GUARD_TRANSFER_LOG("INSERT_GUARD_TRANSFER_LOG", txt_guid.Text, txt_full_name.Text, cbo_branch.Text, txt_guard_number.Text, cbo_new_branch.Text, txt_guard_number_complete.Text, SystemConst._username);
                        MessageBox.Show("Guard has been transfered successfully");
                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }
            }
        }

        private void txt_guard_number_static_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (txt_guard_number_auto_code.Text == String.Empty)
            //{
            //    MessageBox.Show("No branch selected");
            //    txt_guard_number_static_code.Clear();
            //}
        }

        private void txt_guard_number_static_code_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_guard_number_auto_code.Text == String.Empty)
            {
                MessageBox.Show("No branch selected");
                txt_guard_number_static_code.Clear();
            }
        }

        private void btn_name_search_Click(object sender, EventArgs e)
        {
            if (txt_name_search.Text != String.Empty)
            {
                DataTable dt = sg_Profiles.RETURN_SEARCH_RESULTS("SEARCH_GUARDS_BY_NAME_FOR_TRANSFER_FORM", txt_name_search.Text);
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;

                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[5].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "Guard Number";
                    gdv_guards.Columns[2].HeaderText = "Name";
                    gdv_guards.Columns[3].HeaderText = "Department";
                    gdv_guards.Columns[4].HeaderText = "Position";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            else
            {
                GET_GUARD_LIST();
            }
        }

        private void btn_branch_search_Click(object sender, EventArgs e)
        {
            if (cbo_branch_search.Text != String.Empty)
            {
                DataTable dt = sg_Profiles.SEARCH_GUARDS_BY_BRANCH("SEARCH_GUARDS_BY_BRANCH_FOR_TRANSFER_FORM", cbo_branch_search.Text);
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;

                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[5].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "Guard Number";
                    gdv_guards.Columns[2].HeaderText = "Name";
                    gdv_guards.Columns[3].HeaderText = "Department";
                    gdv_guards.Columns[4].HeaderText = "Position";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            else
            {
                GET_GUARD_LIST();
            }
        }
    }
}
