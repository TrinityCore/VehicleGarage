using System;

namespace VehicleGarage.DBCStructures
{
    [Flags]
    public enum VehicleSeatFlagsB : uint
    {
        Flag_0X1 = 0x1,
        UsableForced1 = 0x2,
        Flag_0X4 = 0x4,
        TargetsInRaidUI = 0x8,          // Lua_UnitTargetsVehicleInRaidUI
        Flag_0X10 = 0x10,
        Ejectable = 0x20,               // ejectable
        UsableForced2 = 0x40,
        Flag_0X80 = 0x80,
        UsableForced3 = 0x100,
    }
}
