namespace Guard_profiler
{
    partial class frm_transfer_guards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_transfer_guards));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_note = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_guard_number_complete = new System.Windows.Forms.TextBox();
            this.txt_guard_number_static_code = new System.Windows.Forms.TextBox();
            this.txt_guard_number_auto_code = new System.Windows.Forms.TextBox();
            this.cbo_new_branch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_transfer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_guard_number = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_full_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_branch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gdv_guards = new System.Windows.Forms.DataGridView();
            this.reSize1 = new LarcomAndYoung.Windows.Forms.ReSize(this.components);
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_name_search = new System.Windows.Forms.Button();
            this.txt_name_search = new System.Windows.Forms.RichTextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btn_branch_search = new System.Windows.Forms.Button();
            this.cbo_branch_search = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txt_note);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btn_transfer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 612);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label44);
            this.panel5.Controls.Add(this.btn_branch_search);
            this.panel5.Controls.Add(this.cbo_branch_search);
            this.panel5.Controls.Add(this.label43);
            this.panel5.Controls.Add(this.btn_name_search);
            this.panel5.Controls.Add(this.txt_name_search);
            this.panel5.Location = new System.Drawing.Point(3, 127);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(923, 47);
            this.panel5.TabIndex = 15;
            // 
            // txt_note
            // 
            this.txt_note.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.ForeColor = System.Drawing.Color.White;
            this.txt_note.Location = new System.Drawing.Point(750, 3);
            this.txt_note.Name = "txt_note";
            this.txt_note.ReadOnly = true;
            this.txt_note.Size = new System.Drawing.Size(179, 69);
            this.txt_note.TabIndex = 14;
            this.txt_note.Text = "NOTE: The system keeps track of the person executing the \nguard transfer for trac" +
    "king purporses";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Beige;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label49);
            this.panel4.Controls.Add(this.label48);
            this.panel4.Controls.Add(this.label47);
            this.panel4.Controls.Add(this.txt_guard_number_complete);
            this.panel4.Controls.Add(this.txt_guard_number_static_code);
            this.panel4.Controls.Add(this.txt_guard_number_auto_code);
            this.panel4.Controls.Add(this.cbo_new_branch);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(386, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 106);
            this.panel4.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(9, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Assign New Guard Number";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Yellow;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(115, 50);
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
            this.label48.Location = new System.Drawing.Point(221, 50);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(117, 16);
            this.label48.TabIndex = 71;
            this.label48.Text = "Full Guard number";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Yellow;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(9, 50);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(35, 16);
            this.label47.TabIndex = 70;
            this.label47.Text = "Auto";
            // 
            // txt_guard_number_complete
            // 
            this.txt_guard_number_complete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_complete.Location = new System.Drawing.Point(224, 68);
            this.txt_guard_number_complete.Name = "txt_guard_number_complete";
            this.txt_guard_number_complete.ReadOnly = true;
            this.txt_guard_number_complete.Size = new System.Drawing.Size(119, 29);
            this.txt_guard_number_complete.TabIndex = 69;
            // 
            // txt_guard_number_static_code
            // 
            this.txt_guard_number_static_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_static_code.Location = new System.Drawing.Point(118, 68);
            this.txt_guard_number_static_code.Name = "txt_guard_number_static_code";
            this.txt_guard_number_static_code.Size = new System.Drawing.Size(100, 29);
            this.txt_guard_number_static_code.TabIndex = 68;
            this.txt_guard_number_static_code.TextChanged += new System.EventHandler(this.txt_guard_number_static_code_TextChanged);
            this.txt_guard_number_static_code.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_guard_number_static_code_KeyDown);
            this.txt_guard_number_static_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_guard_number_static_code_KeyPress);
            // 
            // txt_guard_number_auto_code
            // 
            this.txt_guard_number_auto_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number_auto_code.Location = new System.Drawing.Point(12, 68);
            this.txt_guard_number_auto_code.Name = "txt_guard_number_auto_code";
            this.txt_guard_number_auto_code.ReadOnly = true;
            this.txt_guard_number_auto_code.Size = new System.Drawing.Size(100, 29);
            this.txt_guard_number_auto_code.TabIndex = 67;
            // 
            // cbo_new_branch
            // 
            this.cbo_new_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_new_branch.FormattingEnabled = true;
            this.cbo_new_branch.Items.AddRange(new object[] {
            "",
            "Kampala",
            "Mbale",
            "Entebbe",
            "Lira",
            "Hoima"});
            this.cbo_new_branch.Location = new System.Drawing.Point(97, 3);
            this.cbo_new_branch.Name = "cbo_new_branch";
            this.cbo_new_branch.Size = new System.Drawing.Size(246, 26);
            this.cbo_new_branch.TabIndex = 8;
            this.cbo_new_branch.SelectedIndexChanged += new System.EventHandler(this.cbo_new_branch_SelectedIndexChanged);
            this.cbo_new_branch.Click += new System.EventHandler(this.cbo_new_branch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Branch Name";
            // 
            // btn_transfer
            // 
            this.btn_transfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_transfer.Location = new System.Drawing.Point(750, 74);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(120, 47);
            this.btn_transfer.TabIndex = 5;
            this.btn_transfer.Text = "EXECUTE GUARD TRANSFER";
            this.btn_transfer.UseVisualStyleBackColor = false;
            this.btn_transfer.Click += new System.EventHandler(this.btn_transfer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(383, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details of guard\'s new branch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(19, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Details of current guard\'s branch";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.txt_guard_number);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_full_name);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cbo_branch);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(22, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 106);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txt_guard_number
            // 
            this.txt_guard_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_guard_number.Location = new System.Drawing.Point(97, 63);
            this.txt_guard_number.Name = "txt_guard_number";
            this.txt_guard_number.Size = new System.Drawing.Size(227, 24);
            this.txt_guard_number.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Guard Number";
            // 
            // txt_full_name
            // 
            this.txt_full_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_full_name.Location = new System.Drawing.Point(97, 33);
            this.txt_full_name.Name = "txt_full_name";
            this.txt_full_name.Size = new System.Drawing.Size(227, 24);
            this.txt_full_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Guard Name";
            // 
            // cbo_branch
            // 
            this.cbo_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch.FormattingEnabled = true;
            this.cbo_branch.Items.AddRange(new object[] {
            "",
            "Kampala",
            "Mbale",
            "Entebbe",
            "Lira",
            "Hoima"});
            this.cbo_branch.Location = new System.Drawing.Point(97, 3);
            this.cbo_branch.Name = "cbo_branch";
            this.cbo_branch.Size = new System.Drawing.Size(227, 26);
            this.cbo_branch.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Branch Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.gdv_guards);
            this.panel2.Location = new System.Drawing.Point(3, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 433);
            this.panel2.TabIndex = 0;
            // 
            // gdv_guards
            // 
            this.gdv_guards.AllowUserToAddRows = false;
            this.gdv_guards.AllowUserToDeleteRows = false;
            this.gdv_guards.AllowUserToResizeColumns = false;
            this.gdv_guards.AllowUserToResizeRows = false;
            this.gdv_guards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gdv_guards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdv_guards.Location = new System.Drawing.Point(-8, 3);
            this.gdv_guards.Name = "gdv_guards";
            this.gdv_guards.ReadOnly = true;
            this.gdv_guards.Size = new System.Drawing.Size(931, 427);
            this.gdv_guards.TabIndex = 1;
            this.gdv_guards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdv_guards_CellClick);
            // 
            // reSize1
            // 
            this.reSize1.About = null;
            this.reSize1.AutoCenterFormOnLoad = false;
            this.reSize1.Enabled = true;
            this.reSize1.HostContainer = this;
            this.reSize1.InitialHostContainerHeight = 628D;
            this.reSize1.InitialHostContainerWidth = 937D;
            this.reSize1.Tag = null;
            // 
            // txt_guid
            // 
            this.txt_guid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_guid.ForeColor = System.Drawing.Color.White;
            this.txt_guid.Location = new System.Drawing.Point(2, 610);
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.Size = new System.Drawing.Size(932, 20);
            this.txt_guid.TabIndex = 1;
            this.txt_guid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Yellow;
            this.label43.Location = new System.Drawing.Point(3, 2);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(120, 13);
            this.label43.TabIndex = 64;
            this.label43.Text = "Enter First or Last Name";
            // 
            // btn_name_search
            // 
            this.btn_name_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_name_search.Location = new System.Drawing.Point(215, 16);
            this.btn_name_search.Name = "btn_name_search";
            this.btn_name_search.Size = new System.Drawing.Size(65, 28);
            this.btn_name_search.TabIndex = 63;
            this.btn_name_search.Text = "Search";
            this.btn_name_search.UseVisualStyleBackColor = false;
            this.btn_name_search.Click += new System.EventHandler(this.btn_name_search_Click);
            // 
            // txt_name_search
            // 
            this.txt_name_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_search.Location = new System.Drawing.Point(3, 18);
            this.txt_name_search.Name = "txt_name_search";
            this.txt_name_search.Size = new System.Drawing.Size(210, 26);
            this.txt_name_search.TabIndex = 62;
            this.txt_name_search.Text = "";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Yellow;
            this.label44.Location = new System.Drawing.Point(296, 2);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(130, 13);
            this.label44.TabIndex = 67;
            this.label44.Text = "Select a Branch to search";
            // 
            // btn_branch_search
            // 
            this.btn_branch_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_branch_search.Location = new System.Drawing.Point(511, 16);
            this.btn_branch_search.Name = "btn_branch_search";
            this.btn_branch_search.Size = new System.Drawing.Size(65, 28);
            this.btn_branch_search.TabIndex = 66;
            this.btn_branch_search.Text = "Search";
            this.btn_branch_search.UseVisualStyleBackColor = false;
            this.btn_branch_search.Click += new System.EventHandler(this.btn_branch_search_Click);
            // 
            // cbo_branch_search
            // 
            this.cbo_branch_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_branch_search.FormattingEnabled = true;
            this.cbo_branch_search.Location = new System.Drawing.Point(299, 16);
            this.cbo_branch_search.Name = "cbo_branch_search";
            this.cbo_branch_search.Size = new System.Drawing.Size(210, 26);
            this.cbo_branch_search.TabIndex = 65;
            // 
            // frm_transfer_guards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(937, 628);
            this.Controls.Add(this.txt_guid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_transfer_guards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Guard From One Branch to another";
            this.Load += new System.EventHandler(this.frm_transfer_guards_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdv_guards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gdv_guards;
        private LarcomAndYoung.Windows.Forms.ReSize reSize1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_branch;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_full_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_guard_number;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbo_new_branch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txt_guard_number_complete;
        private System.Windows.Forms.TextBox txt_guard_number_static_code;
        private System.Windows.Forms.TextBox txt_guard_number_auto_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_guid;
        private System.Windows.Forms.RichTextBox txt_note;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_name_search;
        private System.Windows.Forms.RichTextBox txt_name_search;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btn_branch_search;
        private System.Windows.Forms.ComboBox cbo_branch_search;
    }
}