using System;

namespace VehicleGarage.DBCStructures
{
    [Flags]
    public enum VehicleFlags
    {
        NoStrafe = 0x1,             // Sets MOVEFLAG2_NO_STRAFE
        NoJump = 0x2,               // Sets MOVEFLAG2_NO_JUMPING
        FullSpeedTurning = 0x4,     // Sets MOVEFLAG2_FULLSPEEDTURNING
        Flag_0X8 = 0x8,
        AllowPitching = 0x10,       // Sets MOVEFLAG2_ALLOW_PITCHING
        FullSpeedPitching = 0x20,   // Sets MOVEFLAG2_FULLSPEEDPITCHING
        CustomPitch = 0x40,         // If set use pitchMin and pitchMax from DBC, otherwise pitchMin = -pi/2, pitchMax = pi/2 
        Flag_0X80 = 0x80,
        Flag_0X100 = 0x100,
        Flag_0X200 = 0x200,
        AdjustAimAngle = 0x400,     // Lua_IsVehicleAimAngleAdjustable
        AdjustAimPower = 0x800,     // Lua_IsVehicleAimPowerAdjustable
        Flag_0X1000 = 0x1000,
        Flag_0X2000 = 0x2000,
        Flag_0X4000 = 0x4000,
        Flag_0X8000 = 0x8000,
        Flag_0X10000 = 0x10000,
        Flag_0X20000 = 0x20000,
        Flag_0X40000 = 0x40000,
        Flag_0X80000 = 0x80000,
        Flag_0X100000 = 0x100000,
        Flag_0X200000 = 0x200000,
        Flag_0X400000 = 0x400000,
        Flag_0X800000 = 0x800000,
        Flag_0X1000000 = 0x1000000,
        Flag_0X2000000 = 0x2000000,
        Flag_0X4000000 = 0x4000000,
        Flag_0X8000000 = 0x8000000,
        Flag_0X10000000 = 0x10000000,
        Flag_0X20000000 = 0x20000000,
        Flag_0X40000000 = 0x40000000,
    }
}
