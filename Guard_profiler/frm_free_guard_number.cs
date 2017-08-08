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
    public partial class frm_free_guard_number : Form
    {
        public frm_free_guard_number()
        {
            InitializeComponent();
        }

        private void frm_free_guard_number_Load(object sender, EventArgs e)
        {
            GET_GUARD_LIST();
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
                    gdv_guards.Columns[1].HeaderText = "Guard Number";
                    gdv_guards.Columns[2].HeaderText = "Name";

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

        protected void SEARCH_GUARD_BY_GUARD_NUMBER() 
        {
            try
            {
                DataTable dt = sg_Profiles.RETURN_OFFICER_LIST_BY_GUARD_NUMBER("SEARCH_GUARD_BY_NUMBER", txt_guard_number.Text);
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;

                    gdv_guards.Columns[0].Visible = false;

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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                GET_GUARD_LIST();
            }
            else
            {

                SEARCH_GUARD_BY_GUARD_NUMBER();
            }
        }

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_guard_number_remove.Text = gdv_guards.CurrentRow.Cells[1].Value.ToString();
            txt_guid.Text = gdv_guards.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_un_assigned_Click(object sender, EventArgs e)
        {
            ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD();
        }

        protected void ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD()
        {
            if (txt_guard_number_remove.Text == String.Empty)
            {
                MessageBox.Show("Select or type in a guard number to archieve");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You are about to remove a number from a guard,this will archieve the guard's details.This action cannot be undone,proceed??", "Archieve Guard", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sg_Profiles.UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS("UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS", txt_guid.Text);
                    MessageBox.Show("All guard details have been successfully archieved,you can access them from the archived guards module");
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                    txt_guard_number.Clear();
                    txt_guard_number_remove.Clear();
                }
            }
           
        }
    }
}
