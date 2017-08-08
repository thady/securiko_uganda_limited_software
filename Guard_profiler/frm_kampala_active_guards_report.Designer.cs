namespace Guard_profiler
{
    partial class frm_kampala_active_guards_report
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_kampala_active_guards_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_active_kampala_guards_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cr_active_kampala_guards_report);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 599);
            this.panel1.TabIndex = 0;
            // 
            // cr_active_kampala_guards_report
            // 
            this.cr_active_kampala_guards_report.ActiveViewIndex = -1;
            this.cr_active_kampala_guards_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_active_kampala_guards_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_active_kampala_guards_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_active_kampala_guards_report.Location = new System.Drawing.Point(0, 0);
            this.cr_active_kampala_guards_report.Name = "cr_active_kampala_guards_report";
            this.cr_active_kampala_guards_report.Size = new System.Drawing.Size(848, 599);
            this.cr_active_kampala_guards_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 602D;
            this.reSize1.InitialHostContainerWidth = 850D;
            this.reSize1.Tag = null;
            // 
            // frm_kampala_active_guards_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(850, 602);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_kampala_active_guards_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kampala Active Guards Report by Division";
            this.Load += new System.EventHandler(this.frm_kampala_active_guards_report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_active_kampala_guards_report;
    }
}