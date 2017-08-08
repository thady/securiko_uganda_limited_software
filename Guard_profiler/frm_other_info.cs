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
    public partial class frm_other_info : Form
    {
        DateTime? dt = null;

        public frm_other_info()
        {
            InitializeComponent();
        }

        private void frm_other_info_Load(object sender, EventArgs e)
        {
            txt_name.Text = SystemConst.GET_OfficerName();
            txt_guard_number.Text = SystemConst.OfficerID;

            RETURN_GUARD_DETAILS(txt_guard_number.Text);

            GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", SystemConst.record_guid);

            chk_illness_CheckedChanged(chk_illness, null);

            cbo_bank_name_SelectedIndexChanged(cbo_bank_name, null);

            GET_POSITIONS();
        }

        protected void RETURN_GUARD_DETAILS(string guard_number)
        {
            DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];

                chk_illness.Checked = dtRow["serious_illness_or_accident"] != DBNull.Value? (Boolean)dtRow["serious_illness_or_accident"] : false;
                txt_illness_name.Text = dtRow["nature_of_illness"] != DBNull.Value ? (String)dtRow["nature_of_illness"] : String.Empty;
                dt_illness_date.Value = dtRow["illness_or_accident_date"] != DBNull.Value ? Convert.ToDateTime(dtRow["illness_or_accident_date"]) : DateTime.Today;
                chk_premonia.Checked = dtRow["premonia_or_athma_incident"] != DBNull.Value? (Boolean)dtRow["premonia_or_athma_incident"] : false;
                chk_epilipsy.Checked = dtRow["epilipsy_incident"] != DBNull.Value? (Boolean)dtRow["epilipsy_incident"]:false;
                chk_TB.Checked = dtRow["tb_incident"] != DBNull.Value? (Boolean)dtRow["tb_incident"]:false;
                dt_employment_date.Value = dtRow["date_employed"] != DBNull.Value ?Convert.ToDateTime(dtRow["date_employed"]) : DateTime.Today;
                txt_recruitment_officer.Text = dtRow["recruiting_officer_name"] != DBNull.Value ? (String)dtRow["recruiting_officer_name"] : String.Empty;
                txt_salary.Text = dtRow["commence_salary"] != DBNull.Value ? (String)dtRow["commence_salary"] : String.Empty;

                txt_nssf_no.Text = dtRow["nssf_number"] != DBNull.Value ? (String)dtRow["nssf_number"] : String.Empty;
                cbo_bank_name.Text= dtRow["bank_name"] != DBNull.Value ? (String)dtRow["bank_name"] : String.Empty;
                txt_acc_no.Text = dtRow["account_number"] != DBNull.Value ? (String)dtRow["account_number"] : String.Empty;

                cbo_position.Text = dtRow["position_held_at_discharge"] != DBNull.Value ? (String)dtRow["position_held_at_discharge"] : String.Empty;
                txt_general_conduct.Text = dtRow["general_conduct"] != DBNull.Value ? (String)dtRow["general_conduct"] : String.Empty;

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

        private void chk_illness_CheckedChanged(object sender, EventArgs e)
        {
            txt_illness_name.Enabled = chk_illness.Checked == true ? true : false;
            if (chk_illness.Checked == false)
            {
                txt_illness_name.Clear();
            }
        }

        protected void GET_POSITIONS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_POSITIONS");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["position_name"] = String.Empty;
                dtRow["active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_position.DataSource = dt;
                cbo_position.ValueMember = "auto_id";
                cbo_position.DisplayMember = "position_name";
            }
        }

        private void cbo_bank_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_acc_no.Enabled = cbo_bank_name.Text != String.Empty ? true : false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Guard_Employment_Records.UPDATE_OTHER_GUARD_DETAILS_AND_OFFICIAL_DATA("UPDATE_OTHER_GUARD_DETAILS_AND_OFFICIAL_DATA", txt_guard_number.Text, chk_illness.Checked ? true : false, txt_illness_name.Text != String.Empty?txt_illness_name.Text:String.Empty, dt,
           chk_premonia.Checked ? true : false, chk_epilipsy.Checked ? true : false, chk_TB.Checked ? true : false, dt_employment_date.Value.Date, txt_recruitment_officer.Text != String.Empty?txt_recruitment_officer.Text:String.Empty, txt_salary.Text != String.Empty?txt_salary.Text:String.Empty,
           txt_nssf_no.Text , cbo_bank_name.Text, txt_acc_no.Text, cbo_position.Text, txt_general_conduct.Text);

            panel_details.Enabled = false;
        }

        private void dt_illness_date_ValueChanged(object sender, EventArgs e)
        {
            dt = dt_illness_date.Value.Date;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }

    }
}
