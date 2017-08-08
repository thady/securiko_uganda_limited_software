using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frm_archieve_lists : Form
    {
        public frm_archieve_lists()
        {
            InitializeComponent();
        }

        private void frm_archieve_lists_Load(object sender, EventArgs e)
        {
            GET_GUARD_LIST();
            SELECT_ARCHIVED_GUARDS_STATS();
            GET_BRANCHES_SEARCH();
        }

        protected void GET_GUARD_LIST()
        {
            try
            {
                DataTable dt = App_code.Archieve_Lists.RETURN_OFFICER_LIST("SELECT_ARCHIEVED_GUARDS_LIST");
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[1].Visible = false;

                    gdv_guards.Columns[2].HeaderText = "NAME";
                    gdv_guards.Columns[3].HeaderText = "BRANCH";
                    gdv_guards.Columns[4].HeaderText = "STATUS";

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

        protected void SELECT_ARCHIVED_GUARDS_STATS() 
        {
            try
            {
                DataTable dt = App_code.Archieve_Lists.SELECT_ARCHIVED_GUARDS_STATS("SELECT_ARCHIVED_GUARDS_STATS");
                if (dt != null)
                {
                    gdv_statisctics.DataSource = dt;

                    gdv_statisctics.Columns[0].HeaderText = "STATUS";
                    gdv_statisctics.Columns[1].HeaderText = "TOTAL";

                    gdv_statisctics.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_statisctics.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_statisctics.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_statisctics.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_statisctics.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_statisctics.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_statisctics.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_statisctics.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_statisctics.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gdv_guards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void GET_BRANCHES_SEARCH()  //FOR THE SEARCH COMBO
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
                cbo_branch_search.ValueMember = "auto_id";

            }
        }

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_guards.Rows.Count != 0)
            {
                txt_guard_number.Text = gdv_guards.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btn_export_single_report_Click(object sender, EventArgs e)
        {

            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an officer to view report");
            }
            else
            {
                string guard_number = txt_guard_number.Text;
                SystemConst.guard_number = guard_number;
                SystemConst._Single_report_type = "Archieve";

                frmcrystal_report_single report = new frmcrystal_report_single();
                report.ShowDialog();
            }
        }

        private void btn_export_list_Click(object sender, EventArgs e)
        {
            SystemConst._guard_status = cbo_guard_status.Text;
            frm_archieved_guard_list_report report = new frm_archieved_guard_list_report();
            report.ShowDialog();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void btn_export_stats_Click(object sender, EventArgs e)
        {
            if (gdv_statisctics.Rows.Count == 0)
            {
                MessageBox.Show("No Archieve Stats available for export", "Stats", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Documents (*.xls)|*.xls";
                sfd.FileName = "export.xls";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //ToCsV(dataGridView1, @"c:\export.xls");
                    ToCsV(gdv_statisctics, sfd.FileName); // Here dataGridview1 is your grid view name
                }
            }
           
        }

        private void btn_name_search_Click(object sender, EventArgs e)
        {
            if (cbo_guard_status.Text != String.Empty && cbo_branch_search.Text == String.Empty)
            {
                DataTable dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS("FILTER_ARCHIEVE_BY_STATUS", cbo_guard_status.Text);

                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[1].Visible = false;

                    gdv_guards.Columns[2].HeaderText = "NAME";
                    gdv_guards.Columns[3].HeaderText = "BRANCH";
                    gdv_guards.Columns[4].HeaderText = "STATUS";

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
                else
                {
                    DataTable dt_null = null;
                    gdv_statisctics.DataSource = dt_null;
                }

            }
            else if (cbo_guard_status.Text == String.Empty && cbo_branch_search.Text != String.Empty)
            {
                DataTable dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_BRANCH("FILTER_ARCHIEVE_BY_STATION", cbo_branch_search.Text);

                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[1].Visible = false;

                    gdv_guards.Columns[2].HeaderText = "NAME";
                    gdv_guards.Columns[3].HeaderText = "BRANCH";
                    gdv_guards.Columns[4].HeaderText = "STATUS";

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
                else
                {
                    DataTable dt_null = null;
                    gdv_statisctics.DataSource = dt_null;
                }
            }
            else if (cbo_guard_status.Text != String.Empty && cbo_branch_search.Text != String.Empty)
            {
                DataTable dt = Archieve_Lists.SEARCH_ARCHIEVED_GUARD_LIST_REPORT_BY_BRANCH_AND_STATUS("FILTER_ARCHIEVE_BY_STATION", cbo_branch_search.Text, cbo_guard_status.Text);

                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[1].Visible = false;

                    gdv_guards.Columns[2].HeaderText = "NAME";
                    gdv_guards.Columns[3].HeaderText = "BRANCH";
                    gdv_guards.Columns[4].HeaderText = "STATUS";

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
                else
                {
                    DataTable dt_null = null;
                    gdv_statisctics.DataSource = dt_null;
                }
            }
            else
            {
                GET_GUARD_LIST();
            }

        }  
    }
}
