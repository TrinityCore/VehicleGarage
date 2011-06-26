using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.DBCStructures;
using VehicleGarage.Properties;

namespace VehicleGarage.DBCStores
{
    public static class DBC
    {
        public const int ClientVersion = 12340;
        public const int MaxDBCLocale = 16;

        public static string DBCPath
        {
            get { return Settings.Default.DBCPath; }
        }

        /// <summary>
        /// The actual in-memory storage of the loaded DBC files. Loaded in Loader()
        /// </summary>
        public static Dictionary<uint, VehicleEntry> Vehicle;
        public static Dictionary<uint, VehicleSeatEntry> VehicleSeat;
        public static Dictionary<uint, VehicleUIIndicatorEntry> VehicleUIIndicator;
        public static Dictionary<uint, VehicleUIIndSeatEntry> VehicleUIIndSeat;

        public static Dictionary<uint, string> VehicleStrings = new Dictionary<uint, string>();
    }

}
