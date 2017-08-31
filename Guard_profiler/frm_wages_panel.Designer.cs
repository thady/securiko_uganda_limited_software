namespace Guard_profiler
{
    partial class frm_wages_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_wages_panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_lst = new System.Windows.Forms.Button();
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_fire_arm_guard_assign = new System.Windows.Forms.Button();
            this.btn_fire_arms = new System.Windows.Forms.Button();
            this.btn_public_holidays = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_other_data = new System.Windows.Forms.Button();
            this.btn_deploy_guards_batch = new System.Windows.Forms.Button();
            this.btn_deployment_summary = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_lst);
            this.panel1.Controls.Add(this.btn_clients);
            this.panel1.Controls.Add(this.btn_fire_arm_guard_assign);
            this.panel1.Controls.Add(this.btn_fire_arms);
            this.panel1.Controls.Add(this.btn_public_holidays);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.btn_other_data);
            this.panel1.Controls.Add(this.btn_deploy_guards_batch);
            this.panel1.Controls.Add(this.btn_deployment_summary);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 306);
            this.panel1.TabIndex = 1;
            // 
            // btn_lst
            // 
            this.btn_lst.Location = new System.Drawing.Point(162, 153);
            this.btn_lst.Name = "btn_lst";
            this.btn_lst.Size = new System.Drawing.Size(146, 45);
            this.btn_lst.TabIndex = 10;
            this.btn_lst.Text = "Manage guard Local Service Tax payments";
            this.btn_lst.UseVisualStyleBackColor = true;
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(162, 102);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(146, 45);
            this.btn_clients.TabIndex = 9;
            this.btn_clients.Text = "Manage Client(Customer) data";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_fire_arm_guard_assign
            // 
            this.btn_fire_arm_guard_assign.Location = new System.Drawing.Point(162, 51);
            this.btn_fire_arm_guard_assign.Name = "btn_fire_arm_guard_assign";
            this.btn_fire_arm_guard_assign.Size = new System.Drawing.Size(146, 45);
            this.btn_fire_arm_guard_assign.TabIndex = 8;
            this.btn_fire_arm_guard_assign.Text = "Assign fire arm to guards";
            this.btn_fire_arm_guard_assign.UseVisualStyleBackColor = true;
            // 
            // btn_fire_arms
            // 
            this.btn_fire_arms.Location = new System.Drawing.Point(162, 3);
            this.btn_fire_arms.Name = "btn_fire_arms";
            this.btn_fire_arms.Size = new System.Drawing.Size(146, 45);
            this.btn_fire_arms.TabIndex = 7;
            this.btn_fire_arms.Text = "Manage fire arms";
            this.btn_fire_arms.UseVisualStyleBackColor = true;
            // 
            // btn_public_holidays
            // 
            this.btn_public_holidays.Location = new System.Drawing.Point(3, 153);
            this.btn_public_holidays.Name = "btn_public_holidays";
            this.btn_public_holidays.Size = new System.Drawing.Size(146, 45);
            this.btn_public_holidays.TabIndex = 6;
            this.btn_public_holidays.Text = "Manage Public Hoildays";
            this.btn_public_holidays.UseVisualStyleBackColor = true;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(156, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(156, 306);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // btn_other_data
            // 
            this.btn_other_data.Location = new System.Drawing.Point(3, 102);
            this.btn_other_data.Name = "btn_other_data";
            this.btn_other_data.Size = new System.Drawing.Size(146, 45);
            this.btn_other_data.TabIndex = 3;
            this.btn_other_data.Text = "Guard additional monthly data";
            this.btn_other_data.UseVisualStyleBackColor = true;
            // 
            // btn_deploy_guards_batch
            // 
            this.btn_deploy_guards_batch.Location = new System.Drawing.Point(3, 51);
            this.btn_deploy_guards_batch.Name = "btn_deploy_guards_batch";
            this.btn_deploy_guards_batch.Size = new System.Drawing.Size(146, 45);
            this.btn_deploy_guards_batch.TabIndex = 2;
            this.btn_deploy_guards_batch.Text = "Deploy Guards(Batch)";
            this.btn_deploy_guards_batch.UseVisualStyleBackColor = true;
            this.btn_deploy_guards_batch.Click += new System.EventHandler(this.btn_deploy_guards_batch_Click);
            // 
            // btn_deployment_summary
            // 
            this.btn_deployment_summary.Location = new System.Drawing.Point(3, 3);
            this.btn_deployment_summary.Name = "btn_deployment_summary";
            this.btn_deployment_summary.Size = new System.Drawing.Size(146, 45);
            this.btn_deployment_summary.TabIndex = 1;
            this.btn_deployment_summary.Text = "Deploy Guards(Single)";
            this.btn_deployment_summary.UseVisualStyleBackColor = true;
            this.btn_deployment_summary.Click += new System.EventHandler(this.btn_deployment_summary_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.PowderBlue;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(156, 306);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wage Management";
            // 
            // frm_wages_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(565, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_wages_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Securiko Uganda Ltd-Wage Managemet";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btn_deployment_summary;
        private System.Windows.Forms.Button btn_deploy_guards_batch;
        private System.Windows.Forms.Button btn_other_data;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btn_public_holidays;
        private System.Windows.Forms.Button btn_fire_arms;
        private System.Windows.Forms.Button btn_fire_arm_guard_assign;
        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lst;
    }
}