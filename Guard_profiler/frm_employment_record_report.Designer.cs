namespace Guard_profiler
{
    partial class frm_employment_record_report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_employment_record_report));
            this.employment_report_reportviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // employment_report_reportviewer
            // 
            this.employment_report_reportviewer.ActiveViewIndex = -1;
            this.employment_report_reportviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employment_report_reportviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.employment_report_reportviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employment_report_reportviewer.Location = new System.Drawing.Point(0, 0);
            this.employment_report_reportviewer.Name = "employment_report_reportviewer";
            this.employment_report_reportviewer.Size = new System.Drawing.Size(857, 565);
            this.employment_report_reportviewer.TabIndex = 0;
            // 
            // frm_employment_record_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 565);
            this.Controls.Add(this.employment_report_reportviewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_employment_record_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUARD EMPLOYMENT RECORD REPORT";
            this.Load += new System.EventHandler(this.frm_employment_record_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer employment_report_reportviewer;
    }
}