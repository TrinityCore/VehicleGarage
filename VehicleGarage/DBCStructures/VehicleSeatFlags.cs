using System;

namespace VehicleGarage.DBCStructures
{
    [Flags]
    public enum VehicleSeatFlags : uint
    {
        HasLowerAnimForEnter = 0x1,
        HasLowerAnimForRide = 0x2,
        Flag_0X4 = 0x4,
        ShouldUseVehicleSeatExitAnimationOnVoluntaryExit = 0x8,
        Flag_0X10 = 0x10,
        Flag_0X20 = 0x20,
        Flag_0X40 = 0x40,
        Flag_0X80 = 0x80,
        Flag_0X100 = 0x100,
        HidePassenger = 0x200,                                      // Passenger is hidden
        AllowsTurning = 0x400,                                      // needed for CGCamera__SyncFreeLookFacing
        CanControl = 0x800,                                         // Lua_UnitInVehicleControlSeat
        UnControlled = 0x2000,                                      // can override !& VEHICLE_SEAT_FLAG_CAN_ENTER_OR_EXIT
        CanAttack = 0x4000,                                         // Can attack, cast spells and use items from vehicle?
        ShouldUseVehicleSeatExitAnimationOnForcedExit = 0x8000,
        Flag_0X10000 = 0x10000,
        Flag_0X20000 = 0x20000,
        /// <summary>
        /// The next two may be switched - Phazerz
        /// </summary>
        HasVehicleExitAnimForVoluntaryExit = 0x40000,
        HasVehicleExitAnimForForcedExit = 0x80000,
        PassengerNotSelectable = 0x100000,
        Flag_0X200000 = 0x200000,
        RecHasVehicleEnterAnim = 0x400000,
        IsUsingVehicleControls = 0x800000,
        EnableVehicleZoom = 0x1000000,
        CanEnterOrExit = 0x2000000,                                 // Lua_CanExitVehicle - can enter and exit at free will
        CanSwitchFromSeat = 0x4000000,                              // Lua_CanSwitchVehicleSeats
        HasStartWaitingForVehicleTransitionAnimEnter = 0x8000000,
        HasStartWaitingForVehicleTransitionAnimExit = 0x10000000,
        HasVehicleUI = 0x20000000,                                  // Lua_UnitHasVehicleUI
        Flag_0X40000000 = 0x40000000,
        AllowsInteraction = 0x80000000
    }
}
