using System.Windows.Forms;
using VehicleGarage.DBCStructures;
using VehicleGarage.Extensions;

namespace VehicleGarage.Info
{
    public class VehicleSeatInfo
    {
        private readonly RichTextBox _rtb;
        public VehicleSeatEntry Seat;

        public VehicleSeatInfo(RichTextBox rtb, VehicleSeatEntry seat)
        {
            _rtb = rtb;
            Seat = seat;
        }

        public void ViewSeatInfo()
        {
            _rtb.Clear();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Seat ID: {0}", Seat.Id);
            _rtb.SetDefaultStyle();

            _rtb.AppendFormatLine("Attachment ID: {0}", Seat.AttachmentId);
            _rtb.AppendFormatLine("Attachment Offset X: {0}", Seat.AttachmentOffsetX);
            _rtb.AppendFormatLine("Attachment Offset Y: {0}", Seat.AttachmentOffsetY);
            _rtb.AppendFormatLine("Attachment Offset Z: {0}", Seat.AttachmentOffsetZ);
            _rtb.AppendFormatLine("Enter Pre-delay: {0}", Seat.EnterPreDelay);
            _rtb.AppendFormatLine("Enter Speed: {0}", Seat.EnterSpeed);
            _rtb.AppendFormatLine("Enter Gravity: {0}", Seat.EnterGravity);
            _rtb.AppendFormatLine("Enter Duration Min: {0}", Seat.EnterMinDuration);
            _rtb.AppendFormatLine("Enter Duration Max: {0}", Seat.EnterMaxDuration);
            _rtb.AppendFormatLine("Enter Arc Height Min: {0}", Seat.EnterMinArcHeight);
            _rtb.AppendFormatLine("Enter Arc Height Max: {0}", Seat.EnterMaxArcHeight);
            _rtb.AppendFormatLine("Enter Animation Start: {0}", Seat.EnterAnimStart);
            _rtb.AppendFormatLine("Enter Animation Loop: {0}", Seat.EnterAnimLoop); 
            _rtb.AppendFormatLine("Ride Animation Start: {0}", Seat.RideAnimStart);
            _rtb.AppendFormatLine("Ride Animation Loop: {0}", Seat.RideAnimLoop);
            _rtb.AppendFormatLine("Ride Upper Animation Start: {0}", Seat.RideUpperAnimStart);
            _rtb.AppendFormatLine("Ride Upper Animation Loop: {0}", Seat.RideUpperAnimLoop);
            _rtb.AppendFormatLine("Exit Pre-delay: {0}", Seat.ExitPreDelay);
            _rtb.AppendFormatLine("Exit Gravity: {0}", Seat.ExitGravity);
            _rtb.AppendFormatLine("Exit Duration Min: {0}", Seat.ExitMinDuration);
            _rtb.AppendFormatLine("Exit Duration Max: {0}", Seat.ExitMaxDuration);
            _rtb.AppendFormatLine("Exit Arc Height Min: {0}", Seat.ExitMinArcHeight);
            _rtb.AppendFormatLine("Exit Arc height Max: {0}", Seat.ExitMaxArcHeight);
            _rtb.AppendFormatLine("Exit Animation Start: {0}", Seat.ExitAnimStart);
            _rtb.AppendFormatLine("Exit Animation Loop: {0}", Seat.ExitAnimLoop);
            _rtb.AppendFormatLine("Exit Animation End: {0}", Seat.ExitAnimEnd);
            _rtb.AppendFormatLine("Passenger Yaw: {0}", Seat.PassengerYaw);
            _rtb.AppendFormatLine("Passenger Pitch: {0}", Seat.PassengerPitch);
            _rtb.AppendFormatLine("Passenger Roll: {0}", Seat.PassengerRoll);
            _rtb.AppendFormatLine("Passenger Attachment ID: {0}", Seat.PassengerAttachmentId);
            _rtb.AppendFormatLine("Vehicle Enter Animation: {0}", Seat.VehicleEnterAnim);
            _rtb.AppendFormatLine("Vehicle Enter Animation Bone: {0}", Seat.VehicleEnterAnimBone);
            _rtb.AppendFormatLine("Vehicle Enter Animation Delay: {0}", Seat.VehicleEnterAnimDelay);
            _rtb.AppendFormatLine("Vehicle Exit Animation: {0}", Seat.VehicleExitAnim);
            _rtb.AppendFormatLine("Vehicle Exit Animation Bone: {0}", Seat.VehicleExitAnimBone);
            _rtb.AppendFormatLine("Vehicle Exit Animation Delay: {0}", Seat.VehicleExitAnimDelay);
            _rtb.AppendFormatLine("Vehicle Ride Animation Loop: {0}", Seat.VehicleRideAnimLoop);
            _rtb.AppendFormatLine("Vehicle Ride Animation Loop Bone: {0}", Seat.VehicleRideAnimLoopBone);
            _rtb.AppendFormatLine("Vehicle Ability Display: {0}", Seat.VehicleAbilityDisplay);
            _rtb.AppendFormatLine("Vehicle Enter UI Sound ID: {0}", Seat.EnterUiSoundId);
            _rtb.AppendFormatLine("Vehicle Exit UI Sound ID: {0}", Seat.ExitUiSoundId);
            _rtb.AppendFormatLine("Vehicle Skin: {0}", Seat.Skin);
            _rtb.AppendFormatLine("Camera Entering Delay: {0}", Seat.CameraEnteringDelay);
            _rtb.AppendFormatLine("Camera Entering Duration: {0}", Seat.CameraEnteringDuration);
            _rtb.AppendFormatLine("Camera Exiting Delay: {0}", Seat.CameraExitingDelay);
            _rtb.AppendFormatLine("Camera Exiting Duration: {0}", Seat.CameraExitingDuration);
            _rtb.AppendFormatLine("Camera Offset X: {0}", Seat.CameraOffsetX);
            _rtb.AppendFormatLine("Camera Offset Y: {0}", Seat.CameraOffsetY);
            _rtb.AppendFormatLine("Camera Offset Z: {0}", Seat.CameraOffsetZ);
            _rtb.AppendFormatLine("Camera Pos Chase Rate: {0}", Seat.CameraPosChaseRate);
            _rtb.AppendFormatLine("Camera Facing Chase Rate: {0}", Seat.CameraFacingChaseRate);
            _rtb.AppendFormatLine("Camera Entering Zoom: {0}", Seat.CameraEnteringZoom);
            _rtb.AppendFormatLine("Camera Seat Zoom Min: {0}", Seat.CameraSeatZoomMin);
            _rtb.AppendFormatLine("Camera Seat Zoom Max: {0}", Seat.CameraSeatZoomMax);

            _rtb.AppendLine();

            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceSeatFlags:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if (Seat.Flags.HasFlag((VehicleSeatFlags)(1 << i)))
                    _rtb.AppendFormatLine("{0}", (VehicleSeatFlags)(1 << i));
 

            _rtb.AppendLine();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceSeatFlagsB:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((Seat.FlagsB & (1 << i)) != 0L)
                    _rtb.AppendFormatLine("{0}", (VehicleSeatFlagsB)(1 << i));
            _rtb.SetDefaultStyle();
        }
    }
}
