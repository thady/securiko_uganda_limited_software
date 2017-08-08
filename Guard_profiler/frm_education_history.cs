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
    public partial class frm_education_history : Form
    {
        
        public frm_education_history()
        {
            InitializeComponent();
        }

        private void frm_education_history_Load(object sender, EventArgs e)
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
                int dummy_year = -1;

                txt_school_1_name.Text = dtRow["school_1_name"] != DBNull.Value ? (String)dtRow["school_1_name"] : String.Empty;
                txt_school_1_year.Text = dtRow["school_1_year"] != DBNull.Value ?Convert.ToInt32(dtRow["school_1_year"]) != dummy_year? Convert.ToInt32(dtRow["school_1_year"]).ToString(): String.Empty : String.Empty;
                cbo_school_1_leve.Text = dtRow["school_1_level"] != DBNull.Value ? (String)dtRow["school_1_level"] : String.Empty;
                txt_school_1_qualification.Text = dtRow["school_1_qualification"] != DBNull.Value ? (String)dtRow["school_1_qualification"] : String.Empty;

                txt_school_2_name.Text = dtRow["school_2_name"] != DBNull.Value ? (String)dtRow["school_2_name"] : String.Empty;
                txt_school_2_year.Text = dtRow["school_2_year"] != DBNull.Value ? Convert.ToInt32(dtRow["school_2_year"]) != dummy_year? Convert.ToInt32(dtRow["school_2_year"]).ToString():String.Empty : String.Empty;
                cbo_school_2_leve.Text = dtRow["school_2_level"] != DBNull.Value ? (String)dtRow["school_2_level"] : String.Empty;
                txt_school_2_qualification.Text = dtRow["school_2_qualification"] != DBNull.Value ? (String)dtRow["school_2_qualification"] : String.Empty;

                txt_school_3_name.Text = dtRow["school_3_name"] != DBNull.Value ? (String)dtRow["school_3_name"] : String.Empty;
                txt_school_3_year.Text = dtRow["school_3_year"] != DBNull.Value? Convert.ToInt32(dtRow["school_3_year"]) != dummy_year? Convert.ToInt32(dtRow["school_3_year"]).ToString() : String.Empty :String.Empty ;
                cbo_school_3_leve.Text = dtRow["school_3_level"] != DBNull.Value ? (String)dtRow["school_3_level"] : String.Empty;
                txt_school_3_qualification.Text = dtRow["school_3_qualification"] != DBNull.Value ? (String)dtRow["school_3_qualification"] : String.Empty;

                txt_school_4_name.Text = dtRow["school_4_name"] != DBNull.Value ? (String)dtRow["school_4_name"] : String.Empty;
                txt_school_4_year.Text = dtRow["school_4_year"] != DBNull.Value ? Convert.ToInt32(dtRow["school_4_year"]) != dummy_year? Convert.ToInt32(dtRow["school_4_year"]).ToString():String.Empty :String.Empty ;
                cbo_school_4_leve.Text = dtRow["school_4_level"] != DBNull.Value ? (String)dtRow["school_4_level"] : String.Empty;
                txt_school_4_qualification.Text = dtRow["school_4_qualification"] != DBNull.Value ? (String)dtRow["school_4_qualification"] : String.Empty;

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
            Guard_Employment_Records.UPDATE_GUARD_EDUCATION_HISTORY("UPDATE_GUARD_EDUCATION_HISTORY", txt_guard_number.Text, txt_school_1_name.Text,txt_school_1_year.Text != String.Empty? Convert.ToInt32(txt_school_1_year.Text):-1, cbo_school_1_leve.Text, txt_school_1_qualification.Text != String.Empty?txt_school_1_qualification.Text:String.Empty,
                txt_school_2_name.Text != String.Empty?txt_school_2_name.Text:String.Empty,txt_school_2_year.Text !=String.Empty?Convert.ToInt32(txt_school_2_year.Text):-1, cbo_school_2_leve.Text, txt_school_2_qualification.Text != String.Empty?txt_school_2_qualification.Text:String.Empty,
                txt_school_3_name.Text != String.Empty? txt_school_3_name.Text:String.Empty,txt_school_3_year.Text != String.Empty?Convert.ToInt32(txt_school_3_year.Text):-1, cbo_school_3_leve.Text, txt_school_3_qualification.Text != String.Empty?txt_school_3_qualification.Text:String.Empty,
                txt_school_4_name.Text != String.Empty?txt_school_4_name.Text:String.Empty,txt_school_4_year.Text != String.Empty? Convert.ToInt32(txt_school_4_year.Text):-1, cbo_school_4_leve.Text != String.Empty?cbo_school_4_leve.Text:"", txt_school_4_qualification.Text != String.Empty?txt_school_4_qualification.Text:String.Empty);
        }
    }
}
