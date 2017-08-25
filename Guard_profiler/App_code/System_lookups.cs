using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
   static class System_lookups
    {
       static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());

       public static void NEW_LOOKUP_DETAILS( 
           string myQuery,
           string lookup_name,
           bool lookup_active,
           string lookup_code
           )
       {
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_system_lookups", conn))
               {
                   cmd.CommandTimeout = 3600;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@QueryName"].Value = myQuery;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_name", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@lookup_name"].Value = lookup_name;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_active", SqlDbType.Bit);
                   cmd.Parameters["@lookup_active"].Value = lookup_active;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_code", SqlDbType.NVarChar, 50);
                   cmd.Parameters["@lookup_code"].Value = lookup_code;

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

       public static void UPDATE_LOOKUP_DETAILS( 
          string myQuery,
          string lookup_name,
          bool lookup_active,
          int lookup_id,
          string lookup_code
          )
       {
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_system_lookups", conn))
               {
                   cmd.CommandTimeout = 3600;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@QueryName"].Value = myQuery;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_name", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@lookup_name"].Value = lookup_name;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_active", SqlDbType.Bit);
                   cmd.Parameters["@lookup_active"].Value = lookup_active;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_id", SqlDbType.Int);
                   cmd.Parameters["@lookup_id"].Value = lookup_id;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@lookup_code", SqlDbType.NVarChar,50);
                   cmd.Parameters["@lookup_code"].Value = lookup_code;

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


       //function below returns lookup values as datatable
       public static DataTable SELECT_LOOKUP_VALUES(string myQuery) 
       {
           DataTable dt = new DataTable();
           SqlDataAdapter Adapt;
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_system_lookups", conn))
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

        //Return active guards by branch
        public static DataTable SELECT_LIST_OF_ACTIVE_GUARDS_BY_BRANCH(string myQuery,string branch_name)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adapt;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_system_lookups", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@branch"].Value = branch_name;

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
