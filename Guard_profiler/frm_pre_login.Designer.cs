namespace Guard_profiler
{
    partial class frm_pre_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pre_login));
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_guard_number = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_update_guard_number = new System.Windows.Forms.Button();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_guard_number_complete = new System.Windows.Forms.TextBox();
            this.txt_guard_number_static_code = new System.Windows.Forms.TextBox();
            this.txt_guard_number_auto_code = new System.Windows.Forms.TextBox();
            this.txt_guard_number_current = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_guid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_guard_number.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(101, 45);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(177, 26);
            this.txtpass.TabIndex = 9;
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteCustomSource.AddRange(new string[] {
            "thadeous",
            "tash",
            "lourence"});
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(101, 3);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(177, 26);
            this.txtuser.TabIndex = 8;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 48);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 20);
            this.Label3.TabIndex = 7;
            this.Label3.Text = "Passcode";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 6;
            this.Label2.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(197, 77);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(81, 31);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Confirm";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(114, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login to Change Guard Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.Label3);
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Location = new System.Drawing.Point(2, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 114);
            this.panel1.TabIndex = 12;
            // 
            // panel_guard_number
            // 
            this.panel_guard_number.Controls.Add(this.groupBox1);
            this.panel_guard_number.Controls.Add(this.txt_guard_number_current);
            this.panel_guard_number.Controls.Add(this.label5);
            this.panel_guard_number.Controls.Add(this.cbo_branch);
            this.panel_guard_number.Controls.Add(this.label4);
            this.panel_guard_number.Location = new System.Drawing.Point(2, 162);
            this.panel_guard_number.Name = "panel_guard_number";
            this.panel_guard_number.Size = new System.Drawing.Size(571, 192);
            this.panel_guard_number.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_update_guard_number);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.txt_guard_number_complete);
            this.groupBox1.Controls.Add(this.txt_guard_number_static_code);
            this.groupBox1.Controls.Add(this.txt_guard_number_auto_code);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 115);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Guard Number Details";
            // 
            // btn_update_guard_number
            // 
            this.btn_update_guard_number.ForeColor = System.Drawing.Color.Red;
            this.btn_update_guard_number.Location = new System.Drawing.Point(212, 80);
            this.btn_update_guard_number.Name = "btn_update_guard_number";
            this.btn_update_guard_number.Size = new System.Drawing.Size(140, 29);
            this.btn_update_guard_number.TabIndex = 73;
            this.btn_update_guard_number.Text = "Update Guard Number";
            this.btn_update_guard_number.UseVisualStyleBackColor = true;
            this.btn_update_guard_number.Click += new System.EventHandler(this.btn_update_guard_number_Click);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Yellow;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(86, 29);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(65, 16);
            this.label49.TabIndex = 72;
            this.label49.Text = "Assigned";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Yellow;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(195, 29);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(123, 16);
            this.label48.TabIndex = 71;
            this.label48.Text = "New Guard number";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Yellow;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(12, 27);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 16);
            this.label47.TabIndex = 70;
            this.label47.Text = "Auto";
            // 
            // txt_guard_number_complete
            // 
            this.txt_guard_number_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_complete.Location = new System.Drawing.Point(195, 45);
            this.txt_guard_number_complete.Name = "txt_guard_number_complete";
            this.txt_guard_number_complete.ReadOnly = true;
            this.txt_guard_number_complete.Size = new System.Drawing.Size(157, 29);
            this.txt_guard_number_complete.TabIndex = 69;
            // 
            // txt_guard_number_static_code
            // 
            this.txt_guard_number_static_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_static_code.Location = new System.Drawing.Point(89, 45);
            this.txt_guard_number_static_code.Name = "txt_guard_number_static_code";
            this.txt_guard_number_static_code.Size = new System.Drawing.Size(100, 29);
            this.txt_guard_number_static_code.TabIndex = 68;
            this.txt_guard_number_static_code.TextChanged += new System.EventHandler(this.txt_guard_number_static_code_TextChanged);
            // 
            // txt_guard_number_auto_code
            // 
            this.txt_guard_number_auto_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_auto_code.Location = new System.Drawing.Point(15, 45);
            this.txt_guard_number_auto_code.Name = "txt_guard_number_auto_code";
            this.txt_guard_number_auto_code.ReadOnly = true;
            this.txt_guard_number_auto_code.Size = new System.Drawing.Size(71, 29);
            this.txt_guard_number_auto_code.TabIndex = 67;
            // 
            // txt_guard_number_current
            // 
            this.txt_guard_number_current.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_current.Location = new System.Drawing.Point(249, 33);
            this.txt_guard_number_current.Name = "txt_guard_number_current";
            this.txt_guard_number_current.ReadOnly = true;
            this.txt_guard_number_current.Size = new System.Drawing.Size(177, 26);
            this.txt_guard_number_current.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(246, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current Guard Number";
            // 
            // cbo_branch
            // 
            this.cbo_branch.Enabled = false;
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Items.AddRange(new object[] {
            "",
            "Kampala",
            "Mbale",
            "Entebbe",
            "Lira",
            "Hoima"});
            this.cbo_branch.Location = new System.Drawing.Point(13, 33);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(227, 26);
            this.cbo_branch.TabIndex = 9;
            this.cbo_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_branch_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Branch";
            // 
            // lbl_guid
            // 
            this.lbl_guid.AutoSize = true;
            this.lbl_guid.BackColor = System.Drawing.Color.Yellow;
            this.lbl_guid.Location = new System.Drawing.Point(264, 367);
            this.lbl_guid.Name = "lbl_guid";
            this.lbl_guid.Size = new System.Drawing.Size(43, 13);
            this.lbl_guid.TabIndex = 14;
            this.lbl_guid.Text = "lbl_guid";
            // 
            // frm_pre_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 380);
            this.Controls.Add(this.lbl_guid);
            this.Controls.Add(this.panel_guard_number);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_pre_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Guard Number";
            this.Load += new System.EventHandler(this.frm_pre_login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_guard_number.ResumeLayout(false);
            this.panel_guard_number.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_guard_number;
        private System.Windows.Forms.ComboBox cbo_branch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txt_guard_number_current;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txt_guard_number_complete;
        private System.Windows.Forms.TextBox txt_guard_number_static_code;
        private System.Windows.Forms.TextBox txt_guard_number_auto_code;
        private System.Windows.Forms.Button btn_update_guard_number;
        private System.Windows.Forms.Label lbl_guid;
    }
}