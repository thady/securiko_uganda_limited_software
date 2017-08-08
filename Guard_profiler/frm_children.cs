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
using System.IO;

namespace Guard_profiler
{
    public partial class frm_children : Form
    {
        public frm_children()
        {
            InitializeComponent();
        }

        private void frm_children_Load(object sender, EventArgs e)
        {
            txt_name.Text = SystemConst.GET_OfficerName();
            txt_guard_number.Text = SystemConst.OfficerID;

            RETURN_GUARD_DETAILS(txt_guard_number.Text);

            GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", SystemConst.record_guid);
        }

        protected void RETURN_GUARD_DETAILS(string guard_number)
        {
            DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];

                txt_child_1_name.Text = dtRow["child_one_name"] != DBNull.Value ? (String)dtRow["child_one_name"] : String.Empty;
                txt_child_1_contact.Text = dtRow["child_one_contact"] != DBNull.Value ? (String)dtRow["child_one_contact"] : String.Empty;
                txt_child_2_name.Text = dtRow["child_two_name"] != DBNull.Value ? (String)dtRow["child_two_name"] : String.Empty;
                txt_child_2_contact.Text = dtRow["child_two_contact"] != DBNull.Value ? (String)dtRow["child_two_contact"] : String.Empty;
                txt_child_3_name.Text = dtRow["child_three_name"] != DBNull.Value ? (String)dtRow["child_three_name"] : String.Empty;
                txt_child_3_contact.Text = dtRow["child_three_contact"] != DBNull.Value ? (String)dtRow["child_three_contact"] : String.Empty;
                txt_child_4_name.Text = dtRow["child_four_name"] != DBNull.Value ? (String)dtRow["child_four_name"] : String.Empty;
                txt_child_4_contact.Text = dtRow["child_four_contact"] != DBNull.Value ? (String)dtRow["child_four_contact"] : String.Empty;
               
                panel_details.Enabled = false;
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            Guard_Employment_Records.UPDATE_GUARD_CHILDREN_DETAILS("UPDATE_GUARD_CHILDREN_DETAILS", txt_guard_number.Text, txt_child_1_name.Text, txt_child_1_contact.Text, //function updates father details...although arguments remain unchanged
            txt_child_2_name.Text, txt_child_2_contact.Text, txt_child_3_name.Text, txt_child_3_contact.Text, txt_child_4_name.Text,
            txt_child_4_contact.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }
    }
}
