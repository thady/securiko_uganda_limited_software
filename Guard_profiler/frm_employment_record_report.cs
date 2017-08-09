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
    public partial class frm_employment_record_report : Form
    {
        public frm_employment_record_report()
        {
            InitializeComponent();
        }

        private void frm_employment_record_report_Load(object sender, EventArgs e)
        {
            Load_Report();
        }

        protected void Load_Report()
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            guard_employment_record_report report = new guard_employment_record_report();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //set report connection details
            //ConnectionInfo myconnectioninfo = new ConnectionInfo();
            //myconnectioninfo.ServerName = "Thadeous";
            //myconnectioninfo.DatabaseName = "guard_profiles_db";
            //myconnectioninfo.UserID = "sg_admin";
            //myconnectioninfo.Password = "sg_admin123";
            //SET_CONNECTION_INFO(myconnectioninfo);

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                Set_Report_logons.SetTableLogin(tbCurrent);

            //report.SetDataSource(sg_Reports.RETURN_OFFICER_DETAILS("", SystemConst.guard_number));
            report.SetParameterValue("QueryName", "SELECT_GUARD_EMPLOYMENT_RECORD_REPORT");
            report.SetParameterValue("guard_number", SystemConst.guard_number);
            employment_report_reportviewer.ParameterFieldInfo = paramFields;


            this.employment_report_reportviewer.ReportSource = report;
            //this.crystalReportViewer1.RefreshReport();
        }
    }
}
