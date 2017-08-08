using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
    static class HeadShotEngine
    {
        static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());

        public static void INSERT_OR_UPDATE_IMAGE(
           string myQuery,
           string record_guid, 
           byte[] imageBinary
           )
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@image_data", SqlDbType.VarBinary);
                    cmd.Parameters["@image_data"].Value = imageBinary;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    int count = cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static DataTable SELECT_OFFICER_HEAD_SHOT(string myQuery, string record_guid)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@record_guid"].Value = record_guid;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    Adapt = new SqlDataAdapter(cmd);
                    Adapt.Fill(dt);

                    cmd.Parameters.Clear();

                    if (conn.State != ConnectionState.Closed)
                    {
                        conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return dt;
        }
    }
}
