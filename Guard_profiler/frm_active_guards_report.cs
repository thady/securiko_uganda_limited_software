using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frm_active_guards_report : Form
    {
        public frm_active_guards_report()
        {
            InitializeComponent();
        }

        private void frm_active_guards_report_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            cr_active_guards_by_station report = new cr_active_guards_by_station();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();


            report.SetDatabaseLogon("sg_admin", "sg_admin123"); //hide the password from the code..get it from configuration file...

            report.SetDataSource(sg_Reports.SELECT_ACTIVE_GUARDS_BY_STATION("",SystemConst._branch));
            report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_BY_STATION");
            report.SetParameterValue("branch", SystemConst._branch);
            report.SetParameterValue("update_month", SystemConst._Report_update_month);
            cr_active_guards.ParameterFieldInfo = paramFields;


            this.cr_active_guards.ReportSource = report;
            //this.crystalReportViewer1.RefreshReport();
        }
    }
}
