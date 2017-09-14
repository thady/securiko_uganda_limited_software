namespace Guard_profiler
{
    partial class frm_deployment_periods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_deployment_periods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdv_deployment_periods = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_guid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_periods)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.gdv_deployment_periods);
            this.panel1.Location = new System.Drawing.Point(2, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 362);
            this.panel1.TabIndex = 0;
            // 
            // gdv_deployment_periods
            // 
            this.gdv_deployment_periods.AllowUserToAddRows = false;
            this.gdv_deployment_periods.AllowUserToDeleteRows = false;
            this.gdv_deployment_periods.AllowUserToResizeColumns = false;
            this.gdv_deployment_periods.AllowUserToResizeRows = false;
            this.gdv_deployment_periods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_deployment_periods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_deployment_periods.Location = new System.Drawing.Point(0, 3);
            this.gdv_deployment_periods.Name = "gdv_deployment_periods";
            this.gdv_deployment_periods.ReadOnly = true;
            this.gdv_deployment_periods.Size = new System.Drawing.Size(599, 368);
            this.gdv_deployment_periods.TabIndex = 0;
            this.gdv_deployment_periods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_deployment_periods_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.chk_active);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dt_end_date);
            this.panel2.Controls.Add(this.dt_start_date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 84);
            this.panel2.TabIndex = 1;
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.BackColor = System.Drawing.Color.Yellow;
            this.chk_active.Location = new System.Drawing.Point(270, 24);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(145, 17);
            this.chk_active.TabIndex = 7;
            this.chk_active.Text = "Active deployment period";
            this.chk_active.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deployment end date";
            // 
            // dt_end_date
            // 
            this.dt_end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_end_date.Location = new System.Drawing.Point(13, 58);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.ShowCheckBox = true;
            this.dt_end_date.Size = new System.Drawing.Size(225, 21);
            this.dt_end_date.TabIndex = 5;
            // 
            // dt_start_date
            // 
            this.dt_start_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_start_date.Location = new System.Drawing.Point(13, 20);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.ShowCheckBox = true;
            this.dt_start_date.Size = new System.Drawing.Size(227, 21);
            this.dt_start_date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deployment start date";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.btn_new);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Location = new System.Drawing.Point(421, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 77);
            this.panel3.TabIndex = 8;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(3, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(170, 34);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "SAVE DEPLOYMENT PERIOD";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(3, 38);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(170, 34);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "NEW DEPLOYMENT PERIOD";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbl_guid);
            this.panel4.Location = new System.Drawing.Point(2, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 27);
            this.panel4.TabIndex = 1;
            // 
            // lbl_guid
            // 
            this.lbl_guid.AutoSize = true;
            this.lbl_guid.ForeColor = System.Drawing.Color.Blue;
            this.lbl_guid.Location = new System.Drawing.Point(245, 7);
            this.lbl_guid.Name = "lbl_guid";
            this.lbl_guid.Size = new System.Drawing.Size(43, 13);
            this.lbl_guid.TabIndex = 0;
            this.lbl_guid.Text = "lbl_guid";
            // 
            // frm_deployment_periods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(608, 483);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_deployment_periods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage deployment periods";
            this.Load += new System.EventHandler(this.frm_deployment_periods_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_deployment_periods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdv_deployment_periods;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_end_date;
        private System.Windows.Forms.DateTimePicker dt_start_date;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_guid;
    }
}