using System;
using System.Collections.Generic;
using System.Text;
using VehicleGarage.SQLStores;
using VehicleGarage.DBCStores;
using VehicleGarage.DBCStructures;
using VehicleGarage.SQLStructures;

namespace VehicleGarage
{
    public class Loader
    {
        public Loader()
        {
            DBC.Vehicle = DBCReader.ReadDBC<VehicleEntry>(DBC.VehicleStrings);
            DBC.VehicleSeat = DBCReader.ReadDBC<VehicleSeatEntry>(null);
            DBC.VehicleUIIndicator = DBCReader.ReadDBC<VehicleUIIndicatorEntry>(null);
            DBC.VehicleUIIndSeat = DBCReader.ReadDBC<VehicleUIIndSeatEntry>(null);

            SQL.CreatureTemplate = SQLReader.LoadCreatureTemplates();
        }
    }
}
