using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Guard_profiler.App_code
{
    static class Guard_deployment
    {
        static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());

        //save new guard deployment record
        public static void Save_new_deployment_record(string QueryName, DateTime deploy_start_date, DateTime deploy_end_date, string created_by, string guard_number, DateTime deploy_date,
            string deploy_type,string branch_name,string client_code,string client_location,string guard_name,string firearm_serial,int number_of_ammunitions,string shift_type,bool is_leave_day_for_guard,
            bool is_public_holiday)
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = QueryName;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@created_by", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@created_by"].Value = created_by;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar,50);
                    cmd.Parameters["@guard_number"].Value = guard_number;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_date"].Value = deploy_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_type", SqlDbType.NVarChar,50);
                    cmd.Parameters["@deploy_type"].Value = deploy_type;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@branch_name"].Value = branch_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@client_code"].Value = client_code;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_location", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_location"].Value = client_location;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@guard_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@guard_name"].Value = guard_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@firearm_serial", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@firearm_serial"].Value = firearm_serial;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@number_of_ammunitions", SqlDbType.Int);
                    cmd.Parameters["@number_of_ammunitions"].Value = number_of_ammunitions;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@shift_type", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@shift_type"].Value = shift_type;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@is_leave_day_for_guard", SqlDbType.Bit);
                    cmd.Parameters["@is_leave_day_for_guard"].Value = is_leave_day_for_guard;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@is_public_holiday", SqlDbType.Bit);
                    cmd.Parameters["@is_public_holiday"].Value = is_public_holiday;

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

        public static DataTable Return_guard_shift_types(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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

        //return deployments for current deployment period
        public static DataTable Return_list_of_deployments_by_deploy_id(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
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
    }
}
