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
        private uint _pos;

        public VehicleSeatInfo(RichTextBox rtb, VehicleSeatEntry seat, uint pos)
        {
            _rtb = rtb;
            _seat = seat;
            _pos = pos;
        }

        public void ViewSeatInfo()
        {
            _rtb.Clear();
            _rtb.SetBold();
            _rtb.AppendFormatLine("Seat ID: {0}", _seat.Id);
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
                if ((_seat.Flags & (1 << i)) != 0L)
                    _rtb.AppendFormatLine("{0}", (VehicleSeatFlagsB)(1 << i));
            _rtb.SetDefaultStyle();

        }
    }
}
