using System;
using System.Diagnostics.Contracts;
using VehicleGarage.SQLStores;
using VehicleGarage.DBCStores;
using VehicleGarage.DBCStructures;

namespace VehicleGarage
{
    public class Loader
    {
        public Loader()
        {
            Contract.Requires(DBC.DBCPath != null);

            DBC.Vehicle = DBCReader.ReadDBC<VehicleEntry>(DBC.VehicleStrings);
            DBC.VehicleSeat = DBCReader.ReadDBC<VehicleSeatEntry>(null);
            DBC.VehicleUIIndicator = DBCReader.ReadDBC<VehicleUIIndicatorEntry>(null);
            DBC.VehicleUIIndSeat = DBCReader.ReadDBC<VehicleUIIndSeatEntry>(null);

            try
            {
                SQLReader.Connect();
                SQL.CreatureTemplate = SQLReader.LoadCreatureTemplates();
                SQL.SpellClick = SQLReader.LoadSpellClick();
                SQL.Accessories = SQLReader.LoadVehicleAccessories();
            }
            finally
            {
                SQLReader.Disconnect();
            }
        }
    }
}
