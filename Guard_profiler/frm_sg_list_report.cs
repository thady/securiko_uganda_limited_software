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
    public partial class frm_sg_list_report : Form
    {
        public frm_sg_list_report()
        {
            InitializeComponent();
        }

        private void frm_sg_list_report_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            cr_all_guards_list report = new cr_all_guards_list();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            report.SetDatabaseLogon("", "sg_admin123"); //hide the password from the code..get it from configuration file...
            report.SetDataSource(sg_Reports.SELECT_GUARD_LIST("SELECT_GUARD_LIST"));
            report.SetParameterValue("QueryName", "SELECT_GUARD_LIST");
            report_sg_lists.ParameterFieldInfo = paramFields;


            this.report_sg_lists.ReportSource = report;
        }
    }
}
