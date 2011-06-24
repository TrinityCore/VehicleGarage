using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VehicleGarage.Extensions;
using VehicleGarage.DBCStructures;
using VehicleGarage.DBCStores;
using VehicleGarage.Info;
using VehicleGarage.SQLStores;
using System.Diagnostics.Contracts;
using VehicleGarage.SQLStructures;

namespace VehicleGarage
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            _cbPowerType.SetEnumValues<VehiclePowerTypes>("PowerType");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchVehicleEntry()
        {
            Contract.Requires(DBC.Vehicle != null);

            var filterPowerType = (_cbPowerType.SelectedIndex != 0);
            var powerTypeFilter = _cbPowerType.SelectedValue.ToInt32();

            _vehicleResults = (from vehicle in DBC.Vehicle.Values
                               where (!filterPowerType || vehicle.PowerType == powerTypeFilter)
                               select vehicle).ToList();

            _lvSearchResults.VirtualListSize = _vehicleResults.Count();
            if (_lvSearchResults.SelectedIndices.Count > 0)
                _lvSearchResults.Items[_lvSearchResults.SelectedIndices[0]].Selected = false;
        }

        private List<VehicleEntry> _vehicleResults = new List<VehicleEntry>();
        private VehicleInfo _currentInfo;


        private void SearchResultsListViewRetrieveVItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            // TODO: Creature template data
            var vehicle = _vehicleResults[e.ItemIndex];
            e.Item = new ListViewItem(new[] { vehicle.Id.ToString(), VehicleInfo.GetUsedCount(vehicle).ToString()});
        }

        private void _bSearch_MouseClick(object sender, MouseEventArgs e)
        {
            SearchVehicleEntry();
        }

        private void _lvSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tcSeats.TabPages.Clear();
            if (_lvSearchResults.SelectedIndices.Count > 0)
                _currentInfo = new VehicleInfo(_rtVehicleInfo, _rtbSeatInfo, _tcSeats, _vehicleResults[_lvSearchResults.SelectedIndices[0]]);
        }

        private void _rtVehicleInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void _tcSeats_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contract.Requires(_tcSeats.SelectedIndex < 8);
            _rtbSeatInfo.Clear();
            if (_tcSeats.SelectedIndex >= 0)
                _currentInfo.ViewSeatInfo(_tcSeats.SelectedIndex);
            _lvSearchResults.Focus();
        }
    }
}
