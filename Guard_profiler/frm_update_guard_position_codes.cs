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
    public partial class frm_update_guard_position_codes : Form
    {
        public frm_update_guard_position_codes()
        {
            InitializeComponent();
        }

        private void frm_update_guard_position_codes_Load(object sender, EventArgs e)
        {

        }

        protected void UPDATE_GUARD_POSITION_CODES()
        {
            DataTable dt = Position_Codes.SELECT_GUARD_NUMBER_LIST("SELECT_GUARD_NUMBER_LIST");
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dtRow = dt.Rows[i];
                    string guard_number = (String)dtRow["guard_number"];

                    if (guard_number.Contains("CG") && !guard_number.Contains("SCG"))
                    {
                        Position_Codes.UPDATE_POSITION_CODE("UPDATE_CG_CODE",guard_number);
                    }
                    else if (guard_number.Contains("RG"))
                    {
                        Position_Codes.UPDATE_POSITION_CODE("UPDATE_RG_CODE", guard_number);
                    }
                    else if (guard_number.Contains("SCG"))
                    {
                        Position_Codes.UPDATE_POSITION_CODE("UPDATE_SCG_CODE", guard_number);
                    }
                }
            }
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("This might take longer depending on the number of officers in the system,proceed", "Assign Position Codes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Cursor = Cursors.AppStarting;
                this.Enabled = false;

                UPDATE_GUARD_POSITION_CODES();

                this.Enabled = true;
                MessageBox.Show("All guard positions assignment completed", "Assign Position Codes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Cursor = Cursors.Default;
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
            }
        }
    }
}
