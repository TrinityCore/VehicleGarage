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
            _rtb.SetDefaultStyle();
        }
    }
}
