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
using CrystalDecisions.Shared;

namespace Guard_profiler
{
    public partial class frm_archieved_guard_list_report : Form
    {
        public frm_archieved_guard_list_report()
        {
            InitializeComponent();
        }

        private void frm_archieved_guard_list_report_Load(object sender, EventArgs e)
        {
            string _guard_status = SystemConst._guard_status;

            if (_guard_status != String.Empty)
            {
                try {
                    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                    cr_archived_guard_lists report = new cr_archived_guard_lists();

                    ParameterFields paramFields = new ParameterFields();
                    ParameterField paramField = new ParameterField();
                    ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                        Set_Report_logons.SetTableLogin(tbCurrent);

                    report.SetDataSource(Archieve_Lists.SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS("SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS", _guard_status));
                    report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_LIST_REPORT_BY_STATUS");
                    report.SetParameterValue("guard_status", SystemConst._guard_status);
                    cr_viewer_archieved_guards_report.ParameterFieldInfo = paramFields;


                    this.cr_viewer_archieved_guards_report.ReportSource = report;
                    //this.crystalReportViewer1.RefreshReport();
                }
                catch (Exception ex) {
                    throw ex;
                }
               
            }
            else {

                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

                cr_archived_guard_lists report = new cr_archived_guard_lists();

                ParameterFields paramFields = new ParameterFields();
                ParameterField paramField = new ParameterField();
                ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

                report.SetDatabaseLogon("sg_admin", "sg_admin123"); //hide the password from the code..get it from configuration file...

                report.SetDataSource(Archieve_Lists.SELECT_ARCHIEVED_GUARD_LIST_ALL("SELECT_ARCHIEVED_GUARD_LIST_ALL"));
                report.SetParameterValue("QueryName", "SELECT_ARCHIEVED_GUARD_LIST_ALL");
               // report.SetParameterValue("guard_status", SystemConst._guard_status);
                cr_viewer_archieved_guards_report.ParameterFieldInfo = paramFields;


                this.cr_viewer_archieved_guards_report.ReportSource = report;
                //this.crystalReportViewer1.RefreshReport();
            }
        }
    }
}
