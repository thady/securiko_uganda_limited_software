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
using System.IO;
using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frm_officer_large_img_report : Form
    {
        public frm_officer_large_img_report()
        {
            InitializeComponent();
        }

        private void frm_officer_large_img_report_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            cr_guard_large_img report = new cr_guard_large_img();

            ParameterFields paramFields = new ParameterFields();
            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent in report.Database.Tables)
                Set_Report_logons.SetTableLogin(tbCurrent);

            report.SetDataSource(sg_Reports.SELECT_GUARD_LARGE_IMAGE_RPT("", SystemConst.guard_number));
            report.SetParameterValue("QueryName", "SELECT_GUARD_LARGE_IMAGE_RPT");
            report.SetParameterValue("guard_number", SystemConst.guard_number);
            cr_large_image_report.ParameterFieldInfo = paramFields;


            this.cr_large_image_report.ReportSource = report;
      
        }
    }
}
