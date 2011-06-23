using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using VehicleGarage.Properties;
using MySql.Data.MySqlClient;

namespace VehicleGarage.SQLStores
{
    public static class SQLConnection
    {
        public static ISessionFactory CreateSessionFactory()
        {
            try
            {
                return Fluently.Configure()
                    .Database(MySQLConfiguration
                                  .Standard
                                  .ConnectionString(cs => cs
                                                              .Server(Settings.Default.Host)
                                                              .Database(Settings.Default.WorldDB)
                                                              .Username(Settings.Default.User)
                                                              .Password(Settings.Default.Pass))
                    )
                    .Mappings(m =>
                              m.FluentMappings.AddFromAssemblyOf<Program>())

                    .BuildSessionFactory();
            }
            catch (FluentConfigurationException ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
