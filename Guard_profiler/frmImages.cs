using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Guard_profiler.App_code;

namespace Guard_profiler
{
    public partial class frmImages : Form
    {
        public frmImages()
        {
            InitializeComponent();
        }

        private void frmImages_Load(object sender, EventArgs e)
        {
            txt_forceNumber.Text = SystemConst.OfficerID;
            txt_name.Text = SystemConst.OfficerName;
            lbl_guid.Text = SystemConst.record_guid;

            GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", lbl_guid.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picBoxImage.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picBoxImage.Image == null)
            {
                MessageBox.Show("No Image selected");
            }
            else
            {
                try
                {
                    Image img = picBoxImage.Image;
                    byte[] arr;
                    ImageConverter converter = new ImageConverter();
                    arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                    HeadShotEngine.INSERT_OR_UPDATE_IMAGE("UPDATE_GUARD_HEAD_SHOT",lbl_guid.Text,arr);

                    MessageBox.Show("Update Successfull");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        protected void GET_OFFICER_HEADSHOT(string query, string record_guid)
        {
            DataTable dt = HeadShotEngine.SELECT_OFFICER_HEAD_SHOT(query, record_guid); 
            if (dt != null && dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];
                if (dtRow["image_data"] != DBNull.Value)
                {
                    byte[] data = (Byte[])dtRow["image_data"]; 
                    MemoryStream stream = new MemoryStream(data);
                    picBoxImage.Image = Image.FromStream(stream);
                }
            }
            else
            {
                picBoxImage.Image = null;
            }
        }
    }
}
