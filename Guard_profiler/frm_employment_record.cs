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
    public partial class frm_employment_record : Form
    {
        public frm_employment_record()
        {
            InitializeComponent();
        }

        private void frm_employment_record_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            GET_GUARD_LIST();
            GET_BRANCHES();
        }

        protected void GET_GUARD_LIST()
        {
            try
            {
                DataTable dt = App_code.sg_Profiles.RETURN_OFFICER_LIST("SELECT_GUARD_LIST_FOR_EMPLOYMENT_RECORDS_FORM");
                if (dt != null)
                {
                    gdv_guards.DataSource = dt;
                    gdv_guards.Columns[0].Visible = false;
                    gdv_guards.Columns[1].Visible = false;

                    gdv_guards.Columns[2].HeaderText = "NAME";
                    gdv_guards.Columns[3].HeaderText = "BRANCH";
                    gdv_guards.Columns[4].HeaderText = "DEPARTMENT";

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

        private void gdv_guards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_guards.Rows.Count != 0)
            {
                string record_guid = gdv_guards.CurrentRow.Cells[0].Value.ToString();
                string guard_number = gdv_guards.CurrentRow.Cells[1].Value.ToString();

                SystemConst.record_guid = record_guid; ///set static record_guid to be used by child forms to retrieve officer image

                RETURN_GUARD_DETAILS(guard_number);

                GET_OFFICER_HEADSHOT("SELECT_OFFICER_HEAD_SHOT", record_guid);
            }
        }

        private void btn_present_adress_Click(object sender, EventArgs e)
        {
            if(txt_guard_number.Text == String.Empty){
                MessageBox.Show("Please select a guard from the list");
            }
            else{
                SystemConst.OfficerID = txt_guard_number.Text; 
            SystemConst.OfficerName = txt_name.Text;

            frm_current_residential_adress adress = new frm_current_residential_adress();
            adress.ShowDialog();
            }
            
        }

        private void btn_origin_adress_Click(object sender, EventArgs e)
        {
            if(txt_guard_number.Text == String.Empty){
                MessageBox.Show("Please select a guard from the list");
            }
            else{
               SystemConst.OfficerID = txt_guard_number.Text;
            SystemConst.OfficerName = txt_name.Text;

            frm_home_adress_of_origin adress = new frm_home_adress_of_origin();
            adress.ShowDialog();
            }
        }

        private void btn_children_Click(object sender, EventArgs e)
        {
             if(txt_guard_number.Text == String.Empty){
                 MessageBox.Show("Please select a guard from the list");
            }
            else{
            SystemConst.OfficerID = txt_guard_number.Text;
            SystemConst.OfficerName = txt_name.Text;

            frm_children child = new frm_children();
            child.ShowDialog();
            }
            
        }

        private void btn_father_details_Click(object sender, EventArgs e)
        {
            if(txt_guard_number.Text == String.Empty){
                MessageBox.Show("Please select a guard from the list");
            }
            else{
            SystemConst.OfficerID = txt_guard_number.Text;
            SystemConst.OfficerName = txt_name.Text;

            frm_father_details father = new frm_father_details();
            father.ShowDialog();
            }
        }

        private void btn_relatives_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Please select a guard from the list");
            }
            else
            {
                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_name.Text;

                frm_relatives relatives = new frm_relatives();
                relatives.ShowDialog();
            } 
        }

        private void btn_prev_employer_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Please select a guard from the list");
            }
            else
            {
                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_name.Text;

                frm_prev_employer empl = new frm_prev_employer();
                empl.ShowDialog();
            }
           
        }

        private void btn_refferees_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Please select a guard from the list");
            }
            else
            {
                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_name.Text;

                frm_referees refere = new frm_referees();
                refere.ShowDialog();
            }
           
        }

        protected void RETURN_GUARD_DETAILS(string guard_number)
        {
            DataTable dt = Guard_Employment_Records.SELECT_OFFICER_DETAILS("SELECT_OFFICER_DETAILS", guard_number);
            if (dt.Rows.Count != 0)
            {
                DataRow dtRow = dt.Rows[0];

                txt_guard_number.Text = dtRow["guard_number"] != DBNull.Value ? (String)dtRow["guard_number"] : String.Empty;
                txt_name.Text = dtRow["full_name"] != DBNull.Value ? (String)dtRow["full_name"] : String.Empty;
                cbo_religion.Text = dtRow["religion"] != DBNull.Value ? (String)dtRow["religion"] : String.Empty;
                cbo_gender.Text = dtRow["gender"] != DBNull.Value ? (String)dtRow["gender"] : String.Empty;
                dt_birthdate.Value = dtRow["dob"] != DBNull.Value? Convert.ToDateTime(dtRow["dob"]):DateTime.Today;
                txt_birth_place.Text = dtRow["birth_place"] != DBNull.Value ? (String)dtRow["birth_place"] : String.Empty;
                cbo_nationality.Text = dtRow["nationality"] != DBNull.Value ? (String)dtRow["nationality"] : String.Empty;
                cbo_tribe.Text = dtRow["tribe"] != DBNull.Value ? (String)dtRow["tribe"] : String.Empty;
                txt_phone_primary.Text = dtRow["phone_primary"] != DBNull.Value ? (String)dtRow["phone_primary"] : String.Empty;
                txt_phone_secondary.Text = dtRow["phone_secondary"] != DBNull.Value ? (String)dtRow["phone_secondary"] : String.Empty;
                txt_national_id_number.Text = dtRow["national_id"] != DBNull.Value ? (String)dtRow["national_id"] : String.Empty;
                txt_partner_birth_place.Text = dtRow["partner_birth_place"] != DBNull.Value ? (String)dtRow["partner_birth_place"] : String.Empty;
                txt_partner_parents_names.Text = dtRow["partner_parents_names"] != DBNull.Value ? (String)dtRow["partner_parents_names"] : String.Empty;
                txt_partners_residential_adres.Text = dtRow["partner_parents_resident_adress"] != DBNull.Value ? (String)dtRow["partner_parents_resident_adress"] : String.Empty;
                txt_partner_phone.Text = dtRow["partner_contact"] != DBNull.Value ? (String)dtRow["partner_contact"] : String.Empty;
                txt_record_guid.Text = dtRow["record_guid"] != DBNull.Value ? (String)dtRow["record_guid"] : String.Empty;

                cbo_marital_status.Text = dtRow["marital_status"] != DBNull.Value ? (String)dtRow["marital_status"] : String.Empty;
                txt_partner_name.Text = dtRow["partners_name"] != DBNull.Value ? (String)dtRow["partners_name"] : String.Empty;

                panel_details.Enabled = false;
            }
        }

        private void btn_education_history_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Please select a guard from the list");
            }
            else
            {
                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_name.Text;

                frm_education_history edu = new frm_education_history();
                edu.ShowDialog();
            } 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Please select a guard from the list");
            }
            else
            {
                SystemConst.OfficerID = txt_guard_number.Text;
                SystemConst.OfficerName = txt_name.Text;

                frm_other_info info = new frm_other_info();
                info.ShowDialog();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Guard_Employment_Records.UPDATE_OR_INSERT_GUARD_EMP_RECORD_HEADER("UPDATE_OR_INSERT_GUARD_EMP_RECORD_HEADER", txt_guard_number.Text, cbo_nationality.Text, cbo_tribe.Text,
            txt_phone_primary.Text, txt_phone_secondary.Text, txt_national_id_number.Text, txt_partner_birth_place.Text, txt_partner_parents_names.Text,
             txt_partners_residential_adres.Text, txt_partner_phone.Text);
            MessageBox.Show("Guard profile has been updated");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }

        private void btntest_report_Click(object sender, EventArgs e)
        {
            if (txt_guard_number.Text == String.Empty)
            {
                MessageBox.Show("Select an officer to view report");
            }
            else
            {
                string guard_number = txt_guard_number.Text;
                SystemConst.guard_number = guard_number;

                frm_employment_record_report rpt = new frm_employment_record_report();
                rpt.Show();
            }
            
        }

        private void btn_name_search_Click(object sender, EventArgs e)
        {
            if (txt_name_search.Text != String.Empty)
            {
                DataTable dt = sg_Profiles.RETURN_SEARCH_RESULTS("RETURN_SEARCH_RESULTS_EMP_RECORD_BY_NAME", txt_name_search.Text);
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
                DataTable dt = sg_Profiles.SEARCH_GUARDS_BY_BRANCH("SEARCH_GUARDS_BY_BRANCH_EMP_RECORD_FORM", cbo_branch_search.Text);
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
                cbo_branch_search.DataSource = dt;
                cbo_branch_search.DisplayMember = "branch";
                cbo_branch_search.ValueMember = "branch_code";

            }
        }
    }
}
