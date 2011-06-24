using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleGarage.DBCStructures;
using VehicleGarage.Extensions;
using VehicleGarage.SQLStores;

namespace VehicleGarage.Info
{
    public class VehicleInfo
    {
        private readonly RichTextBox _rtb;
        private VehicleEntry _vehicle;

        public VehicleInfo(RichTextBox rtb, VehicleEntry vehicle)
        {
            this._rtb = rtb;
            this._vehicle = vehicle;


            ViewVehicleInfo();
        }

        private void ViewVehicleInfo()
        {
            _rtb.Clear();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Vehicle ID: {0}", _vehicle.Id);
            _rtb.SetDefaultStyle();
            for (var i = 0; i < (int)Constants.MaxVehicleSeats; i++)
            {
                var m = _vehicle.SeatId[i];
                if (m == 0) 
                    continue;

                _rtb.AppendFormatIfNotNull("seat{0}:", i.ToString());
                _rtb.AppendFormatLineIfNotNull(" {0}", m);
            }

            _rtb.AppendLine();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Has VehiceFlags:");
            _rtb.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((_vehicle.Flags & (1 << i)) != 0l)
                    _rtb.AppendFormatLine("{0}", (VehicleFlags)(1 << i));

                _rtb.AppendLine(); 
            _rtb.SetBold();
            _rtb.AppendFormatLine("Used by the following creatures:");
            _rtb.SetDefaultStyle();

            foreach (var c in
                SQL.CreatureTemplate.Where(x => x.Value.VehicleId == _vehicle.Id).Select(creature => creature.Value))
            {
                _rtb.AppendLine();
                _rtb.AppendFormatLine("==========================");
                _rtb.SetBold();
                _rtb.AppendFormatLine("{0} - {1}", c.Id, c.Name);
                _rtb.SetDefaultStyle();
                if (((NPCFlags)c.NPCFlag).HasFlag(NPCFlags.Spellclick))
                    _rtb.AppendLine("    Has spellclick NPC flag");
                List<int> spellClickSpells;
                if (SQL.SpellClick.TryGetValue(c.Id, out spellClickSpells))
                    foreach (var spell in spellClickSpells)
                        _rtb.AppendFormatLine("    Has spellclick spell {0}", spell);
                _rtb.AppendLine();
                _rtb.AppendFormatLineIfNotNull("AIName: \"{0}\"", c.AIName);
                _rtb.AppendFormatLineIfNotNull("ScriptName: \"{0}\"", c.ScriptName);
            }

        }

        public static uint GetUsedCount(VehicleEntry vehicle)
        {
            return SQL.CreatureTemplate.Count(x => x.Value.VehicleId == vehicle.Id).ToUInt32();
        }
    }
}
