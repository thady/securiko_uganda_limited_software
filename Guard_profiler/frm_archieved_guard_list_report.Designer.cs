﻿namespace Guard_profiler
{
    partial class frm_archieved_guard_list_report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_archieved_guard_list_report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cr_viewer_archieved_guards_report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cr_viewer_archieved_guards_report);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 587);
            this.panel1.TabIndex = 0;
            // 
            // cr_viewer_archieved_guards_report
            // 
            this.cr_viewer_archieved_guards_report.ActiveViewIndex = -1;
            this.cr_viewer_archieved_guards_report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_viewer_archieved_guards_report.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_viewer_archieved_guards_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_viewer_archieved_guards_report.Location = new System.Drawing.Point(0, 0);
            this.cr_viewer_archieved_guards_report.Name = "cr_viewer_archieved_guards_report";
            this.cr_viewer_archieved_guards_report.Size = new System.Drawing.Size(852, 587);
            this.cr_viewer_archieved_guards_report.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 589D;
            this.reSize1.InitialHostContainerWidth = 856D;
            this.reSize1.Tag = null;
            // 
            // frm_archieved_guard_list_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(856, 589);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_archieved_guard_list_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archieved Guards Reports";
            this.Load += new System.EventHandler(this.frm_archieved_guard_list_report_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_viewer_archieved_guards_report;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}