using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.DBCStores;

namespace VehicleGarage
{
    public static class Loader
    {
        static Loader()
        {
            // Load up DBC files here

            DBC.Locale = DetectedLocale;
        }

        private static LocalesDBC DetectedLocale
        {
            get
            {
                byte locale = 0;
                // TODO: Detect locale based on strings
                return (LocalesDBC)locale;
            }
        }
    }
}
