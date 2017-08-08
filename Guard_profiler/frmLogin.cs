using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LOGIN_USER();
        }

        protected void LOGIN_USER() {
            if (txtuser.Text == String.Empty || txtpass.Text == String.Empty)
            {
                MessageBox.Show("Username or Password cannot be empty");
            }
            else {
                DataTable dt = Users.LOGIN_USER("LOGIN_USER", txtuser.Text,Encrypt(txtpass.Text));
                DataRow dtRow = dt.Rows[0];
                int user_count = Convert.ToInt32(dtRow["user_id"]);
                if (user_count == 1)
                {

                    this.Visible = false;
                    SystemConst._username = txtuser.Text;
                    //frmMain main = new frmMain();
                    //main.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application will exit,proceed??", "EXIT", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Visible = true;
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
    }
}
