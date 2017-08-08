namespace Guard_profiler
{
    partial class frm_guards_salary_scale_mapping_dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gdv_guard_salaries = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdv_guard_salaries);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 497);
            this.panel1.TabIndex = 0;
            // 
            // gdv_guard_salaries
            // 
            this.gdv_guard_salaries.AllowUserToAddRows = false;
            this.gdv_guard_salaries.AllowUserToDeleteRows = false;
            this.gdv_guard_salaries.AllowUserToResizeColumns = false;
            this.gdv_guard_salaries.AllowUserToResizeRows = false;
            this.gdv_guard_salaries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guard_salaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guard_salaries.Location = new System.Drawing.Point(9, 21);
            this.gdv_guard_salaries.Name = "gdv_guard_salaries";
            this.gdv_guard_salaries.Size = new System.Drawing.Size(648, 473);
            this.gdv_guard_salaries.TabIndex = 0;
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 521D;
            this.reSize1.InitialHostContainerWidth = 667D;
            this.reSize1.Tag = null;
            // 
            // frm_guards_salary_scale_mapping_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 521);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_guards_salary_scale_mapping_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guards Salaries";
            this.Load += new System.EventHandler(this.frm_guards_salary_scale_mapping_dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guard_salaries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gdv_guard_salaries;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
    }
}