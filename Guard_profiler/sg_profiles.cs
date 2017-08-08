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
    public partial class sg_profiles : Form
    {
        public sg_profiles()
        {
            InitializeComponent();
        }

        protected void SAVE_GUARD_DETAILS()
        {
            if (txt_sg_f_name.Text == String.Empty || txt_sg_l_name.Text == String.Empty || cbo_guard_status.Text == String.Empty)
            {
                MessageBox.Show("Fields Marked red are mandatory");
            }
            else if (txt_guard_number_complete.Text == String.Empty) { MessageBox.Show("Guard Number cannot never be empty"); }
            else
            {
                try
                {
                    sg_Profiles.SAVE_NEW_SG_PROFILE("SAVE_NEW_SG_PROFILE",txt_guard_number_complete.Text, txt_sg_f_name.Text,txt_sg_l_name.Text,
            txt_sg_phone.Text, cbo_branch.Text, cbo_position.Text, cbo_dept.Text, dt_registration_date.Value.Date, txt_place_of_birth.Text, dt_birthdate.Value.Date,
            Convert.ToInt32(txt_age.Text), cbo_gender.Text, cbo_home_district.Text, txt_home_county.Text, txt_home_subcounty.Text, txt_home_parish.Text, txt_home_village.Text,
            cbo_religion.Text, cbo_marital_status.Text, txt_partners_name.Text, cbo_current_residence_district.Text, txt_c_subcounty.Text, txt_c_parish.Text,
            txt_c_zone.Text, txt_c_landlord.Text, txt_f_name.Text, cbo_f_district.Text, txt_f_county.Text, txt_f_village.Text,
            txt_f_zone.Text, txt_e_name.Text, txt_e_adress.Text, txt_departure_reason.Text, txt_tin_number.Text, txt_salary.Text,
            dtHire_date.Value.Date, txt_i_name.Text, txt_i_award.Text, dt_i_from.Value.Date, dt_i_to.Value.Date, txt_i_referees.Text,cbo_guard_status.Text,cbo_bank_name.Text,txt_account_number.Text,txt_nssf_number.Text);
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                

                MessageBox.Show("Successfully created SG Profile");

                GET_GUARD_LIST();
            }
        }

        protected void UPDATE_GUARD_DETAILS(string record_guid) 
        {
            if (txt_sg_f_name.Text == String.Empty || txt_sg_l_name.Text == String.Empty || cbo_guard_status.Text == String.Empty)
            {
                MessageBox.Show("Fields Marked red are mandatory");
            }
            else
            {
                if (cbo_guard_status.Text == "Deserted" || cbo_guard_status.Text == "Died" || cbo_guard_status.Text == "Dismissed" || cbo_guard_status.Text == "Resigned" || cbo_guard_status.Text == "Retired" || cbo_guard_status.Text == "Terminated" || cbo_guard_status.Text == "Confined")
                {
                    DialogResult dialogResult = MessageBox.Show("Setting guard status to " + cbo_guard_status.Text + " Will automatically archieve his/her details and will be removed from active guards.This cannot be undone.proceed??", "Change Guard Status", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //first update the guard status details
                        try
                        {
                            sg_Profiles.UPDATE_GUARD_DETAILS("UPDATE_GUARD_DETAILS", record_guid, txt_sg_f_name.Text, txt_sg_l_name.Text,
                    txt_sg_phone.Text, cbo_branch.Text, cbo_position.Text, cbo_dept.Text, dt_registration_date.Value.Date, txt_place_of_birth.Text, dt_birthdate.Value.Date,
                    Convert.ToInt32(txt_age.Text), cbo_gender.Text, cbo_home_district.Text, txt_home_county.Text, txt_home_subcounty.Text, txt_home_parish.Text, txt_home_village.Text,
                    cbo_religion.Text, cbo_marital_status.Text, txt_partners_name.Text, cbo_current_residence_district.Text, txt_c_subcounty.Text, txt_c_parish.Text,
                    txt_c_zone.Text, txt_c_landlord.Text, txt_f_name.Text, cbo_f_district.Text, txt_f_county.Text, txt_f_village.Text,
                    txt_f_zone.Text, txt_e_name.Text, txt_e_adress.Text, txt_departure_reason.Text, txt_tin_number.Text, txt_salary.Text,
                    dtHire_date.Value.Date, txt_i_name.Text, txt_i_award.Text, dt_i_from.Value.Date, dt_i_to.Value.Date, txt_i_referees.Text, cbo_guard_status.Text
                    ,cbo_bank_name.Text,txt_account_number.Text,txt_nssf_number.Text);

                            //Archieve the details of the guard
                            ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        this.Visible = true;
                    }
                }
                else
                {
                    try
                    {
                        sg_Profiles.UPDATE_GUARD_DETAILS("UPDATE_GUARD_DETAILS", record_guid, txt_sg_f_name.Text, txt_sg_l_name.Text,
                        txt_sg_phone.Text, cbo_branch.Text, cbo_position.Text, cbo_dept.Text, dt_registration_date.Value.Date, txt_place_of_birth.Text, dt_birthdate.Value.Date,
                        Convert.ToInt32(txt_age.Text), cbo_gender.Text, cbo_home_district.Text, txt_home_county.Text, txt_home_subcounty.Text, txt_home_parish.Text, txt_home_village.Text,
                        cbo_religion.Text, cbo_marital_status.Text, txt_partners_name.Text, cbo_current_residence_district.Text, txt_c_subcounty.Text, txt_c_parish.Text,
                        txt_c_zone.Text, txt_c_landlord.Text, txt_f_name.Text, cbo_f_district.Text, txt_f_county.Text, txt_f_village.Text,
                        txt_f_zone.Text, txt_e_name.Text, txt_e_adress.Text, txt_departure_reason.Text, txt_tin_number.Text, txt_salary.Text,
                        dtHire_date.Value.Date, txt_i_name.Text, txt_i_award.Text, dt_i_from.Value.Date, dt_i_to.Value.Date, txt_i_referees.Text, cbo_guard_status.Text
                        ,cbo_bank_name.Text,txt_account_number.Text,txt_nssf_number.Text);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }


                    MessageBox.Show("Successfully updated SG Profile");
                }
               
            }
        }

        private void sg_profiles_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            GET_GUARD_LIST();

            GET_BRANCHES();
            GET_DEPARTMENTS();
            GET_POSITIONS();
            GET_BRANCHES_SEARCH();

            cbo_marital_status_SelectedIndexChanged(cbo_marital_status, null);

            chk_add.Checked = true;
            chk_edit.Checked = false;
            cbo_bank_name.SelectedIndex = 0;
        }

        private void btn_e_save_Click(object sender, EventArgs e)
        {
            if (txt_guid.Text == String.Empty)
            {
                int guard_number_exists = sg_Profiles.CHECK_IF_GUARD_NUMBER_IS_ASSIGNED("CHECK_IF_GUARD_NUMBER_IS_ASSIGNED",txt_guard_number_complete.Text);
                if (guard_number_exists > 0)
                {
                    MessageBox.Show("The guard number you have selected already belongs to an active guard in " + cbo_branch.Text + " Branch.Use the guard number assignment screen to free up this number");
                }
                else
                {
                    SAVE_GUARD_DETAILS();
                }
                
            }
            else
            {
                UPDATE_GUARD_DETAILS(txt_guid.Text);
            }
           
        }

        protected void GET_GUARD_LIST()
        {
            try
            {
                DataTable dt = App_code.sg_Profiles.RETURN_OFFICER_LIST("SELECT_GUARD_LISTS");
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "NAME";
                    gdv_guards.Columns[2].HeaderText = "BRANCH";
                    gdv_guards.Columns[3].HeaderText = "DEPARTMENT";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void GET_GUARD_DETAILS(string Query,string record_guid)
        {
            DataTable dt = sg_Profiles.RETURN_GUARD_DETAILS(Query,record_guid);
            if (dt != null && dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];

                txt_sg_f_name.Text = dtRow["f_name"] != DBNull.Value ? (String)dtRow["f_name"] : String.Empty;
                txt_sg_l_name.Text = dtRow["l_name"] != DBNull.Value ? (String)dtRow["l_name"] : String.Empty;
                txt_sg_phone.Text = dtRow["phone"] != DBNull.Value ? (String)dtRow["phone"] : String.Empty;
                cbo_branch.Text = dtRow["branch"] != DBNull.Value ? (String)dtRow["branch"] : String.Empty;
                cbo_position.Text = dtRow["position"] != DBNull.Value ? (String)dtRow["position"] : String.Empty;
                cbo_dept.Text = dtRow["department"] != DBNull.Value ? (String)dtRow["department"] : String.Empty;
                dt_registration_date.Value = dtRow["registered_date"] != DBNull.Value? Convert.ToDateTime(dtRow["registered_date"]):DateTime.Today;
                txt_place_of_birth.Text = dtRow["birth_place"] != DBNull.Value ? (String)dtRow["birth_place"] : String.Empty;
                dt_birthdate.Value = dtRow["dob"] != DBNull.Value? Convert.ToDateTime(dtRow["dob"]):DateTime.Today;
                txt_age.Text = dtRow["age"] != DBNull.Value ? Convert.ToInt32(dtRow["age"]).ToString() : String.Empty;
                cbo_gender.Text = dtRow["gender"] != DBNull.Value ? (String)dtRow["gender"] : String.Empty;
                cbo_home_district.Text = dtRow["home_district"] != DBNull.Value ? (String)dtRow["home_district"] : String.Empty;
                cbo_religion.Text = dtRow["religion"] != DBNull.Value ? (String)dtRow["religion"] : String.Empty;
                txt_home_county.Text = dtRow["home_county"] != DBNull.Value ? (String)dtRow["home_county"] : String.Empty;
                cbo_marital_status.Text = dtRow["marital_status"] != DBNull.Value ? (String)dtRow["marital_status"] : String.Empty;
                txt_home_subcounty.Text = dtRow["home_sub_county"] != DBNull.Value ? (String)dtRow["home_sub_county"] : String.Empty;
                txt_partners_name.Text = dtRow["partners_name"] != DBNull.Value ? (String)dtRow["partners_name"] : String.Empty;
                txt_home_parish.Text = dtRow["home_parish"] != DBNull.Value ? (String)dtRow["home_parish"] : String.Empty;
                txt_home_village.Text = dtRow["home_village_lc1"] != DBNull.Value ? (String)dtRow["home_village_lc1"] : String.Empty;
                cbo_current_residence_district.Text = dtRow["current_residence_district"] != DBNull.Value ? (String)dtRow["current_residence_district"] : String.Empty;
                txt_c_subcounty.Text = dtRow["current_residence_sub_county"] != DBNull.Value ? (String)dtRow["current_residence_sub_county"] : String.Empty;
                txt_c_parish.Text = dtRow["current_residence_parish"] != DBNull.Value ? (String)dtRow["current_residence_parish"] : String.Empty;
                txt_c_zone.Text = dtRow["current_residence_zone"] != DBNull.Value ? (String)dtRow["current_residence_zone"] : String.Empty;
                txt_c_landlord.Text = dtRow["current_landlord_name"] != DBNull.Value ? (String)dtRow["current_landlord_name"] : String.Empty;
                txt_f_name.Text = dtRow["father_name"] != DBNull.Value ? (String)dtRow["father_name"] : String.Empty;
                cbo_f_district.Text = dtRow["father_district"] != DBNull.Value ? (String)dtRow["father_district"] : String.Empty;
                txt_f_county.Text = dtRow["father_county"] != DBNull.Value ? (String)dtRow["father_county"] : String.Empty;
                txt_f_village.Text = dtRow["father_village"] != DBNull.Value ? (String)dtRow["father_village"] : String.Empty;
                txt_f_zone.Text = dtRow["father_zone"] != DBNull.Value ? (String)dtRow["father_zone"] : String.Empty;
                txt_e_name.Text = dtRow["prev_employer_name"] != DBNull.Value ? (String)dtRow["prev_employer_name"] : String.Empty;
                txt_e_adress.Text = dtRow["prev_employer_address"] != DBNull.Value ? (String)dtRow["prev_employer_address"] : String.Empty;
                txt_departure_reason.Text = dtRow["cause_of_departure"] != DBNull.Value ? (String)dtRow["cause_of_departure"] : String.Empty;
                txt_tin_number.Text = dtRow["tin_number"] != DBNull.Value ? (String)dtRow["tin_number"] : String.Empty;
                txt_salary.Text = dtRow["previous_salary"] != DBNull.Value ? (String)dtRow["previous_salary"] : String.Empty;
                dtHire_date.Value = dtRow["start_date"] != DBNull.Value? Convert.ToDateTime(dtRow["start_date"]):DateTime.Today;
                chk_hiredate.Checked = true;
                txt_i_name.Text = dtRow["institution_name"] != DBNull.Value ? (String)dtRow["institution_name"] : String.Empty;
                txt_i_award.Text = dtRow["award_name"] != DBNull.Value ? (String)dtRow["award_name"] : String.Empty;
                dt_i_from.Value = dtRow["study_start_date"] != DBNull.Value? Convert.ToDateTime(dtRow["study_start_date"]):DateTime.Today;
                dt_i_to.Value = dtRow["study_end_date"] != DBNull.Value? Convert.ToDateTime(dtRow["study_end_date"]):DateTime.Today;
                chk_i_from.Checked = true;
                chk_i_to.Checked = true;
                txt_i_referees.Text = dtRow["refferees"] != DBNull.Value ? (String)dtRow["refferees"] : String.Empty;
                cbo_guard_status.Text = dtRow["guard_status"] != DBNull.Value ? (String)dtRow["guard_status"] : String.Empty;
                txt_guard_number.Text = (String)dtRow["guard_number"];
                txt_guard_number_complete.Text = (String)dtRow["guard_number"];
                //cbo_bank_name.Text = dtRow["bank_name"] != DBNull.Value ? (String)dtRow["bank_name"] : String.Empty;
                txt_account_number.Text = dtRow["account_number"] != DBNull.Value ? (String)dtRow["account_number"] : String.Empty;
                txt_nssf_number.Text = dtRow["nssf_number"] != DBNull.Value ? (String)dtRow["nssf_number"] : String.Empty;

                cbo_marital_status_SelectedIndexChanged(cbo_marital_status, null);
            }
        }

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_guards.Rows.Count != 0)
            {
                string record_guid = gdv_guards.CurrentRow.Cells[0].Value.ToString();
                txt_guid.Text = record_guid;
                GET_GUARD_DETAILS("SELECT_GUARD_DETAILS", record_guid);

                GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", record_guid);

                contents_panel.Enabled = false;
                tab_container.Enabled = false;
                groupBox2.Enabled = false;
                panel_guard_status.Enabled = false;
            }
        }

        private void btn_e_edit_Click(object sender, EventArgs e)
        {
            if (txt_guard_number_complete.Text != String.Empty)
            {
                contents_panel.Enabled = true;
                tab_container.Enabled = true;
                groupBox2.Enabled = true;
                panel_guard_status.Enabled = true;
                txt_guard_number_static_code.ReadOnly = true;

                chk_edit.Checked = true;
                chk_add.Checked = false;
            }
            else { 
                
            }
            
        }

        protected void CLEAR_FEILDS()
        {
            txt_sg_f_name.Clear();
            txt_sg_l_name.Clear();
            txt_sg_phone.Clear();
            cbo_branch.Text = String.Empty;
            cbo_position.Text = String.Empty;
            cbo_dept.Text = String.Empty;
            dt_registration_date.Value = DateTime.Today;
            txt_place_of_birth.Clear();
            dt_birthdate.Value = DateTime.Today;
            txt_age.Clear();
            cbo_gender.Text = String.Empty;
            cbo_home_district.Text = String.Empty;
            cbo_religion.Text = String.Empty;
            txt_home_county.Clear();
            cbo_marital_status.Text = String.Empty;
            txt_home_subcounty.Clear();
            txt_partners_name.Clear();
            txt_home_parish.Clear();
            txt_home_village.Clear();
            cbo_current_residence_district.Text = String.Empty;
            txt_c_subcounty.Clear();
            txt_c_parish.Clear();
            txt_c_zone.Clear();
            txt_c_landlord.Clear();
            txt_f_name.Clear();
            cbo_f_district.Text = String.Empty;
            txt_f_county.Clear();
            txt_f_village.Clear();
            txt_f_zone.Clear();
            txt_e_name.Clear();
            txt_e_adress.Clear();
            txt_departure_reason.Clear();
            txt_tin_number.Clear();
            txt_salary.Clear();
            dtHire_date.Value = DateTime.Today;
            txt_i_name.Clear();
            txt_i_award.Clear();
            dt_i_from.Value = DateTime.Today;
            dt_i_to.Value = DateTime.Today;
            txt_i_referees.Clear();
            txt_guid.Clear();
            txt_guard_number.Clear();
            txt_guard_number_complete.Clear();
            txt_guard_number_static_code.ReadOnly = false;
            txt_account_number.Clear();
            txt_nssf_number.Clear();

            contents_panel.Enabled = true;
            tab_container.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btn_e_new_Click(object sender, EventArgs e)
        {
            CLEAR_FEILDS();
            chk_add.Checked = true;
            chk_edit.Checked = false;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an Officer to upload an image");
            }
            else
            {

                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_sg_f_name.Text + " " + txt_sg_l_name.Text;
                SystemConst.record_guid = txt_guid.Text;

                frmImages imageUpload = new frmImages();
                imageUpload.ShowDialog();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
            frm_sg_list_report report = new frm_sg_list_report();
            report.ShowDialog();
        }

        private void btnReport_single_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an officer to view report");
            }
            else {
                string guard_number = txt_guard_number.Text;
                SystemConst.guard_number = guard_number;
                SystemConst._Single_report_type = "Active";

                frmcrystal_report_single report = new frmcrystal_report_single();
                report.ShowDialog();
            }
        }

        private void dt_birthdate_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dt_birthdate.Value.Date.Year;
            txt_age.Text = age.ToString();
        }

        protected void GET_BRANCHES()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = String.Empty;
                dtRow["active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_branch.DataSource = dt;
                cbo_branch.DisplayMember = "branch";
                cbo_branch.ValueMember = "branch_code";

            }
        }

        protected void GET_DEPARTMENTS()
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_DEPARTMENTS");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["department_name"] = String.Empty;
                dtRow["department_active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_dept.DataSource = dt;
                cbo_dept.ValueMember = "auto_id";
                cbo_dept.DisplayMember = "department_name";

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

        protected void GET_BRANCHES_SEARCH()  //FOR THE SEARCH COMBO
        {
            DataTable dt = System_lookups.SELECT_LOOKUP_VALUES("SELECT_BRANCHES");
            if (dt != null)
            {
                DataRow dtRow = dt.NewRow();
                dtRow["record_guid"] = String.Empty;
                dtRow["auto_id"] = -1;
                dtRow["branch"] = String.Empty;
                dtRow["active"] = true;

                dt.Rows.InsertAt(dtRow, 0);
                cbo_branch_search.DataSource = dt;
                cbo_branch_search.DisplayMember = "branch";
                cbo_branch_search.ValueMember = "auto_id";

            }
        }

        private void btn_name_search_Click(object sender, EventArgs e)
        {
            if (txt_name_search.Text != String.Empty)
            {
                DataTable dt = sg_Profiles.RETURN_SEARCH_RESULTS("RETURN_SEARCH_RESULTS", txt_name_search.Text);
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "NAME";
                    gdv_guards.Columns[2].HeaderText = "BRANCH";
                    gdv_guards.Columns[3].HeaderText = "DEPARTMENT";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            else
            {
                GET_GUARD_LIST();
            }
        }

        private void btn_branch_search_Click(object sender, EventArgs e)
        {
            if (cbo_branch_search.Text != String.Empty)
            {
                DataTable dt = sg_Profiles.SEARCH_GUARDS_BY_BRANCH("SEARCH_GUARDS_BY_BRANCH", cbo_branch_search.Text);
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;

                    gdv_guards.Columns[1].HeaderText = "NAME";
                    gdv_guards.Columns[2].HeaderText = "BRANCH";
                    gdv_guards.Columns[3].HeaderText = "DEPARTMENT";

                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;

                    gdv_guards.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    gdv_guards.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                    // Set the row and column header styles.
                    gdv_guards.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    gdv_guards.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                    gdv_guards.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                    // Set the selection background color for all the cells.
                    gdv_guards.DefaultCellStyle.SelectionBackColor = Color.White;
                    gdv_guards.DefaultCellStyle.SelectionForeColor = Color.Black;
                }
            }
            else
            {
                GET_GUARD_LIST();
            }
        }

        private void cbo_guard_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_guard_status.Text != String.Empty && cbo_guard_status.Text != "Active")
            {
                this.BackColor = Color.Red;
            }
            else {
                //this.BackColor = ColorConverter(255, 192, 128);
            }
        }

        private void cbo_marital_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_partners_name.Enabled = cbo_marital_status.Text != String.Empty && cbo_marital_status.Text != "Single" ? true : false;
            if (cbo_marital_status.Text == "Single")
            {
                txt_partners_name.Clear();
            }
        }

        private void cbo_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_branch.Text != String.Empty)
            {
                txt_guard_number_auto_code.Text = cbo_branch.SelectedValue.ToString();
            }
            else {
                txt_guard_number_auto_code.Clear();
            }
        }

        private void txt_guard_number_static_code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_guard_number_auto_code.Text == String.Empty){

                MessageBox.Show("Chose Guard Branch first");
                txt_guard_number_auto_code.Clear();
            }
        }

        private void txt_guard_number_static_code_TextAlignChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_guard_number_static_code_TextChanged(object sender, EventArgs e)
        {
            if (txt_guard_number_auto_code.Text != String.Empty && txt_guard_number_static_code.Text != String.Empty)
            {
                txt_guard_number_complete.Text = txt_guard_number_auto_code.Text + "" + txt_guard_number_static_code.Text;
            }
            else {
                txt_guard_number_complete.Clear();
            }
        }

        private void btn_large_photo_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an Officer to upload an image");
            }
            else
            {

                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_sg_f_name.Text + " " + txt_sg_l_name.Text;
                SystemConst.record_guid = txt_guid.Text;

                frm_officer_img_large imageUpload = new frm_officer_img_large();
                imageUpload.ShowDialog();
            }  
        }

        private void btn_large_img_rpt_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an officer to view report");
            }
            else
            {
                string guard_number = txt_guard_number.Text;
                SystemConst.guard_number = guard_number;

                frm_officer_large_img_report report = new frm_officer_large_img_report();
                report.ShowDialog();
            }
        }

        protected void ARCHIEVE_AND_UN_ASSIGN_NUMBER_FROM_GUARD()
        {
            sg_Profiles.UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS("UN_ASSIGN_GUARD_NUMBER_AND_ARCHIVE_GUARD_DETAILS", txt_guid.Text);
            MessageBox.Show("All guard details have been successfully archieved,you can access them from the archived guards module");
        }

        private void btn_edit_guard_number_Click(object sender, EventArgs e)
        {
            if (txt_guard_number_complete.Text == String.Empty || txt_guid.Text == String.Empty)
            {
                MessageBox.Show("No guard selected");
            }
            else
            {
                SystemConst._branch_name = cbo_branch.Text;
                SystemConst.guard_number = txt_guard_number_complete.Text;
                SystemConst.record_guid = txt_guid.Text;
                frm_pre_login login = new frm_pre_login();
                login.ShowDialog();
            }
            
        }

        private void txt_account_number_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbo_bank_name.Text == String.Empty)
            {
                MessageBox.Show("Bank name required", "Account Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_account_number.Clear();
            }
        }
    }
}
