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
    public partial class frm_manage_client_locations : Form
    {
        public frm_manage_client_locations()
        {
            InitializeComponent();
        }

        private void frm_manage_client_locations_Load(object sender, EventArgs e)
        {
            txt_client_code.Text = SystemConst._client_code;
            txt_client_name.Text = SystemConst._client_name;

            Return_client_location_list();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txt_location.Text == String.Empty)
            {
                MessageBox.Show("Missing client name", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_record_guid.Text == String.Empty)
                {
                    Clients.Save_client_location_details("save_client_location_details", Convert.ToInt32(SystemConst._client_id), txt_location.Text);
                    MessageBox.Show("New Location for " + txt_client_name.Text + " has been added", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Return_client_location_list();
                }
                else
                {
                    Clients.Update_client_location_name("update_client_location_name", txt_record_guid.Text, txt_location.Text);
                    MessageBox.Show("Location details for " + txt_client_name.Text + " has been updated", "Client Locations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Return_client_location_list();
                }
            }
        }

        protected void Return_client_location_list()
        {
            DataTable dt = Clients.Return_client_details("return_client_location_list", Convert.ToInt32(SystemConst._client_id));
            if (dt.Rows.Count > 0)
            {
                gdv_client_locations.DataSource = dt;
                gdv_client_locations.Columns["record_guid"].Visible = false;
                gdv_client_locations.Columns["client_id"].Visible = false;

                gdv_client_locations.RowsDefaultCellStyle.BackColor = Color.LightGray;
                gdv_client_locations.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

                // Set the row and column header styles.
                gdv_client_locations.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                gdv_client_locations.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                gdv_client_locations.RowHeadersDefaultCellStyle.BackColor = Color.Black;

                // Set the selection background color for all the cells.
                gdv_client_locations.DefaultCellStyle.SelectionBackColor = Color.Brown;
                gdv_client_locations.DefaultCellStyle.SelectionForeColor = Color.Black;

                foreach (DataGridViewColumn c in gdv_client_locations.Columns)
                {
                    c.DefaultCellStyle.Font = new Font("Arial", 12.5F, GraphicsUnit.Pixel);
                }

                //set the background color of the header row
                gdv_client_locations.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
                gdv_client_locations.EnableHeadersVisualStyles = false;
            }
        }

        private void gdv_client_locations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdv_client_locations.Rows.Count > 0)
            {
                string record_guid = gdv_client_locations.CurrentRow.Cells[0].Value.ToString();
                string location_name = gdv_client_locations.CurrentRow.Cells[2].Value.ToString();
                
                txt_location.Text = location_name;
                txt_record_guid.Text = record_guid;

                txt_location.ReadOnly = true;
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txt_location.Clear();
            txt_location.ReadOnly = false;
            txt_record_guid.Clear();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txt_location.ReadOnly = false;
            
        }
    }
}
