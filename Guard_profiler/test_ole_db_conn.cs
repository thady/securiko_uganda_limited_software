using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Guard_profiler
{
    public partial class test_ole_db_conn : Form
    {
        public test_ole_db_conn()
        {
            InitializeComponent();
        }

        private void test_ole_db_conn_Load(object sender, EventArgs e)
        {

        }

        protected void get_conn()
        {
            string connetionString = null;
            DataTable dt = new DataTable();
            string sqlcmd = "SELECT LabNo FROM Specimens WHERE SerNo = 21730";
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter Adapt;
            cmd.CommandText = sqlcmd;
            OleDbConnection cnn;
            connetionString =  "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=M:\\LIMS\\HRL2013.mdb;";
            cnn = new OleDbConnection(connetionString);
            try
            {
                cnn.Open();
                cmd.Connection = cnn;
                Adapt = new OleDbDataAdapter(cmd);
                Adapt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    DataRow dtRow = dt.Rows[0];
                    int labno = Convert.ToInt32(dtRow["LabNo"]);
                    MessageBox.Show(labno.ToString());
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Can not open connection ! ");
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            get_conn();
        }
    }
}
