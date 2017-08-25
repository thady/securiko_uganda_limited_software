namespace Guard_profiler
{
    partial class frm_accounts_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_accounts_panel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_manage_scales = new System.Windows.Forms.Button();
            this.btn_assign_scales = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_payroll_setup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_banks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_banks);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_payroll_setup);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_assign_scales);
            this.panel1.Controls.Add(this.btn_manage_scales);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 294);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Accounts Management";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(145, 294);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary Scales";
            // 
            // btn_manage_scales
            // 
            this.btn_manage_scales.Location = new System.Drawing.Point(3, 22);
            this.btn_manage_scales.Name = "btn_manage_scales";
            this.btn_manage_scales.Size = new System.Drawing.Size(133, 41);
            this.btn_manage_scales.TabIndex = 2;
            this.btn_manage_scales.Text = "Manage Salary scales";
            this.btn_manage_scales.UseVisualStyleBackColor = true;
            this.btn_manage_scales.Click += new System.EventHandler(this.btn_manage_scales_Click);
            // 
            // btn_assign_scales
            // 
            this.btn_assign_scales.Location = new System.Drawing.Point(3, 69);
            this.btn_assign_scales.Name = "btn_assign_scales";
            this.btn_assign_scales.Size = new System.Drawing.Size(133, 41);
            this.btn_assign_scales.TabIndex = 3;
            this.btn_assign_scales.Text = "Assign scales to guards(Batch)";
            this.btn_assign_scales.UseVisualStyleBackColor = true;
            this.btn_assign_scales.Click += new System.EventHandler(this.btn_assign_scales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Auto Assigned scales  to guards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Gainsboro;
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Location = new System.Drawing.Point(145, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(164, 294);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pay-Roll Management";
            // 
            // btn_payroll_setup
            // 
            this.btn_payroll_setup.Location = new System.Drawing.Point(151, 22);
            this.btn_payroll_setup.Name = "btn_payroll_setup";
            this.btn_payroll_setup.Size = new System.Drawing.Size(149, 41);
            this.btn_payroll_setup.TabIndex = 7;
            this.btn_payroll_setup.Text = "Set up payroll";
            this.btn_payroll_setup.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Finance Reports";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "Guard salary advances";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_banks
            // 
            this.btn_banks.Location = new System.Drawing.Point(151, 116);
            this.btn_banks.Name = "btn_banks";
            this.btn_banks.Size = new System.Drawing.Size(149, 41);
            this.btn_banks.TabIndex = 10;
            this.btn_banks.Text = "Update Guard Bank and Nssf Details";
            this.btn_banks.UseVisualStyleBackColor = true;
            // 
            // frm_accounts_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(610, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_accounts_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts Management Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_manage_scales;
        private System.Windows.Forms.Button btn_assign_scales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_payroll_setup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_banks;
    }
}