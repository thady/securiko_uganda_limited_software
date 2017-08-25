namespace Guard_profiler
{
    partial class frm_manage_clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manage_clients));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_clients = new System.Windows.Forms.DataGridView();
            this.panel_details = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_client_code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_client_rate = new System.Windows.Forms.TextBox();
            this.chk_client_active = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txt_record_guid = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_locations = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_clients)).BeginInit();
            this.panel_details.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txt_record_guid);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel_details);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 520);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.gdv_clients);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 384);
            this.panel2.TabIndex = 0;
            // 
            // gdv_clients
            // 
            this.gdv_clients.AllowUserToAddRows = false;
            this.gdv_clients.AllowUserToDeleteRows = false;
            this.gdv_clients.AllowUserToResizeColumns = false;
            this.gdv_clients.AllowUserToResizeRows = false;
            this.gdv_clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_clients.Location = new System.Drawing.Point(3, 3);
            this.gdv_clients.Name = "gdv_clients";
            this.gdv_clients.ReadOnly = true;
            this.gdv_clients.Size = new System.Drawing.Size(825, 378);
            this.gdv_clients.TabIndex = 0;
            this.gdv_clients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_clients_CellClick);
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.Silver;
            this.panel_details.Controls.Add(this.txt_client_id);
            this.panel_details.Controls.Add(this.label7);
            this.panel_details.Controls.Add(this.chk_client_active);
            this.panel_details.Controls.Add(this.txt_client_rate);
            this.panel_details.Controls.Add(this.label5);
            this.panel_details.Controls.Add(this.txt_adress);
            this.panel_details.Controls.Add(this.label4);
            this.panel_details.Controls.Add(this.txt_client_code);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.txt_client_name);
            this.panel_details.Controls.Add(this.label6);
            this.panel_details.Location = new System.Drawing.Point(6, 21);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(429, 85);
            this.panel_details.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel4.Location = new System.Drawing.Point(638, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 85);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter or Update Client Information below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search Clients Below";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Client Name";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_name.Location = new System.Drawing.Point(3, 20);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.Size = new System.Drawing.Size(223, 21);
            this.txt_client_name.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Client Code";
            // 
            // txt_client_code
            // 
            this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_code.Location = new System.Drawing.Point(231, 20);
            this.txt_client_code.Name = "txt_client_code";
            this.txt_client_code.Size = new System.Drawing.Size(93, 21);
            this.txt_client_code.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Aqua;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Client Adress";
            // 
            // txt_adress
            // 
            this.txt_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adress.Location = new System.Drawing.Point(3, 61);
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(223, 21);
            this.txt_adress.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Aqua;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rate";
            // 
            // txt_client_rate
            // 
            this.txt_client_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_rate.Location = new System.Drawing.Point(231, 61);
            this.txt_client_rate.Name = "txt_client_rate";
            this.txt_client_rate.Size = new System.Drawing.Size(93, 21);
            this.txt_client_rate.TabIndex = 21;
            // 
            // chk_client_active
            // 
            this.chk_client_active.AutoSize = true;
            this.chk_client_active.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chk_client_active.Checked = true;
            this.chk_client_active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_client_active.Location = new System.Drawing.Point(339, 24);
            this.chk_client_active.Name = "chk_client_active";
            this.chk_client_active.Size = new System.Drawing.Size(85, 17);
            this.chk_client_active.TabIndex = 22;
            this.chk_client_active.Text = "Client Active";
            this.chk_client_active.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.Location = new System.Drawing.Point(120, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(73, 41);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnedit.Location = new System.Drawing.Point(5, 1);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(62, 43);
            this.btnedit.TabIndex = 24;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txt_record_guid
            // 
            this.txt_record_guid.Location = new System.Drawing.Point(6, 497);
            this.txt_record_guid.Name = "txt_record_guid";
            this.txt_record_guid.ReadOnly = true;
            this.txt_record_guid.Size = new System.Drawing.Size(828, 20);
            this.txt_record_guid.TabIndex = 1;
            this.txt_record_guid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.btn_locations);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Location = new System.Drawing.Point(438, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 85);
            this.panel5.TabIndex = 25;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnew.Location = new System.Drawing.Point(67, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(54, 41);
            this.btnnew.TabIndex = 25;
            this.btnnew.Text = "NEW";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.btnedit);
            this.panel3.Controls.Add(this.btnsave);
            this.panel3.Controls.Add(this.btnnew);
            this.panel3.Location = new System.Drawing.Point(-2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 47);
            this.panel3.TabIndex = 26;
            // 
            // btn_locations
            // 
            this.btn_locations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_locations.Location = new System.Drawing.Point(3, 55);
            this.btn_locations.Name = "btn_locations";
            this.btn_locations.Size = new System.Drawing.Size(188, 27);
            this.btn_locations.TabIndex = 27;
            this.btn_locations.Text = "Update Client Locations";
            this.btn_locations.UseVisualStyleBackColor = false;
            this.btn_locations.Click += new System.EventHandler(this.btn_locations_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Aqua;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Client ID";
            // 
            // txt_client_id
            // 
            this.txt_client_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_id.Location = new System.Drawing.Point(333, 62);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.ReadOnly = true;
            this.txt_client_id.Size = new System.Drawing.Size(93, 21);
            this.txt_client_id.TabIndex = 24;
            // 
            // frm_manage_clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(842, 523);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_manage_clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Securiko Uganda Ltd-Manage Client Profiles";
            this.Load += new System.EventHandler(this.frm_manage_clients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_clients)).EndInit();
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gdv_clients;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_client_code;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_client_rate;
        private System.Windows.Forms.CheckBox chk_client_active;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txt_record_guid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_locations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_client_id;
    }
}