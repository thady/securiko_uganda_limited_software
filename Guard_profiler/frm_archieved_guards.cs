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
    public partial class frm_archieved_guards : Form
    {
        public frm_archieved_guards()
        {
            InitializeComponent();
        }

        private void frm_archieved_guards_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            GET_LIST_OF_ARCHIEVED_GUARDS();
        }

        protected void GET_LIST_OF_ARCHIEVED_GUARDS() 
        {
            try
            {
                DataTable dt = App_code.sg_Profiles.RETURN_OFFICER_LIST("SELECT_LIST_OF_ARCHIEVED_GUARDS");
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
    }
}
