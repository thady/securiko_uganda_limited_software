namespace Guard_profiler
{
    partial class frm_prev_employer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_prev_employer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel_details = new System.Windows.Forms.Panel();
            this.cbo_departure_reason = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_employer_adress = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_employer_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_details.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.panel_details);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 478);
            this.panel1.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(423, 413);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(116, 45);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(540, 412);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(116, 45);
            this.btnsave.TabIndex = 32;
            this.btnsave.Text = "SAVE DETAILS";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_details.Controls.Add(this.cbo_departure_reason);
            this.panel_details.Controls.Add(this.label4);
            this.panel_details.Controls.Add(this.txt_employer_adress);
            this.panel_details.Controls.Add(this.label3);
            this.panel_details.Controls.Add(this.txt_employer_name);
            this.panel_details.Controls.Add(this.label2);
            this.panel_details.Location = new System.Drawing.Point(3, 147);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(654, 260);
            this.panel_details.TabIndex = 40;
            // 
            // cbo_departure_reason
            // 
            this.cbo_departure_reason.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_departure_reason.FormattingEnabled = true;
            this.cbo_departure_reason.Items.AddRange(new object[] {
            "",
            "End of Contract",
            "Contract Terminated",
            "Other"});
            this.cbo_departure_reason.Location = new System.Drawing.Point(10, 150);
            this.cbo_departure_reason.Name = "cbo_departure_reason";
            this.cbo_departure_reason.Size = new System.Drawing.Size(252, 26);
            this.cbo_departure_reason.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(7, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Departure Reason";
            // 
            // txt_employer_adress
            // 
            this.txt_employer_adress.Location = new System.Drawing.Point(10, 74);
            this.txt_employer_adress.Name = "txt_employer_adress";
            this.txt_employer_adress.Size = new System.Drawing.Size(350, 54);
            this.txt_employer_adress.TabIndex = 29;
            this.txt_employer_adress.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Employer Adress";
            // 
            // txt_employer_name
            // 
            this.txt_employer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_employer_name.Location = new System.Drawing.Point(10, 28);
            this.txt_employer_name.Name = "txt_employer_name";
            this.txt_employer_name.Size = new System.Drawing.Size(350, 24);
            this.txt_employer_name.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Employer Name";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.picBoxImage);
            this.panel9.Location = new System.Drawing.Point(502, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(155, 143);
            this.panel9.TabIndex = 39;
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxImage.Location = new System.Drawing.Point(3, 3);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(145, 133);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImage.TabIndex = 0;
            this.picBoxImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_guard_number);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_name);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 100);
            this.panel2.TabIndex = 38;
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(8, 69);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(350, 24);
            this.txt_guard_number.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(5, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Guard Number";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(8, 28);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(350, 24);
            this.txt_name.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(5, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Guard Name";
            // 
            // frm_prev_employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(664, 485);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_prev_employer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUARD PREVIOUS EMPLOYER DETAILS";
            this.Load += new System.EventHandler(this.frm_prev_employer_Load);
            this.panel1.ResumeLayout(false);
            this.panel_details.ResumeLayout(false);
            this.panel_details.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_guard_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Panel panel_details;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_employer_name;
        private System.Windows.Forms.RichTextBox txt_employer_adress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_departure_reason;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnsave;
    }
}