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

namespace Guard_profiler
{
    public partial class frm_manage_clients : Form
    {
        public frm_manage_clients()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Save_client_details();
            
        }

        protected void Save_client_details()
        {
            if (txt_client_code.Text == String.Empty || txt_client_name.Text == String.Empty)
            {
                MessageBox.Show("Client Code & name cannot be empty", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_record_guid.Text == String.Empty)
                {
                    Clients.Save_new_client_details("save_new_client_details", txt_client_code.Text, txt_client_name.Text, txt_adress.Text, txt_client_rate.Text != String.Empty ? float.Parse(txt_client_rate.Text) : 0, chk_client_active.Checked == true ? true : false);
                    MessageBox.Show("New Client details successfully saved", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Return_list_of_clients();
                }
                else
                {
                    Clients.Update_client_details("update_client_details", txt_client_code.Text, txt_client_name.Text, txt_adress.Text, txt_client_rate.Text != String.Empty ? float.Parse(txt_client_rate.Text) : 0, chk_client_active.Checked == true ? true : false,Convert.ToInt32(txt_client_id.Text));
                    MessageBox.Show("New Client details successfully updated", "Clients", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Return_list_of_clients();
                }
            }
        }

        protected void Return_list_of_clients()
        {
            DataTable dt = Clients.Return_list_of_clients("return_list_of_clients");
            if (dt.Rows.Count > 0)
            {
                gdv_clients.DataSource = dt;

                gdv_clients.Columns["record_guid"].Visible = false;
                gdv_clients.Columns["client_id"].Visible = false;
                gdv_clients.Columns["client_code"].Visible = false;

                gdv_clients.Columns["client_name"].Width = 150;

                gdv_clients.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_clients.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_clients.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_clients.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_clients.DefaultCellStyle.SelectionBackColor = Color.Brown;
                gdv_clients.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_clients.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_clients.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_clients.EnableHeadersVisualStyles = false;
            }
        }

        private void frm_manage_clients_Load(object sender, EventArgs e)
        {
            Return_list_of_clients();
        }

        private void gdv_clients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_clients.Rows.Count > 0)
            {
                int client_id = Convert.ToInt32(gdv_clients.CurrentRow.Cells[1].Value.ToString());
                //set the static value of client_id in syscontants class
                SystemConst._client_id = client_id.ToString();

               DataTable dt =  Clients.Return_client_details("return_client_details", client_id);
                if (dt.Rows.Count > 0)
                {
                    DataRow dtRow = dt.Rows[0];
                    txt_adress.Text = dtRow["client_adress"].ToString();
                    txt_client_code.Text = dtRow["client_code"].ToString();
                    txt_client_name.Text = dtRow["client_name"].ToString();
                    txt_client_rate.Text = float.Parse(dtRow["client_rate"].ToString()) == 0 ? String.Empty : float.Parse(dtRow["client_rate"].ToString()).ToString();
                    chk_client_active.Checked = Convert.ToBoolean(dtRow["client_active"]) == true ? true : false;
                    txt_record_guid.Text = dtRow["record_guid"].ToString();
                    txt_client_id.Text = Convert.ToInt32(dtRow["client_id"].ToString()).ToString();

                    panel_details.Enabled = false;
                }
               
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_adress.Clear();
            txt_client_code.Clear();
            txt_client_name.Clear();
            txt_client_rate.Clear();
            chk_client_active.Checked = true;
            txt_record_guid.Clear();
            txt_client_id.Clear();

            panel_details.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel_details.Enabled = true;
        }

        private void btn_locations_Click(object sender, EventArgs e)
        {
            if (txt_record_guid.Text == String.Empty)
            {
                MessageBox.Show("Please select a client", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SystemConst._client_name = txt_client_name.Text;
                SystemConst._client_code = txt_client_code.Text;

                frm_manage_client_locations locations = new frm_manage_client_locations();
                locations.ShowDialog();
            } 
        }
    }
}
