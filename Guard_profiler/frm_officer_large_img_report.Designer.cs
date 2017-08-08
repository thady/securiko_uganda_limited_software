namespace Guard_profiler
{
    partial class frm_officer_large_img_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_officer_large_img_report));
            this.cr_large_image_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cr_large_image_report
            // 
            this.cr_large_image_report.ActiveViewIndex = -1;
            this.cr_large_image_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_large_image_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_large_image_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_large_image_report.Location = new System.Drawing.Point(0, 0);
            this.cr_large_image_report.Name = "cr_large_image_report";
            this.cr_large_image_report.Size = new System.Drawing.Size(890, 607);
            this.cr_large_image_report.TabIndex = 0;
            // 
            // frm_officer_large_img_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 607);
            this.Controls.Add(this.cr_large_image_report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_officer_large_img_report";
            this.Text = "New Uganda Security Ltd- Export guard large photo";
            this.Load += new System.EventHandler(this.frm_officer_large_img_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_large_image_report;
    }
}