namespace Guard_profiler
{
    partial class frm_users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_users));
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_users = new System.Windows.Forms.DataGridView();
            this.cbo_gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_active = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chk_admin = new System.Windows.Forms.CheckBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.txt_user_id = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_users)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 509D;
            this.reSize1.InitialHostContainerWidth = 878D;
            this.reSize1.Tag = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.gdv_users);
            this.panel2.Location = new System.Drawing.Point(392, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 414);
            this.panel2.TabIndex = 0;
            // 
            // gdv_users
            // 
            this.gdv_users.AllowUserToAddRows = false;
            this.gdv_users.AllowUserToDeleteRows = false;
            this.gdv_users.AllowUserToResizeColumns = false;
            this.gdv_users.AllowUserToResizeRows = false;
            this.gdv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_users.Location = new System.Drawing.Point(3, 3);
            this.gdv_users.Name = "gdv_users";
            this.gdv_users.ReadOnly = true;
            this.gdv_users.Size = new System.Drawing.Size(459, 404);
            this.gdv_users.TabIndex = 2;
            this.gdv_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_users_CellClick);
            // 
            // cbo_gender
            // 
            this.cbo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_gender.FormattingEnabled = true;
            this.cbo_gender.Items.AddRange(new object[] {
            "",
            "Male",
            "Female"});
            this.cbo_gender.Location = new System.Drawing.Point(6, 67);
            this.cbo_gender.Name = "cbo_gender";
            this.cbo_gender.Size = new System.Drawing.Size(180, 26);
            this.cbo_gender.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Gender";
            // 
            // chk_active
            // 
            this.chk_active.AutoSize = true;
            this.chk_active.Checked = true;
            this.chk_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_active.Location = new System.Drawing.Point(6, 260);
            this.chk_active.Name = "chk_active";
            this.chk_active.Size = new System.Drawing.Size(163, 20);
            this.chk_active.TabIndex = 30;
            this.chk_active.Text = " User Account is Active";
            this.chk_active.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbo_gender);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.chk_active);
            this.panel3.Controls.Add(this.chk_admin);
            this.panel3.Controls.Add(this.txt_password2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(7, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 355);
            this.panel3.TabIndex = 1;
            // 
            // chk_admin
            // 
            this.chk_admin.AutoSize = true;
            this.chk_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_admin.Location = new System.Drawing.Point(6, 234);
            this.chk_admin.Name = "chk_admin";
            this.chk_admin.Size = new System.Drawing.Size(196, 20);
            this.chk_admin.TabIndex = 29;
            this.chk_admin.Text = "User is system Administrator";
            this.chk_admin.UseVisualStyleBackColor = true;
            // 
            // txt_password2
            // 
            this.txt_password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password2.Location = new System.Drawing.Point(6, 204);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.PasswordChar = '*';
            this.txt_password2.Size = new System.Drawing.Size(334, 24);
            this.txt_password2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Re-type password";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(6, 158);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(334, 24);
            this.txt_password.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(6, 112);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(334, 24);
            this.txt_username.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(6, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(334, 24);
            this.txt_name.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(88, 37);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New User";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(92, 3);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(88, 37);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel10.Controls.Add(this.btnNew);
            this.panel10.Controls.Add(this.btnedit);
            this.panel10.Controls.Add(this.btnsave);
            this.panel10.Location = new System.Drawing.Point(66, 434);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(320, 43);
            this.panel10.TabIndex = 31;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(180, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(131, 37);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save User Details";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txt_user_id
            // 
            this.txt_user_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_id.Location = new System.Drawing.Point(3, 3);
            this.txt_user_id.Name = "txt_user_id";
            this.txt_user_id.Size = new System.Drawing.Size(214, 52);
            this.txt_user_id.TabIndex = 0;
            this.txt_user_id.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_user_id);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(7, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(379, 64);
            this.panel4.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 494);
            this.panel1.TabIndex = 1;
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE USERS";
            this.Load += new System.EventHandler(this.frm_users_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_users)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox txt_user_id;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbo_gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_active;
        private System.Windows.Forms.CheckBox chk_admin;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gdv_users;

    }
}