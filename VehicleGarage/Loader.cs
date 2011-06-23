using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleGarage.DBCStores;
using VehicleGarage.DBCStructures;

namespace VehicleGarage
{
    public class Loader
    {
        public Loader()
        {
            DBC.Vehicle = DBCReader.ReadDBC<VehicleEntry>(null);
            DBC.VehicleSeat = DBCReader.ReadDBC<VehicleSeatEntry>(null);
            DBC.VehicleUIIndicator = DBCReader.ReadDBC<VehicleUIIndicatorEntry>(null);
            DBC.VehicleUIIndSeat = DBCReader.ReadDBC<VehicleUIIndSeatEntry>(null);
        }
    }
}
