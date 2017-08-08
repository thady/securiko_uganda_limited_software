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
    public partial class frm_guard_lists : Form
    {
        public frm_guard_lists()
        {
            InitializeComponent();
        }

        private void frm_guard_lists_Load(object sender, EventArgs e)
        {
            GET_BRANCHES();
            Create_Months();
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

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (cbo_branch.Text == String.Empty || cbo_months.Text == String.Empty)
            {
                MessageBox.Show("Select a branch & Month to display report","Reports",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                SystemConst._branch = cbo_branch.Text;
                SystemConst._Report_update_month = cbo_months.Text;

                frm_active_guards_report report = new frm_active_guards_report();
                report.ShowDialog();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void Create_Months() 
        {
            List<string> Months = new List<string>();

            Months.Add(String.Empty);
            Months.Add("January" + "," + DateTime.Now.Year.ToString());
            Months.Add("February" + "," + DateTime.Now.Year.ToString());
            Months.Add("March" + "," + DateTime.Now.Year.ToString());
            Months.Add("April" + "," + DateTime.Now.Year.ToString());
            Months.Add("May" + "," + DateTime.Now.Year.ToString());
            Months.Add("June" + "," + DateTime.Now.Year.ToString());
            Months.Add("July" + "," + DateTime.Now.Year.ToString());
            Months.Add("August" + "," + DateTime.Now.Year.ToString());
            Months.Add("September" + "," + DateTime.Now.Year.ToString());
            Months.Add("October" + "," + DateTime.Now.Year.ToString());
            Months.Add("November" + "," + DateTime.Now.Year.ToString());
            Months.Add("December" + "," + DateTime.Now.Year.ToString());

            cbo_months.DataSource = Months;
        }
    }
}
