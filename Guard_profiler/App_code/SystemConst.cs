﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guard_profiler.App_code
{
   static class SystemConst
    {
        public static string OfficerID = string.Empty;
        public static string OfficerName = string.Empty;
        public static string record_guid = String.Empty;
        public static string guard_number = String.Empty;
        public static string _branch = String.Empty;
        public static string _username = String.Empty;
        public static string _branch_name = String.Empty;
        public static string _Single_report_type = String.Empty;
        public static string _guard_status = String.Empty;
        public static string _Report_update_month = String.Empty;
        public static string _client_name = String.Empty;
        public static string _client_code = String.Empty;
        public static string _client_id = String.Empty;

        //deployment period static params
        public static string _active_deployment_id = String.Empty;
        public static DateTime _deployment_start_date = DateTime.Now;
        public static DateTime _deployment_end_date = DateTime.Now;

        //these static variables are for the module for editing a deployment record of a specific guard when the use choses edit
        public static string _client_codee = String.Empty;
        public static string _client_location = String.Empty;
        public static string _fire_arm_serial = String.Empty;
        public static int _ammunition_count = 0;
        public static string _shift_type = String.Empty;
        public static bool _is_leave_day_for_guard = false;
        public static bool _is_public_holiday = false;
        public static string _record_guid = String.Empty;
        public static string _guard_name = String.Empty;

        public static string GET_OfficerID()
        {
            return OfficerID;
        }

        public static string GET_OfficerName()
        {
            return OfficerName;
        }

        public static string GET_OfficerAutoID() 
        {
            return record_guid;
        }

        public static string Get_Record_Guid()
        {
            return record_guid;
        }

        public static string Get_officer_branch()
        {
            return _branch;
        }

        public static string Get_username()
        {
            return _username;
        }
    }
}
