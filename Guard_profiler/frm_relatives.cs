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
    public partial class frm_relatives : Form
    {
        public frm_relatives()
        {
            InitializeComponent();
        }

        private void frm_relatives_Load(object sender, EventArgs e)
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

                txt_relative_1_name.Text = dtRow["relative_one_name"] != DBNull.Value ? (String)dtRow["relative_one_name"] : String.Empty;
                txt_relative_1_phone.Text = dtRow["relative_one_phone"] != DBNull.Value ? (String)dtRow["relative_one_phone"] : String.Empty;
                txt_relative_1_occupation.Text = dtRow["relative_one_occupation"] != DBNull.Value ? (String)dtRow["relative_one_occupation"] : String.Empty;
                txt_relative_2_name.Text = dtRow["relative_two_name"] != DBNull.Value ? (String)dtRow["relative_two_name"] : String.Empty;
                txt_relative_2_phone.Text = dtRow["relative_two_phone"] != DBNull.Value ? (String)dtRow["relative_two_phone"] : String.Empty;
                txt_relative_2_occupation.Text = dtRow["relative_two_occupation"] != DBNull.Value ? (String)dtRow["relative_two_occupation"] : String.Empty;
                txt_next_kin_name.Text = dtRow["next_of_kin_name"] != DBNull.Value ? (String)dtRow["next_of_kin_name"] : String.Empty;
                txt_next_kin_adress.Text = dtRow["next_of_kin_adress"] != DBNull.Value ? (String)dtRow["next_of_kin_adress"] : String.Empty;
                cbo_next_kin_relationship.Text = dtRow["next_of_kin_relationship"] != DBNull.Value ? (String)dtRow["next_of_kin_relationship"] : String.Empty;
                txt_next_kin_phone.Text = dtRow["next_of_kin_phone"] != DBNull.Value ? (String)dtRow["next_of_kin_phone"] : String.Empty;
                txt_next_kin_national_id.Text = dtRow["next_of_kin_national_id_number"] != DBNull.Value ? (String)dtRow["next_of_kin_national_id_number"] : String.Empty;

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
            Guard_Employment_Records.UPDATE_GUARD_RELATIVE_DETAILS("UPDATE_GUARD_RELATIVE_DETAILS",txt_guard_number.Text,txt_relative_1_name.Text,txt_relative_1_phone.Text, //function updates father details...although arguments remain unchanged
            txt_relative_1_occupation.Text,txt_relative_2_name.Text,txt_relative_2_phone.Text,txt_relative_2_occupation.Text,txt_next_kin_name.Text,
            txt_next_kin_adress.Text,cbo_next_kin_relationship.Text,txt_next_kin_phone.Text,txt_next_kin_national_id.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }

    }
}
