namespace Guard_profiler
{
    partial class frm_large_image_report
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_large_img_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cr_large_img_report);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 595);
            this.panel1.TabIndex = 0;
            // 
            // cr_large_img_report
            // 
            this.cr_large_img_report.ActiveViewIndex = -1;
            this.cr_large_img_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_large_img_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_large_img_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_large_img_report.Location = new System.Drawing.Point(0, 0);
            this.cr_large_img_report.Name = "cr_large_img_report";
            this.cr_large_img_report.Size = new System.Drawing.Size(841, 595);
            this.cr_large_img_report.TabIndex = 0;
            // 
            // frm_large_image_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 601);
            this.Controls.Add(this.panel1);
            this.Name = "frm_large_image_report";
            this.Text = "frm_large_image_report";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_large_img_report;
    }
}