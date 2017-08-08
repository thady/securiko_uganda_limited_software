namespace Guard_profiler
{
    partial class frm_sg_list_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sg_list_report));
            this.report_sg_lists = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // report_sg_lists
            // 
            this.report_sg_lists.ActiveViewIndex = -1;
            this.report_sg_lists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report_sg_lists.Cursor = System.Windows.Forms.Cursors.Default;
            this.report_sg_lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report_sg_lists.Location = new System.Drawing.Point(0, 0);
            this.report_sg_lists.Name = "report_sg_lists";
            this.report_sg_lists.Size = new System.Drawing.Size(856, 545);
            this.report_sg_lists.TabIndex = 0;
            // 
            // frm_sg_list_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.report_sg_lists);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_sg_list_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW SECURIKO UGANDA LTD-ALL GUARDS REPORT";
            this.Load += new System.EventHandler(this.frm_sg_list_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer report_sg_lists;
    }
}