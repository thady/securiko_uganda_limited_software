﻿using System;
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
    public partial class frm_prev_employer : Form
    {
        public frm_prev_employer()
        {
            InitializeComponent();
        }

        private void frm_prev_employer_Load(object sender, EventArgs e)
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

                txt_employer_name.Text = dtRow["previous_employer_name"] != DBNull.Value ? (String)dtRow["previous_employer_name"] : String.Empty;
                txt_employer_adress.Text = dtRow["previous_employer_postal_adress"] != DBNull.Value ? (String)dtRow["previous_employer_postal_adress"] : String.Empty;
                cbo_departure_reason.Text = dtRow["cause_of_departure"] != DBNull.Value ? (String)dtRow["cause_of_departure"] : String.Empty;
                
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
            Guard_Employment_Records.UPDATE_GUARD_PREVIOUS_EMPLOYER_DETAILS("UPDATE_GUARD_PREVIOUS_EMPLOYER_DETAILS",txt_guard_number.Text,txt_employer_name.Text,txt_employer_adress.Text, //function updates father details...although arguments remain unchanged
            cbo_departure_reason.Text);

            RETURN_GUARD_DETAILS(txt_guard_number.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }
    }
}
