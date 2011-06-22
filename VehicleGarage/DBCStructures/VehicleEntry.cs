using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VehicleGarage.DBCStructures
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VehicleEntry
    {
        public uint Id;
        public uint Flags;
        public float TurnSpeed;
        public float PitchSpeed;
        public float PitchMin;
        public float PitchMax;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)Constants.MaxVehicleSeats)]
        public uint[] SeatId;
        public float MouseLookOffsetPitch;
        public float CameraFadeDistScalarMin;
        public float CameraFadeDistScalarMax;
        public float PitchOffset;
        public float FacingLimitRight;
        public float FacingLimitLeft;
        public float MissleTargetTurnLingering;
        public float MissleTargetPitchLingering;
        public float MissleTargetMouseLingering;
        public float MissleTargetEndOpacity;
        public float MissleTargetArcSpeed;
        public float MissleTargetArcRepeat;
        public float MissleTargetArcWidth;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public float[] MissleTargetImpactRadius;
        public string MissleTargetArcTexture;
        public string MissleTargetImpactTexture;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public string[] MissleTargetImpactModel;
        public float CameraYawOffset;
        public int LocomotionType;
        public float MissleTargetImpactTexRadius;
        public int SeatIndicatorType;
        public int PowerType;
        public int Unk1;        // New in 3.1 - Either -1 or 0 (most common)
        public int Unk2;        // New in 3.1 - Always 0
    }
}
