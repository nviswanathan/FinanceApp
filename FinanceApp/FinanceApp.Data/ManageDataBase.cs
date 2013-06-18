using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace FinanceApp.Data
{
    public class ManageDataBase
    {
        public static void CreateTables() {
            try
            {
                string sqlConnectionString = "Data Source=(local);Initial Catalog=AdventureWorks;Integrated Security=True";
                var runpath = AppDomain.CurrentDomain.BaseDirectory;
                string file_name = runpath + "DBQuery.sql";
                FileInfo file = new FileInfo(file_name);
                string script = file.OpenText().ReadToEnd();
                SqlConnection conn = new SqlConnection(sqlConnectionString);
                Server server = new Server(new ServerConnection(conn));
                server.ConnectionContext.ExecuteNonQuery(script);
            }
            catch (Exception e) { }
        }
    }
}
