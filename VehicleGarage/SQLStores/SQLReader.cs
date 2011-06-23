using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using VehicleGarage.Properties;
using VehicleGarage.SQLStructures;

namespace VehicleGarage.SQLStores
{
    public static class SQLReader
    {
        public static unsafe List<T> ReadSQL<T>() where T : class
        {
            var sessionFactory = SQLConnection.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                return (List<T>) session.CreateCriteria(typeof (T)).List<T>();
            }
        }
    }
}
