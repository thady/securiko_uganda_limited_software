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
using Guard_profiler.App_code;
using CrystalDecisions.Shared;


namespace Guard_profiler
{
    public partial class frmcrystal_report_single : Form
    {
        public frmcrystal_report_single()
        {
            InitializeComponent();
        }

        private void frmcrystal_report_single_Load(object sender, EventArgs e)
        {
            if (SystemConst._Single_report_type == "Active")
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                guard_single_report report = new guard_single_report();

                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                report.SetDatabaseLogon("sg_admin", "sg_admin123"); //hide the password from the code..get it from configuration file...

                report.SetDataSource(sg_Reports.RETURN_OFFICER_DETAILS("", SystemConst.guard_number));
                report.SetParameterValue("QueryName", "SELECT_GUARD_REPORT_SINGLE");
                report.SetParameterValue("guard_number", SystemConst.guard_number);
                report.SetParameterValue("guard_status", String.Empty);
                crystalReportViewer1.ParameterFieldInfo = paramFields;


                this.crystalReportViewer1.ReportSource = report;
                //this.crystalReportViewer1.RefreshReport();
            }
            else if (SystemConst._Single_report_type == "Archieve")
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                guard_single_report report = new guard_single_report();

                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                report.SetDatabaseLogon("sg_admin", "sg_admin123"); //hide the password from the code..get it from configuration file...

                report.SetDataSource(sg_Reports.RETURN_OFFICER_DETAILS("", SystemConst.guard_number));
                report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_REPORT_SINGLE");
                report.SetParameterValue("guard_number", SystemConst.guard_number);
                report.SetParameterValue("guard_status", String.Empty);
                crystalReportViewer1.ParameterFieldInfo = paramFields;


                this.crystalReportViewer1.ReportSource = report;
                //this.crystalReportViewer1.RefreshReport();
            }
           
        }

        protected void SET_CONNECTION_INFO(ConnectionInfo conn_info) {
            TableLogOnInfos my_info = new TableLogOnInfos();
            my_info = crystalReportViewer1.LogOnInfo;
            foreach(TableLogOnInfo myInfo in my_info){
                myInfo.ConnectionInfo = conn_info;
            }
        }
    }
}
