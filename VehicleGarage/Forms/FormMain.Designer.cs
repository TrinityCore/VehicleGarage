namespace VehicleGarage
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this._bSearch = new System.Windows.Forms.Button();
            this._cbPowerType = new System.Windows.Forms.ComboBox();
            this._lvSearchResults = new System.Windows.Forms.ListView();
            this._chVehicleId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._chUsedCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._rtVehicleInfo = new System.Windows.Forms.RichTextBox();
            this._tcSeats = new System.Windows.Forms.TabControl();
            this._tpMain = new System.Windows.Forms.TabPage();
            this._labelPowerType = new System.Windows.Forms.Label();
            this._tbIdOrName = new System.Windows.Forms.TextBox();
            this._cbIdOrName = new System.Windows.Forms.ComboBox();
            this._labelColon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this._tcSeats.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._labelColon);
            this.panel1.Controls.Add(this._cbIdOrName);
            this.panel1.Controls.Add(this._tbIdOrName);
            this.panel1.Controls.Add(this._labelPowerType);
            this.panel1.Controls.Add(this._bSearch);
            this.panel1.Controls.Add(this._cbPowerType);
            this.panel1.Location = new System.Drawing.Point(370, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 196);
            this.panel1.TabIndex = 0;
            // 
            // _bSearch
            // 
            this._bSearch.Location = new System.Drawing.Point(22, 163);
            this._bSearch.Name = "_bSearch";
            this._bSearch.Size = new System.Drawing.Size(104, 19);
            this._bSearch.TabIndex = 1;
            this._bSearch.Text = "Search";
            this._bSearch.UseVisualStyleBackColor = true;
            this._bSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this._bSearch_MouseClick);
            // 
            // _cbPowerType
            // 
            this._cbPowerType.FormattingEnabled = true;
            this._cbPowerType.Location = new System.Drawing.Point(100, 67);
            this._cbPowerType.Name = "_cbPowerType";
            this._cbPowerType.Size = new System.Drawing.Size(140, 21);
            this._cbPowerType.TabIndex = 0;
            this._cbPowerType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _lvSearchResults
            // 
            this._lvSearchResults.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this._lvSearchResults.AllowColumnReorder = true;
            this._lvSearchResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._chVehicleId,
            this._chUsedCount});
            this._lvSearchResults.FullRowSelect = true;
            this._lvSearchResults.GridLines = true;
            this._lvSearchResults.HideSelection = false;
            this._lvSearchResults.Location = new System.Drawing.Point(370, 224);
            this._lvSearchResults.MultiSelect = false;
            this._lvSearchResults.Name = "_lvSearchResults";
            this._lvSearchResults.Size = new System.Drawing.Size(146, 185);
            this._lvSearchResults.TabIndex = 7;
            this._lvSearchResults.UseCompatibleStateImageBehavior = false;
            this._lvSearchResults.View = System.Windows.Forms.View.Details;
            this._lvSearchResults.VirtualMode = true;
            this._lvSearchResults.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.SearchResultsListViewRetrieveVItem);
            this._lvSearchResults.SelectedIndexChanged += new System.EventHandler(this._lvSearchResults_SelectedIndexChanged);
            // 
            // _chVehicleId
            // 
            this._chVehicleId.Text = "VehicleId";
            this._chVehicleId.Width = 59;
            // 
            // _chUsedCount
            // 
            this._chUsedCount.Text = "Used count";
            this._chUsedCount.Width = 75;
            // 
            // _rtVehicleInfo
            // 
            this._rtVehicleInfo.Location = new System.Drawing.Point(20, 39);
            this._rtVehicleInfo.Name = "_rtVehicleInfo";
            this._rtVehicleInfo.Size = new System.Drawing.Size(323, 342);
            this._rtVehicleInfo.TabIndex = 8;
            this._rtVehicleInfo.Text = "";
            this._rtVehicleInfo.TextChanged += new System.EventHandler(this._rtVehicleInfo_TextChanged);
            // 
            // _tcSeats
            // 
            this._tcSeats.Controls.Add(this._tpMain);
            this._tcSeats.Location = new System.Drawing.Point(20, 22);
            this._tcSeats.Name = "_tcSeats";
            this._tcSeats.SelectedIndex = 0;
            this._tcSeats.Size = new System.Drawing.Size(323, 18);
            this._tcSeats.TabIndex = 9;
            this._tcSeats.SelectedIndexChanged += new System.EventHandler(this._tcSeats_SelectedIndexChanged);
            // 
            // _tpMain
            // 
            this._tpMain.Location = new System.Drawing.Point(4, 22);
            this._tpMain.Name = "_tpMain";
            this._tpMain.Padding = new System.Windows.Forms.Padding(3);
            this._tpMain.Size = new System.Drawing.Size(315, 0);
            this._tpMain.TabIndex = 0;
            this._tpMain.Text = "Vehicle";
            this._tpMain.UseVisualStyleBackColor = true;
            // 
            // _labelPowerType
            // 
            this._labelPowerType.AutoSize = true;
            this._labelPowerType.Location = new System.Drawing.Point(3, 75);
            this._labelPowerType.Name = "_labelPowerType";
            this._labelPowerType.Size = new System.Drawing.Size(63, 13);
            this._labelPowerType.TabIndex = 2;
            this._labelPowerType.Text = "Power type:";
            // 
            // _tbIdOrName
            // 
            this._tbIdOrName.Location = new System.Drawing.Point(113, 14);
            this._tbIdOrName.Name = "_tbIdOrName";
            this._tbIdOrName.Size = new System.Drawing.Size(127, 20);
            this._tbIdOrName.TabIndex = 3;
            // 
            // _cbIdOrName
            // 
            this._cbIdOrName.FormattingEnabled = true;
            this._cbIdOrName.Items.AddRange(new object[] {
            "",
            "Vehicle ID",
            "Creature ID",
            "Creature Name"});
            this._cbIdOrName.Location = new System.Drawing.Point(6, 14);
            this._cbIdOrName.Name = "_cbIdOrName";
            this._cbIdOrName.Size = new System.Drawing.Size(94, 21);
            this._cbIdOrName.TabIndex = 4;
            // 
            // _labelColon
            // 
            this._labelColon.AutoSize = true;
            this._labelColon.Location = new System.Drawing.Point(106, 17);
            this._labelColon.Name = "_labelColon";
            this._labelColon.Size = new System.Drawing.Size(10, 13);
            this._labelColon.TabIndex = 5;
            this._labelColon.Text = ":";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 445);
            this.Controls.Add(this._tcSeats);
            this.Controls.Add(this._rtVehicleInfo);
            this.Controls.Add(this._lvSearchResults);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._tcSeats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox _cbPowerType;
        private System.Windows.Forms.ListView _lvSearchResults;
        private System.Windows.Forms.Button _bSearch;
        private System.Windows.Forms.RichTextBox _rtVehicleInfo;
        private System.Windows.Forms.ColumnHeader _chVehicleId;
        private System.Windows.Forms.ColumnHeader _chUsedCount;
        private System.Windows.Forms.TabControl _tcSeats;
        private System.Windows.Forms.TabPage _tpMain;
        private System.Windows.Forms.Label _labelPowerType;
        private System.Windows.Forms.TextBox _tbIdOrName;
        private System.Windows.Forms.ComboBox _cbIdOrName;
        private System.Windows.Forms.Label _labelColon;
    }
}

