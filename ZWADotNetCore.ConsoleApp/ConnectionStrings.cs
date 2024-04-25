using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWADotNetCore.ConsoleApp
{
    internal static class ConnectionStrings
    {
        public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = ".", //server name
            InitialCatalog = "ZWADotNetCore", //database name
            UserID = "sa",
            Password = "sa@123"
        };
    }
}
