namespace Guard_profiler
{
    partial class frm_guard_lists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_guard_lists));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_months = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbo_months);
            this.panel1.Controls.Add(this.btn_report);
            this.panel1.Controls.Add(this.cbo_branch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 328);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_report.Location = new System.Drawing.Point(228, 135);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(202, 44);
            this.btn_report.TabIndex = 2;
            this.btn_report.Text = "GENERATE LIST";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // cbo_branch
            // 
            this.cbo_branch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbo_branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Location = new System.Drawing.Point(120, 38);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(310, 33);
            this.cbo_branch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(119, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT THE BRANCH TO GENERATE LIST";
            // 
            // cbo_months
            // 
            this.cbo_months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_months.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_months.FormattingEnabled = true;
            this.cbo_months.Location = new System.Drawing.Point(120, 96);
            this.cbo_months.Name = "cbo_months";
            this.cbo_months.Size = new System.Drawing.Size(310, 33);
            this.cbo_months.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(119, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SELECT MONTH";
            // 
            // frm_guard_lists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(529, 333);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_guard_lists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Activate Guards by Branch";
            this.Load += new System.EventHandler(this.frm_guard_lists_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbo_branch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_months;
    }
}