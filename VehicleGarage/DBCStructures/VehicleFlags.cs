
namespace VehicleGarage.DBCStructures
{
    public enum VehicleFlags
    {
        NoStrafe = 0x1,             // Sets MOVEFLAG2_NO_STRAFE
        NoJump = 0x2,               // Sets MOVEFLAG2_NO_JUMPING
        FullSpeedTurning = 0x4,     // Sets MOVEFLAG2_FULLSPEEDTURNING
        Unk1 = 0x8,
        AllowPitching = 0x10,       // Sets MOVEFLAG2_ALLOW_PITCHING
        FullSpeedPitching = 0x20,   // Sets MOVEFLAG2_FULLSPEEDPITCHING
        CustomPitch = 0x40,         // If set use pitchMin and pitchMax from DBC, otherwise pitchMin = -pi/2, pitchMax = pi/2 
        Unk2 = 0x80,
        Unk3 = 0x100,
        Unk4 = 0x200,
        AdjustAimAngle = 0x400,     // Lua_IsVehicleAimAngleAdjustable
        AdjustAimPower = 0x800,     // Lua_IsVehicleAimPowerAdjustable
        Unk5 = 0x1000,
    }
}
