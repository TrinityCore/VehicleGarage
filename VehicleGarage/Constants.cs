using System;

namespace VehicleGarage
{
    enum Constants : uint
    {
        MaxVehicleSeats = 8,
        MaxCreatureSpells = 8,
    }

    [Flags]
    enum NPCFlags : uint
    {
        Spellclick = 0x1000000,
    }
}
