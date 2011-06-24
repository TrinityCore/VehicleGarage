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

namespace VehicleGarage.Info
{
    public class VehicleInfo
    {
        private readonly RichTextBox _rtbMain;
        private readonly RichTextBox _rtbSeat;
        private readonly TabControl _tabControl;
        private VehicleEntry _vehicle;
        private List<VehicleSeatInfo> _seats = new List<VehicleSeatInfo>();

        public VehicleInfo(RichTextBox rtbMain, RichTextBox rtbSeat, TabControl tabControl, VehicleEntry vehicle)
        {
            _rtbMain = rtbMain;
            _rtbSeat = rtbSeat;
            _vehicle = vehicle;
            _tabControl = tabControl;

            ViewVehicleInfo();
        }

        private void ViewVehicleInfo()
        {
            _rtbMain.Clear();
            _rtbMain.SetBold();
            _rtbMain.AppendFormatLine("Vehicle ID: {0}", _vehicle.Id);
            _rtbMain.SetDefaultStyle();

            bool refreshed = false;
            for (uint i = 0; i < (uint)Constants.MaxVehicleSeats; ++i)
            {
                var m = _vehicle.SeatId[i];
                if (m == 0)
                    continue;

                Contract.Assume(DBC.VehicleSeat.ContainsKey(m));

                _tabControl.TabPages.Add(new TabPage("seat" + i));
                var seatInfo = new VehicleSeatInfo(_rtbSeat, DBC.VehicleSeat[m], i);
                _seats.Add(seatInfo);

                if (!refreshed)
                {
                    seatInfo.ViewSeatInfo();
                    refreshed = true;
                }
            }


            _rtbMain.AppendLine();
            _rtbMain.SetBold();
            _rtbMain.AppendFormatLine("Has VehiceFlags:");
            _rtbMain.SetDefaultStyle();
            for (var i = 0; i < 32; ++i)
                if ((_vehicle.Flags & (1 << i)) != 0l)
                    _rtbMain.AppendFormatLine("{0}", (VehicleFlags)(1 << i));

                _rtbMain.AppendLine(); 
            _rtbMain.SetBold();
            _rtbMain.AppendFormatLine("Used by the following creatures:");
            _rtbMain.SetDefaultStyle();

            foreach (var c in
                SQL.CreatureTemplate.Where(x => x.Value.VehicleId == _vehicle.Id).Select(creature => creature.Value))
            {
                _rtbMain.AppendLine();
                _rtbMain.AppendFormatLine("==========================");
                _rtbMain.SetBold();
                _rtbMain.AppendFormatLine("{0} - {1}", c.Id, c.Name);
                _rtbMain.SetDefaultStyle();
                if (((NPCFlags)c.NPCFlag).HasFlag(NPCFlags.Spellclick))
                    _rtbMain.AppendLine("    Has spellclick NPC flag");
                List<int> spellClickSpells;
                if (SQL.SpellClick.TryGetValue(c.Id, out spellClickSpells))
                    foreach (var spell in spellClickSpells)
                        _rtbMain.AppendFormatLine("    Has spellclick spell {0}", spell);
                _rtbMain.AppendLine();
                _rtbMain.AppendFormatLineIfNotNull("AIName: \"{0}\"", c.AIName);
                _rtbMain.AppendFormatLineIfNotNull("ScriptName: \"{0}\"", c.ScriptName);
            }

        }

        public void ViewSeatInfo(int pos)
        {
            var seatInfo = _seats[pos];
            seatInfo.ViewSeatInfo();
        }

        public static uint GetUsedCount(VehicleEntry vehicle)
        {
            return SQL.CreatureTemplate.Count(x => x.Value.VehicleId == vehicle.Id).ToUInt32();
        }
    }
}
