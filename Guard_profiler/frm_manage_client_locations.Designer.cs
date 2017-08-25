namespace Guard_profiler
{
    partial class frm_manage_client_locations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_manage_client_locations));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_client_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_client_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gdv_client_locations = new System.Windows.Forms.DataGridView();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txt_record_guid = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_client_locations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.txt_record_guid);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.txt_location);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_client_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 332);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.gdv_client_locations);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 254);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter or update client location details below";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Client Name";
            // 
            // txt_client_name
            // 
            this.txt_client_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_name.Location = new System.Drawing.Point(3, 20);
            this.txt_client_name.Name = "txt_client_name";
            this.txt_client_name.ReadOnly = true;
            this.txt_client_name.Size = new System.Drawing.Size(195, 21);
            this.txt_client_name.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Location Name";
            // 
            // txt_location
            // 
            this.txt_location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.Location = new System.Drawing.Point(204, 20);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(173, 21);
            this.txt_location.TabIndex = 18;
            // 
            // txt_client_code
            // 
            this.txt_client_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_client_code.Location = new System.Drawing.Point(427, 0);
            this.txt_client_code.Name = "txt_client_code";
            this.txt_client_code.ReadOnly = true;
            this.txt_client_code.Size = new System.Drawing.Size(101, 21);
            this.txt_client_code.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(351, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Client Code";
            // 
            // gdv_client_locations
            // 
            this.gdv_client_locations.AllowUserToAddRows = false;
            this.gdv_client_locations.AllowUserToDeleteRows = false;
            this.gdv_client_locations.AllowUserToResizeColumns = false;
            this.gdv_client_locations.AllowUserToResizeRows = false;
            this.gdv_client_locations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_client_locations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_client_locations.Location = new System.Drawing.Point(3, 3);
            this.gdv_client_locations.Name = "gdv_client_locations";
            this.gdv_client_locations.ReadOnly = true;
            this.gdv_client_locations.Size = new System.Drawing.Size(525, 248);
            this.gdv_client_locations.TabIndex = 0;
            this.gdv_client_locations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_client_locations_CellClick);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnsave.Location = new System.Drawing.Point(379, 20);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(50, 23);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnedit.Location = new System.Drawing.Point(435, 20);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(48, 23);
            this.btnedit.TabIndex = 20;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txt_record_guid
            // 
            this.txt_record_guid.Location = new System.Drawing.Point(0, 309);
            this.txt_record_guid.Name = "txt_record_guid";
            this.txt_record_guid.Size = new System.Drawing.Size(535, 20);
            this.txt_record_guid.TabIndex = 1;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnew.Location = new System.Drawing.Point(483, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(48, 23);
            this.btnnew.TabIndex = 21;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // frm_manage_client_locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(541, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_client_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_manage_client_locations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Securiko Uganda Ltd-Manage Client Locations";
            this.Load += new System.EventHandler(this.frm_manage_client_locations_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_client_locations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_client_name;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_client_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gdv_client_locations;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.TextBox txt_record_guid;
        private System.Windows.Forms.Button btnnew;
    }
}