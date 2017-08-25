namespace Guard_profiler
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.lbl_user_session_name = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name_message = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardProfilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nonGuardProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.activeGuardsByBranchReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.allGuardsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.archievedGuardsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.manageDepartmentsBranchesPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.updatePositionCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_user.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_user);
            this.panel1.Location = new System.Drawing.Point(5, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 682);
            this.panel1.TabIndex = 0;
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.lbl_clock);
            this.panel3.Controls.Add(this.lbl_user_session_name);
            this.panel3.Location = new System.Drawing.Point(1009, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 47);
            this.panel3.TabIndex = 4;
            // 
            // lbl_clock
            // 
            this.lbl_clock.AutoSize = true;
            this.lbl_clock.ForeColor = System.Drawing.Color.White;
            this.lbl_clock.Location = new System.Drawing.Point(9, 28);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(58, 13);
            this.lbl_clock.TabIndex = 1;
            this.lbl_clock.Text = "Waiting.....";
            // 
            // lbl_user_session_name
            // 
            this.lbl_user_session_name.AutoSize = true;
            this.lbl_user_session_name.ForeColor = System.Drawing.Color.White;
            this.lbl_user_session_name.Location = new System.Drawing.Point(9, 9);
            this.lbl_user_session_name.Name = "lbl_user_session_name";
            this.lbl_user_session_name.Size = new System.Drawing.Size(72, 13);
            this.lbl_user_session_name.TabIndex = 0;
            this.lbl_user_session_name.Text = "User Session:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(417, 45);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Advanced Guard Security Management Systems.Designed by Skytel\nsoftware systems.\nF" +
    "or quick help contact : 0705552511/0757596107.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Location = new System.Drawing.Point(1212, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 48);
            this.panel2.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(3, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(140, 41);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LOGOUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.Black;
            this.panel_user.Controls.Add(this.label1);
            this.panel_user.Controls.Add(this.lbl_name_message);
            this.panel_user.Location = new System.Drawing.Point(426, 2);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(266, 45);
            this.panel_user.TabIndex = 1;
            this.panel_user.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are logged in";
            // 
            // lbl_name_message
            // 
            this.lbl_name_message.AutoSize = true;
            this.lbl_name_message.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_message.ForeColor = System.Drawing.Color.White;
            this.lbl_name_message.Location = new System.Drawing.Point(6, 3);
            this.lbl_name_message.Name = "lbl_name_message";
            this.lbl_name_message.Size = new System.Drawing.Size(144, 20);
            this.lbl_name_message.TabIndex = 0;
            this.lbl_name_message.Text = "lbl_name_message";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardProfilesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem1,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 61);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // guardProfilesToolStripMenuItem
            // 
            this.guardProfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardProfilesToolStripMenuItem1,
            this.nonGuardProfilesToolStripMenuItem});
            this.guardProfilesToolStripMenuItem.Name = "guardProfilesToolStripMenuItem";
            this.guardProfilesToolStripMenuItem.Size = new System.Drawing.Size(148, 57);
            this.guardProfilesToolStripMenuItem.Text = "Human Resources";
            this.guardProfilesToolStripMenuItem.Click += new System.EventHandler(this.guardProfilesToolStripMenuItem_Click);
            // 
            // guardProfilesToolStripMenuItem1
            // 
            this.guardProfilesToolStripMenuItem1.Name = "guardProfilesToolStripMenuItem1";
            this.guardProfilesToolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            this.guardProfilesToolStripMenuItem1.Text = "Guard Profiles";
            this.guardProfilesToolStripMenuItem1.Click += new System.EventHandler(this.guardProfilesToolStripMenuItem1_Click);
            // 
            // nonGuardProfilesToolStripMenuItem
            // 
            this.nonGuardProfilesToolStripMenuItem.Name = "nonGuardProfilesToolStripMenuItem";
            this.nonGuardProfilesToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.nonGuardProfilesToolStripMenuItem.Text = "Other Staff Profiles";
            this.nonGuardProfilesToolStripMenuItem.Click += new System.EventHandler(this.nonGuardProfilesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(85, 57);
            this.toolStripMenuItem4.Text = "Accounts";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeGuardsByBranchReportToolStripMenuItem,
            this.toolStripSeparator10,
            this.toolStripMenuItem3,
            this.toolStripSeparator9,
            this.allGuardsReportToolStripMenuItem,
            this.toolStripSeparator8,
            this.archievedGuardsReportsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 57);
            this.toolStripMenuItem1.Text = "General Reports";
            // 
            // activeGuardsByBranchReportToolStripMenuItem
            // 
            this.activeGuardsByBranchReportToolStripMenuItem.Name = "activeGuardsByBranchReportToolStripMenuItem";
            this.activeGuardsByBranchReportToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.activeGuardsByBranchReportToolStripMenuItem.Text = "Active Guards by Branch Reports";
            this.activeGuardsByBranchReportToolStripMenuItem.Click += new System.EventHandler(this.activeGuardsByBranchReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(304, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(307, 26);
            this.toolStripMenuItem3.Text = "Kampala Guards Reports";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(304, 6);
            // 
            // allGuardsReportToolStripMenuItem
            // 
            this.allGuardsReportToolStripMenuItem.Name = "allGuardsReportToolStripMenuItem";
            this.allGuardsReportToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.allGuardsReportToolStripMenuItem.Text = "All Guards Report";
            this.allGuardsReportToolStripMenuItem.Click += new System.EventHandler(this.allGuardsReportToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(304, 6);
            // 
            // archievedGuardsReportsToolStripMenuItem
            // 
            this.archievedGuardsReportsToolStripMenuItem.Name = "archievedGuardsReportsToolStripMenuItem";
            this.archievedGuardsReportsToolStripMenuItem.Size = new System.Drawing.Size(307, 26);
            this.archievedGuardsReportsToolStripMenuItem.Text = "Archieved Guards Reports";
            this.archievedGuardsReportsToolStripMenuItem.Click += new System.EventHandler(this.archievedGuardsReportsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.toolStripSeparator11,
            this.manageDepartmentsBranchesPositionsToolStripMenuItem,
            this.toolStripSeparator12,
            this.updatePositionCodesToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(68, 57);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.manageUsersToolStripMenuItem.Text = "Manage users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(364, 6);
            // 
            // manageDepartmentsBranchesPositionsToolStripMenuItem
            // 
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Name = "manageDepartmentsBranchesPositionsToolStripMenuItem";
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Text = "Manage Departments,Branches & Positions";
            this.manageDepartmentsBranchesPositionsToolStripMenuItem.Click += new System.EventHandler(this.manageDepartmentsBranchesPositionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(364, 6);
            // 
            // updatePositionCodesToolStripMenuItem
            // 
            this.updatePositionCodesToolStripMenuItem.Name = "updatePositionCodesToolStripMenuItem";
            this.updatePositionCodesToolStripMenuItem.Size = new System.Drawing.Size(367, 26);
            this.updatePositionCodesToolStripMenuItem.Text = "Update Position Codes";
            this.updatePositionCodesToolStripMenuItem.Click += new System.EventHandler(this.updatePositionCodesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(69, 57);
            this.toolStripMenuItem2.Text = "Wages";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NEW UGANDA SECURIKO  LTD-HR Management system V.1.1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseHover += new System.EventHandler(this.frmMain_MouseHover);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDepartmentsBranchesPositionsToolStripMenuItem;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label lbl_name_message;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_user_session_name;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem activeGuardsByBranchReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allGuardsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem archievedGuardsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatePositionCodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem guardProfilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nonGuardProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

