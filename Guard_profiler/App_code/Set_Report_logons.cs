using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Guard_profiler.App_code
{
   static class Set_Report_logons
    {
        //set connection string 
        static string SQLConnection = System.Configuration.ConfigurationManager.ConnectionStrings["sg_conn_str"].ToString();
        static SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(SQLConnection);

        public static void SetTableLogin(CrystalDecisions.CrystalReports.Engine.Table table)
        {
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = table.LogOnInfo;

            tliCurrent.ConnectionInfo.UserID = builder.UserID;
            tliCurrent.ConnectionInfo.Password = builder.Password;
            if (builder.InitialCatalog != null)
                tliCurrent.ConnectionInfo.DatabaseName = builder.InitialCatalog; 
            if (builder.DataSource != null)
                tliCurrent.ConnectionInfo.ServerName = builder.DataSource;
            table.ApplyLogOnInfo(tliCurrent);
        }
    }
}
