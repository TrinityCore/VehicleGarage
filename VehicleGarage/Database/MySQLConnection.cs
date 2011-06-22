using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.Properties;
using MySql.Data.MySqlClient;

namespace VehicleGarage.Database
{
    public static class MySQLConnection
    {
        private static MySqlConnection _conn;
        private static MySqlCommand _command;

        public static bool Connected { get; private set; }

        private static String ConnectionString
        {
            get
            {
                return String.Format("Server={0};Port={1};Uid={2};Pwd={3};Database={4};character set=utf8;Connection Timeout=10",
                    Settings.Default.Host,
                    Settings.Default.Port,
                    Settings.Default.User,
                    Settings.Default.Pass,
                    Settings.Default.WorldDB);
            }
        }
    }
}
