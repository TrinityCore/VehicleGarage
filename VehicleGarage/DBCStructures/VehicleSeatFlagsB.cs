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
        Flag_0X200 = 0x200,
        Flag_0X400 = 0x400,
        Flag_0X800 = 0x800,
        Flag_0X1000 = 0x1000,
        Flag_0X2000 = 0x2000,
        Flag_0X4000 = 0x4000,
        Flag_0X8000 = 0x8000,
        Flag_0X10000 = 0x10000,
        KeepPet = 0x20000,
        Flag_0X40000 = 0x40000,
        Flag_0X80000 = 0x80000,
        Flag_0X100000 = 0x100000,
        Flag_0X200000 = 0x200000,
        Flag_0X400000 = 0x400000,
        Flag_0X800000 = 0x800000,
        Flag_0X1000000 = 0x1000000,
        UseableForced4 = 0x2000000,
        CanSwitch = 0x4000000,
        Flag_0X8000000 = 0x8000000,
        Flag_0X10000000 = 0x10000000,
        Flag_0X20000000 = 0x20000000,
        Flag_0X40000000 = 0x40000000,
        VehiclePlayerFrameUI = 0x80000000,
    }
}
