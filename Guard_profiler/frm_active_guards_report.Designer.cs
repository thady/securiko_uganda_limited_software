namespace Guard_profiler
{
    partial class frm_active_guards_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_active_guards_report));
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.cr_active_guards = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 528D;
            this.reSize1.InitialHostContainerWidth = 847D;
            this.reSize1.Tag = null;
            // 
            // cr_active_guards
            // 
            this.cr_active_guards.ActiveViewIndex = -1;
            this.cr_active_guards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_active_guards.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_active_guards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_active_guards.Location = new System.Drawing.Point(0, 0);
            this.cr_active_guards.Name = "cr_active_guards";
            this.cr_active_guards.Size = new System.Drawing.Size(847, 528);
            this.cr_active_guards.TabIndex = 0;
            // 
            // frm_active_guards_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 528);
            this.Controls.Add(this.cr_active_guards);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_active_guards_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Guards by Branch Report";
            this.Load += new System.EventHandler(this.frm_active_guards_report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_active_guards;
    }
}