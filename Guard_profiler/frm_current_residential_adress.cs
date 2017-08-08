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
    public partial class frm_current_residential_adress : Form
    {
        public frm_current_residential_adress()
        {
            InitializeComponent();
        }

        private void frm_current_residential_adress_Load(object sender, EventArgs e)
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

                txt_adress.Text = dtRow["current_adress"] != DBNull.Value ? (String)dtRow["current_adress"] : String.Empty;
                cbo_dstrict.Text = dtRow["current_district"] != DBNull.Value ? (String)dtRow["current_district"] : String.Empty;
                txt_county.Text = dtRow["current_county"] != DBNull.Value ? (String)dtRow["current_county"] : String.Empty;
                txt_sub_county.Text = dtRow["current_sub_county"] != DBNull.Value ? (String)dtRow["current_sub_county"] : String.Empty;
                txt_parish.Text = dtRow["current_parish"] != DBNull.Value ? (String)dtRow["current_parish"] : String.Empty;
                txt_village.Text = dtRow["current_village"] != DBNull.Value ? (String)dtRow["current_village"] : String.Empty;
                txt_zone.Text = dtRow["current_zone"] != DBNull.Value ? (String)dtRow["current_zone"] : String.Empty;
                txt_landlord_name.Text = dtRow["landlord_name"] != DBNull.Value ? (String)dtRow["landlord_name"] : String.Empty;
                txt_lc_1_chairperson_name.Text = dtRow["lc1_chairperson_name"] != DBNull.Value ? (String)dtRow["lc1_chairperson_name"] : String.Empty;
                txt_lc_1_chairperson_phone.Text = dtRow["lc1_chairperson_phone"] != DBNull.Value ? (String)dtRow["lc1_chairperson_phone"] : String.Empty;

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
            Guard_Employment_Records.UPDATE_CURRENT_RESIDENTIAL_ADRESS_DETAILS("UPDATE_CURRENT_RESIDENTIAL_ADRESS_DETAILS", txt_guard_number.Text, txt_adress.Text, cbo_dstrict.Text,
           txt_county.Text, txt_sub_county.Text, txt_parish.Text, txt_village.Text, txt_zone.Text,
           txt_landlord_name.Text, txt_lc_1_chairperson_name.Text, txt_lc_1_chairperson_phone.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }
    }
}
