namespace Guard_profiler
{
    partial class frm_hr_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_hr_panel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_archived_guards = new System.Windows.Forms.Button();
            this.btn_transfer_guards = new System.Windows.Forms.Button();
            this.btn_emp_records = new System.Windows.Forms.Button();
            this.btn_guard_profiles = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activeGuardsByBranchReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kampalaGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allGuardsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivedGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_non_guard_profiles = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_non_guard_profiles);
            this.panel1.Controls.Add(this.btn_archived_guards);
            this.panel1.Controls.Add(this.btn_transfer_guards);
            this.panel1.Controls.Add(this.btn_emp_records);
            this.panel1.Controls.Add(this.btn_guard_profiles);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 281);
            this.panel1.TabIndex = 0;
            // 
            // btn_archived_guards
            // 
            this.btn_archived_guards.Location = new System.Drawing.Point(10, 188);
            this.btn_archived_guards.Name = "btn_archived_guards";
            this.btn_archived_guards.Size = new System.Drawing.Size(190, 52);
            this.btn_archived_guards.TabIndex = 3;
            this.btn_archived_guards.Text = "View Arhived Guards(Guard History)";
            this.btn_archived_guards.UseVisualStyleBackColor = true;
            this.btn_archived_guards.Click += new System.EventHandler(this.btn_archived_guards_Click);
            // 
            // btn_transfer_guards
            // 
            this.btn_transfer_guards.Location = new System.Drawing.Point(10, 130);
            this.btn_transfer_guards.Name = "btn_transfer_guards";
            this.btn_transfer_guards.Size = new System.Drawing.Size(190, 52);
            this.btn_transfer_guards.TabIndex = 2;
            this.btn_transfer_guards.Text = "Transfer Guards";
            this.btn_transfer_guards.UseVisualStyleBackColor = true;
            this.btn_transfer_guards.Click += new System.EventHandler(this.btn_transfer_guards_Click);
            // 
            // btn_emp_records
            // 
            this.btn_emp_records.Location = new System.Drawing.Point(10, 72);
            this.btn_emp_records.Name = "btn_emp_records";
            this.btn_emp_records.Size = new System.Drawing.Size(190, 52);
            this.btn_emp_records.TabIndex = 1;
            this.btn_emp_records.Text = "Manage Guard Employment Records";
            this.btn_emp_records.UseVisualStyleBackColor = true;
            this.btn_emp_records.Click += new System.EventHandler(this.btn_emp_records_Click);
            // 
            // btn_guard_profiles
            // 
            this.btn_guard_profiles.Location = new System.Drawing.Point(10, 14);
            this.btn_guard_profiles.Name = "btn_guard_profiles";
            this.btn_guard_profiles.Size = new System.Drawing.Size(190, 52);
            this.btn_guard_profiles.TabIndex = 0;
            this.btn_guard_profiles.Text = "Manage Guard Profiles";
            this.btn_guard_profiles.UseVisualStyleBackColor = true;
            this.btn_guard_profiles.Click += new System.EventHandler(this.btn_guard_profiles_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeGuardsByBranchReportsToolStripMenuItem,
            this.kampalaGuardsReportsToolStripMenuItem,
            this.allGuardsReportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.archivedGuardsReportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activeGuardsByBranchReportsToolStripMenuItem
            // 
            this.activeGuardsByBranchReportsToolStripMenuItem.Name = "activeGuardsByBranchReportsToolStripMenuItem";
            this.activeGuardsByBranchReportsToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.activeGuardsByBranchReportsToolStripMenuItem.Text = "Active Guards by branch Reports";
            this.activeGuardsByBranchReportsToolStripMenuItem.Click += new System.EventHandler(this.activeGuardsByBranchReportsToolStripMenuItem_Click);
            // 
            // kampalaGuardsReportsToolStripMenuItem
            // 
            this.kampalaGuardsReportsToolStripMenuItem.Name = "kampalaGuardsReportsToolStripMenuItem";
            this.kampalaGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.kampalaGuardsReportsToolStripMenuItem.Text = "Kampala Guards Reports";
            this.kampalaGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.kampalaGuardsReportsToolStripMenuItem_Click);
            // 
            // allGuardsReportToolStripMenuItem
            // 
            this.allGuardsReportToolStripMenuItem.Name = "allGuardsReportToolStripMenuItem";
            this.allGuardsReportToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.allGuardsReportToolStripMenuItem.Text = "All Guards Report";
            this.allGuardsReportToolStripMenuItem.Click += new System.EventHandler(this.allGuardsReportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // archivedGuardsReportsToolStripMenuItem
            // 
            this.archivedGuardsReportsToolStripMenuItem.Name = "archivedGuardsReportsToolStripMenuItem";
            this.archivedGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.archivedGuardsReportsToolStripMenuItem.Text = "Archived Guards Reports";
            this.archivedGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.archivedGuardsReportsToolStripMenuItem_Click);
            // 
            // btn_non_guard_profiles
            // 
            this.btn_non_guard_profiles.Location = new System.Drawing.Point(206, 14);
            this.btn_non_guard_profiles.Name = "btn_non_guard_profiles";
            this.btn_non_guard_profiles.Size = new System.Drawing.Size(190, 52);
            this.btn_non_guard_profiles.TabIndex = 4;
            this.btn_non_guard_profiles.Text = "Non-Guard Profiles";
            this.btn_non_guard_profiles.UseVisualStyleBackColor = true;
            // 
            // frm_hr_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(621, 309);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_hr_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resource Control Dashboard";
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_guard_profiles;
        private System.Windows.Forms.Button btn_emp_records;
        private System.Windows.Forms.Button btn_transfer_guards;
        private System.Windows.Forms.Button btn_archived_guards;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem activeGuardsByBranchReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kampalaGuardsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allGuardsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem archivedGuardsReportsToolStripMenuItem;
        private System.Windows.Forms.Button btn_non_guard_profiles;
    }
}