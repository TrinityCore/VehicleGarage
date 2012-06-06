using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using VehicleGarage.Extensions;
using VehicleGarage.DBCStructures;
using VehicleGarage.DBCStores;
using VehicleGarage.Info;
using VehicleGarage.SQLStores;
using System.Diagnostics.Contracts;

namespace VehicleGarage.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            _cbVehicleFlagsOperator.SelectedIndex = 0;
            _cbVehicleSeatFlagsOperator.SelectedIndex = 0;
            _cbVehicleSeatFlagsBOperator.SelectedIndex = 0;
            _cbIdOrName.SelectedIndex = 0;
            _cbPowerType.SetEnumValues<VehiclePowerTypes>("PowerType");
            _cbAdvancedFilter1.SetStructFields<VehicleEntry>();
            _cbAdvancedFilter2.SetStructFields<VehicleEntry>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchVehicleEntry()
        {
            Contract.Requires(DBC.Vehicle != null);

            var vehicleIdFilter = _tbIdOrName.Text.ToInt32();
            var filterVehicleId = (_cbIdOrName.SelectedIndex == 0 && _tbIdOrName.Text != String.Empty);

            var creatureIdFilter = _tbIdOrName.Text.ToInt32();
            var filterCreatureId = (_cbIdOrName.SelectedIndex == 1 && _tbIdOrName.Text != String.Empty);

            var creatureNameFilter = _tbIdOrName.Text;
            var filterCreatureName = (_cbIdOrName.SelectedIndex == 2 && _tbIdOrName.Text != String.Empty);

            var vehicleFlagMaskFilter = _tbVehicleFlags.Text.ToUInt32FromPossibleHexString();
            var filterVehicleFlagMask = (vehicleFlagMaskFilter != 0);
            var vehicleFlagMaskFilterOperator = (_cbVehicleFlagsOperator.SelectedIndex == 0) ? true : false;

            var filterPowerType = (_cbPowerType.SelectedIndex != 0);
            var powerTypeFilter = _cbPowerType.SelectedValue.ToInt32();

            var filterSeatId = (_tbSeatId.Text != String.Empty);
            var seatIdFilter = _tbSeatId.Text.ToUInt32();

            var vehicleSeatFlagMaskFilter = _tbVehicleSeatFlags.Text.ToUInt32FromPossibleHexString();
            var filterVehicleSeatFlagMask = (vehicleSeatFlagMaskFilter != 0);
            var vehicleSeatFlagMaskFilterOperator = (_cbVehicleSeatFlagsOperator.SelectedIndex == 0) ? true : false;

            var vehicleSeatFlagBMaskFilter = _tbVehicleSeatFlagsB.Text.ToUInt32FromPossibleHexString();
            var filterVehicleSeatFlagBMask = (vehicleSeatFlagBMaskFilter != 0);
            var vehicleSeatFlagBMaskFilterOperator = (_cbVehicleSeatFlagsBOperator.SelectedIndex == 0) ? true : false;

            var advancedFilter1 = _tbAdvancedFilter1.Text;
            var field1 = (MemberInfo) _cbAdvancedFilter1.SelectedValue;
            var filterAdvanced1 = (advancedFilter1 != String.Empty);

            var advancedFilter2 = _tbAdvancedFilter2.Text;
            var field2 = (MemberInfo) _cbAdvancedFilter2.SelectedValue;
            var filterAdvanced2 = (advancedFilter2 != String.Empty);
            
            _vehicleResults = DBC.Vehicle.Values.Where(x => (
                (!filterVehicleId || x.Id == vehicleIdFilter)
                &&
                (!filterCreatureId ||
                    SQL.CreatureTemplate.Count(
                        y =>
                        y.Value.VehicleId == x.Id &&
                        y.Value.Id == creatureIdFilter) == 1)
                &&
                (!filterCreatureName ||
                    SQL.CreatureTemplate.Count(
                        y =>
                        y.Value.VehicleId == x.Id &&
                        y.Value.Name.Contains(creatureNameFilter)) == 1)
                &&
                (!filterVehicleFlagMask ||
                    ((vehicleFlagMaskFilterOperator && (x.Flags & vehicleFlagMaskFilter) != 0)
                    || (!vehicleFlagMaskFilterOperator && (x.Flags & vehicleFlagMaskFilter) == 0)))
                &&
                (!filterPowerType || 
                    x.PowerType == powerTypeFilter)
                &&
                (!filterSeatId ||
                    x.SeatId.Count(y => y == seatIdFilter) > 0)
                &&
                (!filterVehicleSeatFlagMask ||
                    ((vehicleSeatFlagMaskFilterOperator && (x.SeatId.Count(y => (y > 0) && (DBC.VehicleSeat[y].Flags.HasFlag((VehicleSeatFlags)vehicleSeatFlagMaskFilter))) > 0))
                    || (!vehicleSeatFlagMaskFilterOperator && (x.SeatId.Count(y => (y > 0) && (DBC.VehicleSeat[y].Flags.HasFlag((VehicleSeatFlags)vehicleSeatFlagMaskFilter))) > 0))
                    ))
                &&
                (!filterVehicleSeatFlagBMask ||
                    ((vehicleSeatFlagBMaskFilterOperator && (x.SeatId.Count(y => (y > 0) && (DBC.VehicleSeat[y].FlagsB & vehicleSeatFlagBMaskFilter) != 0) > 0))
                    || (!vehicleSeatFlagBMaskFilterOperator && (x.SeatId.Count(y => (y > 0) && (DBC.VehicleSeat[y].FlagsB & vehicleSeatFlagBMaskFilter) == 0) > 0))
                    ))
                &&
                (!filterAdvanced1 ||
                    x.CreateFilter(field1, advancedFilter1))
                &&
                (!filterAdvanced2 ||
                    x.CreateFilter(field2, advancedFilter2))
                )
            ).ToList();

            _lvSearchResults.VirtualListSize = _vehicleResults.Count();
            if (_lvSearchResults.SelectedIndices.Count > 0)
                _lvSearchResults.Items[_lvSearchResults.SelectedIndices[0]].Selected = false;

            _lvSearchResults.Focus();
        }

        private List<VehicleEntry> _vehicleResults = new List<VehicleEntry>();
        private VehicleInfo _currentInfo;


        private void SearchResultsListViewRetrieveVItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            Contract.Requires(e.ItemIndex >= 0);
            Contract.Requires(e.ItemIndex < this._vehicleResults.Count);

            var vehicle = _vehicleResults[e.ItemIndex];
            e.Item = new ListViewItem(new[] { vehicle.Id.ToString(), VehicleInfo.GetUsedCount(vehicle).ToString()});
        }

        private void _bSearch_MouseClick(object sender, MouseEventArgs e)
        {
            SearchVehicleEntry();
        }

        private void _lvSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (TabPage tab in _tcSeats.TabPages.Cast<object>().Where(tab => !tab.Equals(_tpMain)))
                _tcSeats.TabPages.Remove(tab);
            _tcSeats.SelectedTab = _tpMain;

            if (_lvSearchResults.SelectedIndices.Count > 0)
                _currentInfo = new VehicleInfo(_rtVehicleInfo, _tcSeats, _vehicleResults[_lvSearchResults.SelectedIndices[0]]);
        }

        private void _rtVehicleInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void _tcSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract.Requires(_tcSeats.SelectedIndex < 9);
            Contract.Requires(_tcSeats.SelectedIndex >= 0);
            Contract.Requires((_tcSeats.SelectedIndex - 1) < _currentInfo.Seats.Count);

            if (_tcSeats.SelectedIndex > 0)
                _currentInfo.ViewSeatInfo(_tcSeats.SelectedIndex);
            else if (_currentInfo != null)
                _currentInfo.ViewVehicleInfo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var ab = new AboutForm())
                ab.ShowDialog();
        }
    }
}
