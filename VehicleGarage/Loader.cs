using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.DBCStores;
using VehicleGarage.DBCStructures;

namespace VehicleGarage
{
    public static class Loader
    {
        static Loader()
        {
            DBC.Vehicle = DBCReader.ReadDBC<VehicleEntry>(null);
            DBC.VehicleSeat = DBCReader.ReadDBC<VehicleSeatEntry>(null);
            DBC.VehicleUIIndicator = DBCReader.ReadDBC<VehicleUIIndicatorEntry>(null);
            DBC.VehicleUIIndSeat = DBCReader.ReadDBC<VehicleUIIndSeatEntry>(null);

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
