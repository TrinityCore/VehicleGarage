using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleGarage.DBCStructures;
using VehicleGarage.Extensions;
using VehicleGarage.SQLStores;
using VehicleGarage.DBCStores;
using VehicleGarage.SQLStructures;

namespace VehicleGarage.Info
{
    public class VehicleInfo
    {
        private readonly RichTextBox _rtb;
        private readonly TabControl _tabControl;
        private VehicleEntry _vehicle;
        public readonly List<VehicleSeatInfo> Seats = new List<VehicleSeatInfo>();

        public VehicleInfo(RichTextBox rtbMain, TabControl tabControl, VehicleEntry vehicle)
        {
            _rtb = rtbMain;
            _vehicle = vehicle;
            _tabControl = tabControl;

            for (uint i = 0; i < (uint)Constants.MaxVehicleSeats; ++i)
            {
                var m = _vehicle.SeatId[i];
                if (m == 0)
                    continue;

                Contract.Assume(DBC.VehicleSeat.ContainsKey(m));

                _tabControl.TabPages.Add("seat" + i);
                var seatInfo = new VehicleSeatInfo(_rtb, DBC.VehicleSeat[m]);
                Seats.Add(seatInfo);
            }

            ViewVehicleInfo();
        }

        public void ViewVehicleInfo()
        {
            _rtb.Clear();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Vehicle ID: {0}", _vehicle.Id);
            _rtb.AppendFormatLine("Locomotion Type: {0}", _vehicle.LocomotionType);
            _rtb.AppendFormatLine("Seat Indicator Type: {0}", _vehicle.SeatIndicatorType);
            _rtb.AppendFormatLine("Power Type: {0}", _vehicle.PowerType);
            _rtb.AppendFormatLine("Turn Speed: {0}", _vehicle.TurnSpeed);
            _rtb.AppendFormatLine("Pitch Speed: {0}", _vehicle.PitchSpeed);
            _rtb.AppendFormatLine("Pitch Min: {0}", _vehicle.PitchMin);
            _rtb.AppendFormatLine("Pitch Max: {0}", _vehicle.PitchMax);
            _rtb.AppendFormatLine("Pitch Offset: {0}", _vehicle.PitchOffset);
            _rtb.AppendFormatLine("Mouselook Offset Pitch: {0}", _vehicle.MouseLookOffsetPitch);
            _rtb.AppendFormatLine("Camera Fade Distance Scalar Min: {0}", _vehicle.CameraFadeDistScalarMin);
            _rtb.AppendFormatLine("Camera Fade Distance Scalar Max: {0}", _vehicle.CameraFadeDistScalarMax);
            _rtb.AppendFormatLine("Camera Yaw Offset: {0}", _vehicle.CameraYawOffset);
            _rtb.AppendFormatLine("Facing Limit Right: {0}", _vehicle.FacingLimitRight);
            _rtb.AppendFormatLine("Facing Limit Left: {0}", _vehicle.FacingLimitLeft);
            _rtb.AppendFormatLine("Missle Target Turn Lingering: {0}", _vehicle.MissleTargetTurnLingering);
            _rtb.AppendFormatLine("Missle Target Pitch Lingering: {0}", _vehicle.MissleTargetPitchLingering);
            _rtb.AppendFormatLine("Missle Target Mouse Lingering: {0}", _vehicle.MissleTargetMouseLingering);
            _rtb.AppendFormatLine("Missle Target End Opacity: {0}", _vehicle.MissleTargetEndOpacity);
            _rtb.AppendFormatLine("Missle Target Arc Speed: {0}", _vehicle.MissleTargetArcSpeed);
            _rtb.AppendFormatLine("Missle Target Arc Repeat: {0}", _vehicle.MissleTargetArcRepeat);
            _rtb.AppendFormatLine("Missle Target Arc Width: {0}", _vehicle.MissleTargetArcWidth);
            _rtb.AppendFormatLine("Missle Target Impact Radius 1: {0}", _vehicle.MissleTargetImpactRadius[0]);
            _rtb.AppendFormatLine("Missle Target Impact Radius 2: {0}", _vehicle.MissleTargetImpactRadius[1]);
            _rtb.AppendFormatLine("Missle Target Impact Texture Radius: {0}", _vehicle.MissleTargetImpactTexRadius);
            _rtb.AppendFormatLine("Missle Target Arc Texture: {0}", _vehicle.MissleTargetArcTexture);
            _rtb.AppendFormatLine("Missle Target Impact Model 1: {0}", _vehicle.MissleTargetImpactModel1);
            _rtb.AppendFormatLine("Missle Target Impact Model 2: {0}", _vehicle.MissleTargetImpactModel2);
            _rtb.AppendFormatLine("Unk1: {0}", _vehicle.Unk1);
            _rtb.AppendFormatLine("Unk2: {0}", _vehicle.Unk2);
            _rtb.AppendLine();

            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceFlags:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((_vehicle.Flags & (1 << i)) != 0L)
                    _rtb.AppendFormatLine("{0}", (VehicleFlags)(1 << i));

            _rtb.AppendLine(); 
            _rtb.SetBold();
            _rtb.AppendFormatLine("Used by the following creatures:");
            _rtb.SetDefaultStyle();

            foreach (var c in
                SQL.CreatureTemplate.Where(x => x.Value.VehicleId == _vehicle.Id).Select(creature => creature.Value))
            {
                _rtb.AppendFormatLine("{0} - {1}", c.Id, c.Name);
                _rtb.SetDefaultStyle();
                if (((NPCFlags)c.NPCFlag).HasFlag(NPCFlags.Spellclick))
                    _rtb.AppendLine("    Has spellclick NPC flag");

                List<int> spellClickSpells;
                if (SQL.SpellClick.TryGetValue(c.Id, out spellClickSpells))
                    foreach (var spell in spellClickSpells)
                        _rtb.AppendFormatLine("    Has spellclick spell {0}", spell);

                List<VehicleTemplateAccessory> accessories;
                if (SQL.Accessories.TryGetValue(c.Id, out accessories))
                    foreach (var accessory in accessories)
                        _rtb.AppendFormatLine("    Has accessory entry {0} on seat {1}", accessory.AccessoryEntry, accessory.SeatId);

                _rtb.AppendFormatLineIfNotNull("    AIName: \"{0}\"", c.AIName);
                _rtb.AppendFormatLineIfNotNull("    ScriptName: \"{0}\"", c.ScriptName);

                _rtb.AppendLine();
                _rtb.SetDefaultStyle();
            }

        }

        public void ViewSeatInfo(int pos)
        {
            Contract.Requires((pos - 1) < Seats.Count);
            Contract.Requires((pos - 1) >= 0);
            Seats[--pos].ViewSeatInfo();
        }

        public static uint GetUsedCount(VehicleEntry vehicle)
        {
            return SQL.CreatureTemplate.Count(x => x.Value.VehicleId == vehicle.Id).ToUInt32();
        }
    }
}
