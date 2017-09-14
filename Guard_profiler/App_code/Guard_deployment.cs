﻿using System;
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
            bool is_public_holiday,bool is_weekend)
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

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@is_weekend", SqlDbType.Bit);
                    cmd.Parameters["@is_weekend"].Value = is_weekend;

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

        //update guard deployment record
        public static void Update_guard_deployment_record(string QueryName,string record_guid, string client_code, string client_location, string firearm_serial, int number_of_ammunitions, string shift_type, bool is_leave_day_for_guard)
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
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_code", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@client_code"].Value = client_code;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@client_location", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@client_location"].Value = client_location;


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

        //return active deployment period
        public static DataTable Select_active_deployment_period(string myQuery)
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

        //return guards for batch deployment
        public static DataTable select_list_of_guards_by_branch_and_date_for_batch_deployment(string myQuery,string branch_name)
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
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 200);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@branch_name"].Value = branch_name;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    Adapt = new SqlDataAdapter(cmd);
                    Adapt.Fill(dt);

                    int count = dt.Rows.Count;

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

        //return guards for selected deploy date
        public static DataTable select_list_of_guards_by_branch_and_date_for_selected_date(string myQuery, string branch_name,DateTime deploy_date)
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
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 200);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 50);
                    cmd.Parameters["@branch_name"].Value = branch_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_date"].Value = deploy_date;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    Adapt = new SqlDataAdapter(cmd);
                    Adapt.Fill(dt);

                    int count = dt.Rows.Count;

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

        //return list of guards for additional deployment data entry
        public static DataTable select_list_of_guards_for_additional_deployment_data_entry(string myQuery,string branch_name,DateTime deploy_start_date,DateTime deploy_end_date)
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
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@branch_name", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@branch_name"].Value = branch_name;

                    //cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 50);
                    //cmd.Parameters["@guard_number"].Value = guard_number;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_end_date"].Value = deploy_end_date;

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

        //save or update guard additional deployment details
        public static void Save_update_guard_additional_deployment_data(string QueryName, string guard_number, DateTime deploy_start_date, int guard_auto_id, int days_worked,int over_time_days_worked,int days_absent,float total_advance_in_month,
         float total_arrears_in_month, float special_cash_additions,float residential_cost,float uniform_costs,float local_service_tax_cost,float other_penalties_cost,float other_refunds)
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
                    cmd.Parameters.Add("@guard_number", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@guard_number"].Value = guard_number;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_start_date"].Value = deploy_start_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@guard_auto_id", SqlDbType.Int);
                    cmd.Parameters["@guard_auto_id"].Value = guard_auto_id;


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@days_worked", SqlDbType.Int);
                    cmd.Parameters["@days_worked"].Value = days_worked;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@over_time_days_worked", SqlDbType.Int);
                    cmd.Parameters["@over_time_days_worked"].Value = over_time_days_worked;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@days_absent", SqlDbType.Int);
                    cmd.Parameters["@days_absent"].Value = days_absent;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@total_advance_in_month", SqlDbType.Float);
                    cmd.Parameters["@total_advance_in_month"].Value = total_advance_in_month;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@total_arrears_in_month", SqlDbType.Float);
                    cmd.Parameters["@total_arrears_in_month"].Value = total_arrears_in_month;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@special_cash_additions", SqlDbType.Float);
                    cmd.Parameters["@special_cash_additions"].Value = special_cash_additions;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@residential_cost", SqlDbType.Float);
                    cmd.Parameters["@residential_cost"].Value = residential_cost;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@uniform_costs", SqlDbType.Float);
                    cmd.Parameters["@uniform_costs"].Value = uniform_costs;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@local_service_tax_cost", SqlDbType.Float);
                    cmd.Parameters["@local_service_tax_cost"].Value = local_service_tax_cost;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@other_penalties_cost", SqlDbType.Float);
                    cmd.Parameters["@other_penalties_cost"].Value = other_penalties_cost;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@other_refunds", SqlDbType.Float);
                    cmd.Parameters["@other_refunds"].Value = other_refunds;


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

        //delete absent guard from deployment list of a given date
        public static void delete_guard_marked_as_absent_from_deployment_list_per_date(string QueryName, string record_guid)
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
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

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

        #region functions to control deployment period setups
        //save new deployment period
        public static void Save_new_deployment_period(string QueryName, DateTime deploy_start_date,DateTime deploy_end_date,bool active_deployment)
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
                    cmd.Parameters.Add("@active_deployment", SqlDbType.Bit);
                    cmd.Parameters["@active_deployment"].Value = active_deployment;

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

        //set active deployment
        public static void Set_active_deployment(string QueryName, int deploy_id,bool active_deployment)
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
                    cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
                    cmd.Parameters["@deploy_id"].Value = deploy_id;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@active_deployment", SqlDbType.Bit);
                    cmd.Parameters["@active_deployment"].Value = active_deployment;

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

        //Return list of deployment periods
        public static DataTable Return_list_of_deployment_periods(string myQuery)
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
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
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

        //check if deployment period already exists
        public static int check_if_deployment_period_already_exists(string myQuery,DateTime dt_start_date,DateTime dt_end_date)
        {
            DataTable dt = new DataTable();
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_start_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_start_date"].Value = dt_start_date;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_end_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_end_date"].Value = dt_end_date;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    count = (int)cmd.ExecuteScalar();

                    //Adapt = new SqlDataAdapter(cmd);
                    //Adapt.Fill(dt);
                    //count = dt.Rows.Count;

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
            return count;
        }
        #endregion

        #region functions to control public holidays management
        //return list of public holidays

        public static DataTable return_list_of_public_holidays(string myQuery)
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
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
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

        //save new public holiday
        public static void save_new_public_holiday(string QueryName, int deployment_period_id, string public_holiday_name, DateTime public_holiday_date)
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
                    cmd.Parameters.Add("@deploy_id", SqlDbType.Int);
                    cmd.Parameters["@deploy_id"].Value = deployment_period_id;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@public_holiday_name", SqlDbType.NVarChar,100);
                    cmd.Parameters["@public_holiday_name"].Value = public_holiday_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@public_holiday_date", SqlDbType.Date);
                    cmd.Parameters["@public_holiday_date"].Value = public_holiday_date;

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

        //update public holiday details
        public static void update_public_holiday_details(string QueryName,string record_guid, string public_holiday_name, DateTime public_holiday_date)
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
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar,100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@public_holiday_name", SqlDbType.NVarChar,100);
                    cmd.Parameters["@public_holiday_name"].Value = public_holiday_name;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@public_holiday_date", SqlDbType.Date);
                    cmd.Parameters["@public_holiday_date"].Value = public_holiday_date;

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

        //delete public holiday
        public static void delete_public_holiday(string QueryName,string record_guid)
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
                    cmd.Parameters.Add("@record_guid", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@record_guid"].Value = record_guid;

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

        //check if date is a public holiday
        public static int check_if_deployment_date_is_public_holiday(string myQuery, DateTime deploy_date)
        {
            DataTable dt = new DataTable();
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString()))
                using (SqlCommand cmd = new SqlCommand("sp_guard_deployment_summary", conn))
                {
                    cmd.CommandTimeout = 3600;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@QueryName", SqlDbType.NVarChar, 100);
                    cmd.Parameters["@QueryName"].Value = myQuery;

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@deploy_date", SqlDbType.Date);
                    cmd.Parameters["@deploy_date"].Value = deploy_date;

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd.Connection = conn;
                    count = (int)cmd.ExecuteScalar();

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
            return count;
        }
        #endregion
    }


}



