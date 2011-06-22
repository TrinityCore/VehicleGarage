using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.Properties;

namespace VehicleGarage.DBCStores
{
    public enum LocalesDBC
    {
        enUS,
        koKR,
        frFR,
        deDE,
        zhCN,
        zhTW,
        esES,
        esMX,
        ruRU
    };

    public static class DBC
    {
        public const int ClientVersion = 12340;
        public const int MaxDBCLocale = 16;

        public static string DBCPath
        {
            get { return "@" + Settings.Default.DBCPath; }
        }

        public static LocalesDBC Locale { get; set; }
    }
}
