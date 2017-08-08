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
    public partial class update_first_last_names : Form
    {
        public update_first_last_names()
        {
            InitializeComponent();
        }

        private void update_first_last_names_Load(object sender, EventArgs e)
        {
            DataTable dt = sg_Profiles.SELECT_GUARD_F_L_NAMES("SELECT_GUARD_F_L_NAMES");
            gdv_guards.DataSource = dt;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gdv_guards.Rows.Count-1;i++ ) {
                int auto_id = Convert.ToInt32( gdv_guards.Rows[i].Cells[0].Value.ToString());
                this.Cursor = Cursors.AppStarting;
                sg_Profiles.UPDATE_GUARD_FIRST_LAST_NAME("UPDATE_GUARD_FIRST_LAST_NAME", auto_id, gdv_guards.Rows[i].Cells[1].Value.ToString(), gdv_guards.Rows[i].Cells[2].Value.ToString());
                this.Cursor = Cursors.Default;
            }
        }

        protected void UPDATE_GUARD_IMAGES() {
            string guard_number = String.Empty;
            byte[] data = null;

            DataTable dt = sg_Profiles.SELECT_GUARD_F_L_NAMES("SELECT_IMAGES_IMPORTED_FROM_ACCESS");
            foreach(DataRow dtRow in dt.Rows){
                if (dtRow["photo"] != DBNull.Value)
                {
                    data = (Byte[])dtRow["photo"];
                }

                if (dtRow["guard_num"] != DBNull.Value)
                {
                   guard_number = (String)dtRow["guard_num"];
                }

                if (guard_number != String.Empty && dtRow["photo"] != DBNull.Value)
                {
                    sg_Profiles.UPDATE_IMAGES_FROM_ACCESS( 
                       "UPDATE_IMAGES_FROM_ACCESS",
                        guard_number,
                        data
                       );
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            UPDATE_GUARD_IMAGES();
            this.Cursor = Cursors.Default;
        }
    }
}
