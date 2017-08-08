using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
    class Salary_scales
    {
        static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());

        public static void save_or_update_salary_scale_guards(string myQuery,string scale_name,int minimum_year_count,int maximum_year_count,float salary_amount,string record_guid)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@scale_name", SqlDbType.NVarChar,100);
                    cmd.Parameters["@scale_name"].Value = scale_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@minimum_year_count", SqlDbType.Int);
                    cmd.Parameters["@minimum_year_count"].Value = minimum_year_count;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maximum_year_count", SqlDbType.Int);
                    cmd.Parameters["@maximum_year_count"].Value = maximum_year_count;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@salary_amount", SqlDbType.Float);
                    cmd.Parameters["@salary_amount"].Value = salary_amount;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar,100);
                    cmd.Parameters["@record_guid"].Value = record_guid;


                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //Return list of salary scales
        public static DataTable return_salary_scales(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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

        //Return all active guards with number of years served
        public static DataTable return_number_of_years_served_for_each_gaurd(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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

        //auto assign scale to guard
        public static void auto_assign_salary_scale_to_guard(string myQuery, int years_served, int guard_auto_id, string guard_number)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@years_served", SqlDbType.Int);
                    cmd.Parameters["@years_served"].Value = years_served;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
                    cmd.Parameters["@guard_auto_id"].Value = guard_auto_id;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar,50);
                    cmd.Parameters["@guard_number"].Value = guard_number;


                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
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
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //return list of guard salary mappings
        public static DataTable return_guard_salary_mappings(string myQuery)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_salary_scales", conn))
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
