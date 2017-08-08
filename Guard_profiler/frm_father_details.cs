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
using System.Data;
using System.IO;

namespace Guard_profiler
{
    public partial class frm_father_details : Form
    {
        public frm_father_details()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Guard_Employment_Records.UPDATE_GUARD_FATHER_DETAILS("UPDATE_GUARD_FATHER_DETAILS",txt_guard_number.Text,txt_adress.Text,cbo_district.Text, //function updates father details...although arguments remain unchanged
         txt_county.Text,txt_sub_county.Text,txt_parish.Text,txt_village.Text,txt_zone.Text,
         txt_lc1_chairperson_name.Text,txt_lc1_chairperson_phone.Text,txt_neighbor_name.Text,txt_neighbor_phone.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);
        }

        protected void RETURN_GUARD_DETAILS(string guard_number)
        {
            DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];

                txt_adress.Text = dtRow["father_name_and_adress"] != DBNull.Value ? (String)dtRow["father_name_and_adress"] : String.Empty;
                cbo_district.Text = dtRow["father_district"] != DBNull.Value ? (String)dtRow["father_district"] : String.Empty;
                txt_county.Text = dtRow["father_county"] != DBNull.Value ? (String)dtRow["father_county"] : String.Empty;
                txt_sub_county.Text = dtRow["father_sub_county"] != DBNull.Value ? (String)dtRow["father_sub_county"] : String.Empty;
                txt_parish.Text = dtRow["father_parish"] != DBNull.Value ? (String)dtRow["father_parish"] : String.Empty;
                txt_village.Text = dtRow["father_village"] != DBNull.Value ? (String)dtRow["father_village"] : String.Empty;
                txt_zone.Text = dtRow["father_zone"] != DBNull.Value ? (String)dtRow["father_zone"] : String.Empty;
                txt_lc1_chairperson_name.Text = dtRow["father_lc1_chairperson"] != DBNull.Value ? (String)dtRow["father_lc1_chairperson"] : String.Empty;
                txt_lc1_chairperson_phone.Text = dtRow["father_lc1_chairperson_phone"] != DBNull.Value ? (String)dtRow["father_lc1_chairperson_phone"] : String.Empty;
                txt_neighbor_name.Text = dtRow["father_village_neighbor_name"] != DBNull.Value ? (String)dtRow["father_village_neighbor_name"] : String.Empty;
                txt_neighbor_phone.Text = dtRow["father_village_neighbor_phone"] != DBNull.Value ? (String)dtRow["father_village_neighbor_phone"] : String.Empty;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }

        private void frm_father_details_Load(object sender, EventArgs e)
        {
            txt_name.Text = SystemConst.GET_OfficerName();
            txt_guard_number.Text = SystemConst.OfficerID;

            RETURN_GUARD_DETAILS(txt_guard_number.Text);

            GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", SystemConst.record_guid);
        }
    }
}
