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
    public partial class frm_pre_login : Form
    {
        public frm_pre_login()
        {
            InitializeComponent();
        }

        private void frm_pre_login_Load(object sender, EventArgs e)
        {
            panel_guard_number.Visible = false;
            GET_BRANCHES();
            cbo_branch.Text = SystemConst._branch_name;
            txt_guard_number_current.Text = SystemConst.guard_number;
            lbl_guid.Text = SystemConst.record_guid;
            cbo_branch_SelectedIndexChanged(cbo_branch, null);
        }

        protected void LOGIN_USER()
        {
            if (txtuser.Text == String.Empty || txtpass.Text == String.Empty)
            {
                MessageBox.Show("Username or Password cannot be empty");
            }
            else
            {
                DataTable dt = Users.LOGIN_USER("LOGIN_USER", txtuser.Text, Encrypt(txtpass.Text));
                DataRow dtRow = dt.Rows[0];
                int user_count = Convert.ToInt32(dtRow["user_id"]);
                if (user_count == 1)
                {

                    panel_guard_number.Visible = true;
                    txtuser.Clear();
                    txtpass.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Wrong username or password!!","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LOGIN_USER();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = String.Empty;
                dtRow["active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_branch.DataSource = dt;
                cbo_branch.DisplayMember = "branch";
                cbo_branch.ValueMember = "branch_code";

            }
        }

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.Text != String.Empty)
            {
                txt_guard_number_auto_code.Text = cbo_branch.SelectedValue.ToString();
            }
            else
            {
                txt_guard_number_auto_code.Clear();
            }
        }

        private void txt_guard_number_static_code_TextChanged(object sender, EventArgs e)
        {
            if (txt_guard_number_auto_code.Text != String.Empty && txt_guard_number_static_code.Text != String.Empty)
            {
                txt_guard_number_complete.Text = txt_guard_number_auto_code.Text + "" + txt_guard_number_static_code.Text;
            }
            else
            {
                txt_guard_number_complete.Clear();
            }
        }

        private void btn_update_guard_number_Click(object sender, EventArgs e)
        {
            if (txt_guard_number_static_code.Text == String.Empty || txt_guard_number_complete.Text == String.Empty)
            {
                MessageBox.Show("Type in the correct new guard number to update", "Update Guard Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to change this guard number??", "Change guard number", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    sg_Profiles.CHANGE_GUARD_NUMBER("CHANGE_GUARD_NUMBER", lbl_guid.Text, txt_guard_number_complete.Text);
                    MessageBox.Show("Guard Number has been successfully updated","Update Guard Number",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Visible = true;
                }
            }

        }
    }
}
