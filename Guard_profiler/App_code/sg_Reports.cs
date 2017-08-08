using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace Guard_profiler.App_code
{
   static class sg_Reports
    {
       static SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString());

       public static DataSet RETURN_OFFICER_DETAILS(string myQuery,string guard_number)
       {

           SqlDataAdapter Adapt;
           DataSet dsReport = new DataSet();
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
                   cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
                   cmd.Parameters["@guard_number"].Value = guard_number;

                   if (conn.State == ConnectionState.Closed)
                   {
                       conn.Open();
                   }
                   cmd.Connection = conn;
                   Adapt = new SqlDataAdapter(cmd);
                   Adapt.Fill(dsReport, "dt_set_sg_profile_single");
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
           return dsReport;
       }

       //function returns officer large image report
       public static DataSet SELECT_GUARD_LARGE_IMAGE_RPT(string myQuery, string guard_number) 
       {

           SqlDataAdapter Adapt;
           DataSet dsReport = new DataSet();
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_guard_large_image_report", conn))
               {
                   cmd.CommandTimeout = 3600;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 50);
                   cmd.Parameters["@QueryName"].Value = myQuery;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
                   cmd.Parameters["@guard_number"].Value = guard_number;

                   if (conn.State == ConnectionState.Closed)
                   {
                       conn.Open();
                   }
                   cmd.Connection = conn;
                   Adapt = new SqlDataAdapter(cmd);
                   Adapt.Fill(dsReport, "dt_set_sg_profile_single");
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
           return dsReport;
       }



       public static DataSet SELECT_GUARD_LIST(string myQuery)
       {

           SqlDataAdapter Adapt;
           DataSet dsReport = new DataSet();
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("Q_SG_PROFILES", conn))
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
                   Adapt.Fill(dsReport, "dt_set_sg_profile_single");
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
           return dsReport;
       }

       public static DataSet SELECT_ACTIVE_GUARDS_BY_STATION(string myQuery,string branch)
       {

           SqlDataAdapter Adapt;
           DataSet dsReport = new DataSet();
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_active_guards_report", conn))
               {
                   cmd.CommandTimeout = 3600;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@QueryName"].Value = myQuery;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 1000);
                   cmd.Parameters["@branch"].Value = branch;

                   if (conn.State == ConnectionState.Closed)
                   {
                       conn.Open();
                   }
                   cmd.Connection = conn;
                   Adapt = new SqlDataAdapter(cmd);
                   Adapt.Fill(dsReport, "dt_set_sg_list");
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
           return dsReport;
       }

       //function returns only kampala guards
       public static DataSet SELECT_ACTIVE_GUARDS_KAMPALA(string myQuery, string branch) 
       {

           SqlDataAdapter Adapt;
           DataSet dsReport = new DataSet();
           try
           {
               using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
               using (SqlCommand cmd = new SqlCommand("sp_active_kampala_guards_report", conn))
               {
                   cmd.CommandTimeout = 3600;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                   cmd.Parameters["@QueryName"].Value = myQuery;

                   cmd.CommandType = CommandType.StoredProcedure;
                   cmd.Parameters.Add("@branch", SqlDbType.NVarChar, 1000);
                   cmd.Parameters["@branch"].Value = branch;

                   if (conn.State == ConnectionState.Closed)
                   {
                       conn.Open();
                   }
                   cmd.Connection = conn;
                   Adapt = new SqlDataAdapter(cmd);
                   Adapt.Fill(dsReport, "dt_set_sg_list");
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
           return dsReport;
       }
    }
}
