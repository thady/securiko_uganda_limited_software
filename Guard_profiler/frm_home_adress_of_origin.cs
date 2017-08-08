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
    public partial class frm_home_adress_of_origin : Form
    {
        public frm_home_adress_of_origin()
        {
            InitializeComponent();
        }

        private void frm_home_adress_of_origin_Load(object sender, EventArgs e)
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

                txt_guard_adress.Text = dtRow["home_origin_adress"] != DBNull.Value ? (String)dtRow["home_origin_adress"] : String.Empty;
                cbo_district.Text = dtRow["home_district"] != DBNull.Value ? (String)dtRow["home_district"] : String.Empty;
                txt_county.Text = dtRow["home_county"] != DBNull.Value ? (String)dtRow["home_county"] : String.Empty;
                txt_sub_county.Text = dtRow["home_sub_county"] != DBNull.Value ? (String)dtRow["home_sub_county"] : String.Empty;
                txt_parish.Text = dtRow["home_parish"] != DBNull.Value ? (String)dtRow["home_parish"] : String.Empty;
                txt_village.Text = dtRow["home_village"] != DBNull.Value ? (String)dtRow["home_village"] : String.Empty;
                txt_zone.Text = dtRow["home_zone"] != DBNull.Value ? (String)dtRow["home_zone"] : String.Empty;
                txt_lc1_chairperson_name.Text = dtRow["home_lc1_chaiperson_name"] != DBNull.Value ? (String)dtRow["home_lc1_chaiperson_name"] : String.Empty;
                txt_lc1_chairperson_phone.Text = dtRow["home_lc1_chaiperson_phone"] != DBNull.Value ? (String)dtRow["home_lc1_chaiperson_phone"] : String.Empty;
                txt_neighbor_name.Text = dtRow["home_village_neigbor_name"] != DBNull.Value ? (String)dtRow["home_village_neigbor_name"] : String.Empty;
                txt_neighbor_phone.Text = dtRow["home_village_neigbor_phone"] != DBNull.Value ? (String)dtRow["home_village_neigbor_phone"] : String.Empty;

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

        private void btnsave_Click(object sender, EventArgs e)
        {
            Guard_Employment_Records.UPDATE_GUARD_HOME_ADRESS_OF_ORIGIN("UPDATE_GUARD_HOME_ADRESS_OF_ORIGIN", txt_guard_number.Text, txt_guard_adress.Text, cbo_district.Text,
            txt_county.Text, txt_sub_county.Text, txt_parish.Text, txt_village.Text, txt_zone.Text,
            txt_lc1_chairperson_name.Text, txt_lc1_chairperson_phone.Text, txt_neighbor_name.Text, txt_neighbor_phone.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);
        }
    }
}
