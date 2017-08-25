using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
    static class Clients
    {
        static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());
        static SqlCommand cmd;

        public static void Save_new_client_details(string QueryName, string client_code,string client_name,string client_adress,float client_rate,bool client_active)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = QueryName;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@client_code"].Value = client_code;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_name"].Value = client_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_adress", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_adress"].Value = client_adress;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_rate", SqlDbType.Float);
                    cmd.Parameters["@client_rate"].Value = client_rate;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_active", SqlDbType.Bit);
                    cmd.Parameters["@client_active"].Value = client_active;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
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
                if (conn != null) { }
            }
        }

        public static void Update_client_details(string QueryName, string client_code, string client_name, string client_adress, float client_rate, bool client_active,int client_id)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = QueryName;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@client_code"].Value = client_code;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_name"].Value = client_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_adress", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_adress"].Value = client_adress;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_rate", SqlDbType.Float);
                    cmd.Parameters["@client_rate"].Value = client_rate;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_active", SqlDbType.Bit);
                    cmd.Parameters["@client_active"].Value = client_active;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_id", SqlDbType.Int);
                    cmd.Parameters["@client_id"].Value = client_id;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
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
                if (conn != null) { }
            }
        }

        //return list of clients
        public static DataTable Return_list_of_clients(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

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

        //return client details
        public static DataTable Return_client_details(string myQuery,int client_id)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_id", SqlDbType.Int);
                    cmd.Parameters["@client_id"].Value = client_id;

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

        //return client location list by client code
        public static DataTable Return_client_location_list(string myQuery, string client_code)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_code", SqlDbType.NVarChar,50);
                    cmd.Parameters["@client_code"].Value = client_code;

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

        //save client location details
        public static void Save_client_location_details(string QueryName, int client_id, string location_name)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = QueryName;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_id", SqlDbType.Int);
                    cmd.Parameters["@client_id"].Value = client_id;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@location_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@location_name"].Value = location_name;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
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
                if (conn != null) { }
            }
        }

        //update client location details
        public static void Update_client_location_name(string QueryName, string record_guid, string location_name)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_Customers", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = QueryName;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar,100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@location_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@location_name"].Value = location_name;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    cmd.ExecuteNonQuery();
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
                if (conn != null) { }
            }
        }
    }
}
