using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleGarage.DBCStructures;
using VehicleGarage.Extensions;

namespace VehicleGarage.Info
{
    public class VehicleSeatInfo
    {
        private readonly RichTextBox _rtb;
        private VehicleSeatEntry _seat;

        public VehicleSeatInfo(RichTextBox rtb, VehicleSeatEntry seat)
        {
            _rtb = rtb;
            _seat = seat;
        }

        public void ViewSeatInfo()
        {
            _rtb.Clear();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Seat ID: {0}", _seat.Id);
            _rtb.SetDefaultStyle();

            _rtb.AppendFormatLine("Attachment ID: {0}", _seat.AttachmentId);
            _rtb.AppendFormatLine("Attachment Offset X: {0}", _seat.AttachmentOffsetX);
            _rtb.AppendFormatLine("Attachment Offset Y: {0}", _seat.AttachmentOffsetY);
            _rtb.AppendFormatLine("Attachment Offset Z: {0}", _seat.AttachmentOffsetZ);
            _rtb.AppendFormatLine("Enter Pre-delay: {0}", _seat.EnterPreDelay);
            _rtb.AppendFormatLine("Enter Speed: {0}", _seat.EnterSpeed);
            _rtb.AppendFormatLine("Enter Gravity: {0}", _seat.EnterGravity);
            _rtb.AppendFormatLine("Enter Duration Min: {0}", _seat.EnterMinDuration);
            _rtb.AppendFormatLine("Enter Duration Max: {0}", _seat.EnterMaxDuration);
            _rtb.AppendFormatLine("Enter Arc Height Min: {0}", _seat.EnterMinArcHeight);
            _rtb.AppendFormatLine("Enter Arc Height Max: {0}", _seat.EnterMaxArcHeight);
            _rtb.AppendFormatLine("Enter Animation Start: {0}", _seat.EnterAnimStart);
            _rtb.AppendFormatLine("Enter Animation Loop: {0}", _seat.EnterAnimLoop); 
            _rtb.AppendFormatLine("Ride Animation Start: {0}", _seat.RideAnimStart);
            _rtb.AppendFormatLine("Ride Animation Loop: {0}", _seat.RideAnimLoop);
            _rtb.AppendFormatLine("Ride Upper Animation Start: {0}", _seat.RideUpperAnimStart);
            _rtb.AppendFormatLine("Ride Upper Animation Loop: {0}", _seat.RideUpperAnimLoop);
            _rtb.AppendFormatLine("Exit Pre-delay: {0}", _seat.ExitPreDelay);
            _rtb.AppendFormatLine("Exit Gravity: {0}", _seat.ExitGravity);
            _rtb.AppendFormatLine("Exit Duration Min: {0}", _seat.ExitMinDuration);
            _rtb.AppendFormatLine("Exit Duration Max: {0}", _seat.ExitMaxDuration);
            _rtb.AppendFormatLine("Exit Arc Height Min: {0}", _seat.ExitMinArcHeight);
            _rtb.AppendFormatLine("Exit Arc height Max: {0}", _seat.ExitMaxArcHeight);
            _rtb.AppendFormatLine("Exit Animation Start: {0}", _seat.ExitAnimStart);
            _rtb.AppendFormatLine("Exit Animation Loop: {0}", _seat.ExitAnimLoop);
            _rtb.AppendFormatLine("Exit Animation End: {0}", _seat.ExitAnimEnd);
            _rtb.AppendFormatLine("Passenger Yaw: {0}", _seat.PassengerYaw);
            _rtb.AppendFormatLine("Passenger Pitch: {0}", _seat.PassengerPitch);
            _rtb.AppendFormatLine("Passenger Roll: {0}", _seat.PassengerRoll);
            _rtb.AppendFormatLine("Passenger Attachment ID: {0}", _seat.PassengerAttachmentId);
            _rtb.AppendFormatLine("Vehicle Enter Animation: {0}", _seat.VehicleEnterAnim);
            _rtb.AppendFormatLine("Vehicle Enter Animation Bone: {0}", _seat.VehicleEnterAnimBone);
            _rtb.AppendFormatLine("Vehicle Enter Animation Delay: {0}", _seat.VehicleEnterAnimDelay);
            _rtb.AppendFormatLine("Vehicle Exit Animation: {0}", _seat.VehicleExitAnim);
            _rtb.AppendFormatLine("Vehicle Exit Animation Bone: {0}", _seat.VehicleExitAnimBone);
            _rtb.AppendFormatLine("Vehicle Exit Animation Delay: {0}", _seat.VehicleExitAnimDelay);
            _rtb.AppendFormatLine("Vehicle Ride Animation Loop: {0}", _seat.VehicleRideAnimLoop);
            _rtb.AppendFormatLine("Vehicle Ride Animation Loop Bone: {0}", _seat.VehicleRideAnimLoopBone);
            _rtb.AppendFormatLine("Vehicle Ability Display: {0}", _seat.VehicleAbilityDisplay);
            _rtb.AppendFormatLine("Vehicle Enter UI Sound ID: {0}", _seat.EnterUiSoundId);
            _rtb.AppendFormatLine("Vehicle Exit UI Sound ID: {0}", _seat.ExitUiSoundId);
            _rtb.AppendFormatLine("Vehicle Skin: {0}", _seat.Skin);
            _rtb.AppendFormatLine("Unk1: {0}", _seat.Unk1);
            _rtb.AppendFormatLine("Unk2: {0}", _seat.Unk2);
            _rtb.AppendFormatLine("Unk3: {0}", _seat.Unk3);
            _rtb.AppendFormatLine("Unk4: {0}", _seat.Unk4);
            _rtb.AppendFormatLine("Unk5: {0}", _seat.Unk5);
            _rtb.AppendFormatLine("Unk6: {0}", _seat.Unk6);
            _rtb.AppendFormatLine("Unk7: {0}", _seat.Unk7);
            _rtb.AppendFormatLine("Unk8: {0}", _seat.Unk8);
            _rtb.AppendFormatLine("Unk9: {0}", _seat.Unk9);
            _rtb.AppendFormatLine("Unk10: {0}", _seat.Unk10);
            _rtb.AppendFormatLine("Unk11: {0}", _seat.Unk11);
            _rtb.AppendFormatLine("Unk12: {0}", _seat.Unk12);
            _rtb.AppendLine();

            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceSeatFlags:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((_seat.Flags & (1 << i)) != 0L)
                    _rtb.AppendFormatLine("{0}", (VehicleSeatFlags)(1 << i));
 

            _rtb.AppendLine();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceSeatFlagsB:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((_seat.FlagsB & (1 << i)) != 0L)
                    _rtb.AppendFormatLine("{0}", (VehicleSeatFlagsB)(1 << i));
            _rtb.SetDefaultStyle();
        }
    }
}
