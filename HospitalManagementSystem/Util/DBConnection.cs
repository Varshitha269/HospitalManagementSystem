using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Util
{
    //internal class DBConnection
    //{
    //}
    public static class DBConnection
    {
        private static IConfiguration _iconfiguration;


        public static string GetConnectionString()
        {
            return _iconfiguration.GetConnectionString("LocalConnectionString");
        }


        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("dataConnection.json");
            _iconfiguration = builder.Build();

        }

        static DBConnection()

        {
            GetAppSettingsFile();
        }
    }
}
