using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Guard_profiler.App_code;
using System.Security.Cryptography;
using System.IO;

namespace Guard_profiler
{
    public partial class frm_users : Form
    {
        public frm_users()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_user_id.Text == String.Empty)
            {
                SAVE_NEW_USER_DETAILS();
            }
            else
            {
                Users.UPDATE_USER_DETAILS(
               "UPDATE_USER_DETAILS",
               txt_name.Text,
               cbo_gender.Text,
               chk_admin.Checked == true ? true : false,
               chk_active.Checked == true ? true : false,
               Convert.ToInt32(txt_user_id.Text)
           );
                MessageBox.Show("Successfully updated user details");
            }
        }

        protected void SAVE_NEW_USER_DETAILS()
        {
            if (txt_name.Text == String.Empty || txt_username.Text == String.Empty || txt_password.Text == String.Empty || txt_password2.Text == String.Empty || cbo_gender.Text == String.Empty)
            {
                MessageBox.Show("All fields marked red are mandatory");
            }
            else if (txt_password.Text != txt_password2.Text)
            {

                MessageBox.Show("Password Fields must match");
            }
            else
            {

                Users.NEW_USER_PROFILE(
                   "NEW_USER_PROFILE",
                    txt_name.Text,
                    cbo_gender.Text,
                    txt_username.Text,
                    Encrypt(txt_password.Text),
                    chk_admin.Checked == true ? true : false,
                    chk_active.Checked == true ? true : false
           );
                MessageBox.Show("User added successfully");
            }
        }

        private void frm_users_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            SELECT_USER_LIST();
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

        protected void SELECT_USER_LIST()
        {
            DataTable dt = Users.SELECT_USER_LIST("SELECT_USER_LIST");
            if (dt != null && dt.Rows.Count != 0)
            {

                gdv_users.DataSource = dt;

                int count = dt.Rows.Count;

                gdv_users.Columns[0].Visible = false;
                gdv_users.Columns[1].HeaderText = "Name";
                gdv_users.Columns[2].HeaderText = "Gender";
                gdv_users.Columns[3].HeaderText = "Admin?";
                gdv_users.Columns[4].HeaderText = "Active?";

                gdv_users.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_users.DefaultCellStyle.SelectionForeColor = Color.Black;

                gdv_users.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_users.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_users.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_users.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_users.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_users.DefaultCellStyle.SelectionBackColor = Color.White;
                gdv_users.DefaultCellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void gdv_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_users.Rows.Count != 0)
            {
                int user_id = Convert.ToInt32(gdv_users.CurrentRow.Cells[0].Value.ToString());
                DataTable dt = Users.SELECT_USER_DETAILS("SELECT_USER_DETAILS", user_id);
                if (dt.Rows.Count != 0)
                {
                    DataRow dtRow = dt.Rows[0];

                    txt_name.Text = dtRow["name"] != DBNull.Value ? (String)dtRow["name"] : String.Empty;
                    cbo_gender.Text = dtRow["gender"] != DBNull.Value ? (String)dtRow["gender"] : String.Empty;
                    txt_username.Text = dtRow["user_name"] != DBNull.Value ? (String)dtRow["user_name"] : String.Empty;
                    chk_admin.Checked = (Boolean)dtRow["is_admin"];
                    chk_active.Checked = (Boolean)dtRow["user_active"];

                    txt_user_id.Text = user_id.ToString();
                    panel3.Enabled = false;
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
        }

        protected void Clear()
        {
            txt_name.Clear();
            txt_password.Clear();
            txt_user_id.Clear();
            txt_username.Clear();
            cbo_gender.Text = String.Empty;
            chk_active.Checked = true;
            chk_admin.Checked = false;

            panel3.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
