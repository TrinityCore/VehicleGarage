using System;

namespace VehicleGarage
{
    public enum Constants : uint
    {
        MaxVehicleSeats = 8,
        MaxCreatureSpells = 8,
    }

    [Flags]
    public enum NPCFlags : uint
    {
        Spellclick = 0x1000000,
    }
}
