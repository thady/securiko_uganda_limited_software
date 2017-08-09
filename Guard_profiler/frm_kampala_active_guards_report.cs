using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using CrystalDecisions.Shared;
using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frm_kampala_active_guards_report : Form
    {
        //set connection string 
        static string SQLConnection = System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString();
        SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(SQLConnection);

        public frm_kampala_active_guards_report()
        {
            InitializeComponent();
        }

        private void frm_kampala_active_guards_report_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            cr_kampala_report report = new cr_kampala_report();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                Set_Report_logons.SetTableLogin(tbCurrent);

            report.SetDataSource(sg_Reports.SELECT_ACTIVE_GUARDS_KAMPALA("", SystemConst._branch));
            //check if user selected kampala
            if (SystemConst._branch == "KAMPALA")
            {
                report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_KAMPALA_COMBINED");
                report.SetParameterValue("branch", SystemConst._branch);
                report.SetParameterValue("update_month", SystemConst._Report_update_month);
                cr_active_kampala_guards_report.ParameterFieldInfo = paramFields;


                this.cr_active_kampala_guards_report.ReportSource = report;
            }
            else
            {
                report.SetParameterValue("QueryName", "SELECT_ACTIVE_GUARDS_KAMPALA");
                report.SetParameterValue("branch", SystemConst._branch);
                report.SetParameterValue("update_month", SystemConst._Report_update_month);
                cr_active_kampala_guards_report.ParameterFieldInfo = paramFields;


                this.cr_active_kampala_guards_report.ReportSource = report;
              
            }
            
        }
    }
}
