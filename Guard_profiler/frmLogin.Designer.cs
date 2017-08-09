namespace Guard_profiler
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox12 = new System.Windows.Forms.GroupBox();
            this.lognpxt = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lognpxt)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.GroupBox1.Controls.Add(this.GroupBox12);
            this.GroupBox1.Controls.Add(this.txtpass);
            this.GroupBox1.Controls.Add(this.txtuser);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(4, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(486, 175);
            this.GroupBox1.TabIndex = 4;
            this.GroupBox1.TabStop = false;
            // 
            // GroupBox12
            // 
            this.GroupBox12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.GroupBox12.Controls.Add(this.lognpxt);
            this.GroupBox12.Location = new System.Drawing.Point(6, 19);
            this.GroupBox12.Name = "GroupBox12";
            this.GroupBox12.Size = new System.Drawing.Size(142, 128);
            this.GroupBox12.TabIndex = 40;
            this.GroupBox12.TabStop = false;
            // 
            // lognpxt
            // 
            this.lognpxt.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lognpxt.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lognpxt.Image = global::Guard_profiler.Properties.Resources.loginimg1;
            this.lognpxt.Location = new System.Drawing.Point(6, 19);
            this.lognpxt.Name = "lognpxt";
            this.lognpxt.Size = new System.Drawing.Size(130, 103);
            this.lognpxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lognpxt.TabIndex = 0;
            this.lognpxt.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(158, 113);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(261, 26);
            this.txtpass.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.AutoCompleteCustomSource.AddRange(new string[] {
            "thadeous",
            "tash",
            "lourence"});
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(158, 61);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(261, 26);
            this.txtuser.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(154, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 20);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Passcode";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(154, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(83, 20);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Username";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GroupBox2.Controls.Add(this.btnClose);
            this.GroupBox2.Controls.Add(this.btnLogin);
            this.GroupBox2.Location = new System.Drawing.Point(0, 186);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(495, 54);
            this.GroupBox2.TabIndex = 5;
            this.GroupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Blue;
            this.btnClose.Location = new System.Drawing.Point(184, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(288, 13);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(174, 38);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(494, 251);
            this.ControlBox = false;
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lognpxt)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox12;
        internal System.Windows.Forms.PictureBox lognpxt;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.TextBox txtuser;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.Button btnClose;
    }
}