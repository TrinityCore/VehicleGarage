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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
            this._gbAdvancedFilter = new System.Windows.Forms.GroupBox();
            this._tbAdvancedFilter2 = new System.Windows.Forms.TextBox();
            this._tbAdvancedFilter1 = new System.Windows.Forms.TextBox();
            this._cbAdvancedFilter2 = new System.Windows.Forms.ComboBox();
            this._cbAdvancedFilter1 = new System.Windows.Forms.ComboBox();
            this._gbVehicleSearch = new System.Windows.Forms.GroupBox();
            this._tbVehicleSeatFlags = new System.Windows.Forms.TextBox();
            this._cbVehicleSeatFlagsOperator = new System.Windows.Forms.ComboBox();
            this._labelVehicleSeatFlags = new System.Windows.Forms.Label();
            this._cbVehicleFlagsOperator = new System.Windows.Forms.ComboBox();
            this._tbVehicleFlags = new System.Windows.Forms.TextBox();
            this._labelVehicleFlags = new System.Windows.Forms.Label();
            this._labelVehicleSeatFlagsB = new System.Windows.Forms.Label();
            this._tbVehicleSeatFlagsB = new System.Windows.Forms.TextBox();
            this._cbVehicleSeatFlagsBOperator = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._tcSeats.SuspendLayout();
            this._gbAdvancedFilter.SuspendLayout();
            this._gbVehicleSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _bSearch
            // 
            this._bSearch.Location = new System.Drawing.Point(559, 401);
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
            this._cbPowerType.Location = new System.Drawing.Point(120, 122);
            this._cbPowerType.Name = "_cbPowerType";
            this._cbPowerType.Size = new System.Drawing.Size(99, 21);
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
            this._lvSearchResults.Location = new System.Drawing.Point(370, 276);
            this._lvSearchResults.MultiSelect = false;
            this._lvSearchResults.Name = "_lvSearchResults";
            this._lvSearchResults.Size = new System.Drawing.Size(146, 144);
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
            this._rtVehicleInfo.Location = new System.Drawing.Point(20, 43);
            this._rtVehicleInfo.Name = "_rtVehicleInfo";
            this._rtVehicleInfo.Size = new System.Drawing.Size(323, 377);
            this._rtVehicleInfo.TabIndex = 8;
            this._rtVehicleInfo.Text = "";
            this._rtVehicleInfo.TextChanged += new System.EventHandler(this._rtVehicleInfo_TextChanged);
            // 
            // _tcSeats
            // 
            this._tcSeats.Controls.Add(this._tpMain);
            this._tcSeats.Location = new System.Drawing.Point(20, 27);
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
            this._labelPowerType.Location = new System.Drawing.Point(13, 125);
            this._labelPowerType.Name = "_labelPowerType";
            this._labelPowerType.Size = new System.Drawing.Size(63, 13);
            this._labelPowerType.TabIndex = 2;
            this._labelPowerType.Text = "Power type:";
            // 
            // _tbIdOrName
            // 
            this._tbIdOrName.Location = new System.Drawing.Point(120, 22);
            this._tbIdOrName.Name = "_tbIdOrName";
            this._tbIdOrName.Size = new System.Drawing.Size(99, 20);
            this._tbIdOrName.TabIndex = 3;
            // 
            // _cbIdOrName
            // 
            this._cbIdOrName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbIdOrName.FormattingEnabled = true;
            this._cbIdOrName.Items.AddRange(new object[] {
            "Vehicle ID",
            "Creature ID",
            "Creature Name"});
            this._cbIdOrName.Location = new System.Drawing.Point(15, 22);
            this._cbIdOrName.Name = "_cbIdOrName";
            this._cbIdOrName.Size = new System.Drawing.Size(94, 21);
            this._cbIdOrName.TabIndex = 4;
            // 
            // _gbAdvancedFilter
            // 
            this._gbAdvancedFilter.Controls.Add(this._tbAdvancedFilter2);
            this._gbAdvancedFilter.Controls.Add(this._tbAdvancedFilter1);
            this._gbAdvancedFilter.Controls.Add(this._cbAdvancedFilter2);
            this._gbAdvancedFilter.Controls.Add(this._cbAdvancedFilter1);
            this._gbAdvancedFilter.Location = new System.Drawing.Point(359, 189);
            this._gbAdvancedFilter.Name = "_gbAdvancedFilter";
            this._gbAdvancedFilter.Size = new System.Drawing.Size(304, 81);
            this._gbAdvancedFilter.TabIndex = 10;
            this._gbAdvancedFilter.TabStop = false;
            this._gbAdvancedFilter.Text = "Advanced Filter";
            // 
            // _tbAdvancedFilter2
            // 
            this._tbAdvancedFilter2.Location = new System.Drawing.Point(207, 50);
            this._tbAdvancedFilter2.Name = "_tbAdvancedFilter2";
            this._tbAdvancedFilter2.Size = new System.Drawing.Size(87, 20);
            this._tbAdvancedFilter2.TabIndex = 3;
            // 
            // _tbAdvancedFilter1
            // 
            this._tbAdvancedFilter1.Location = new System.Drawing.Point(207, 23);
            this._tbAdvancedFilter1.Name = "_tbAdvancedFilter1";
            this._tbAdvancedFilter1.Size = new System.Drawing.Size(87, 20);
            this._tbAdvancedFilter1.TabIndex = 2;
            // 
            // _cbAdvancedFilter2
            // 
            this._cbAdvancedFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter2.FormattingEnabled = true;
            this._cbAdvancedFilter2.Location = new System.Drawing.Point(11, 50);
            this._cbAdvancedFilter2.Name = "_cbAdvancedFilter2";
            this._cbAdvancedFilter2.Size = new System.Drawing.Size(190, 21);
            this._cbAdvancedFilter2.TabIndex = 1;
            // 
            // _cbAdvancedFilter1
            // 
            this._cbAdvancedFilter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbAdvancedFilter1.FormattingEnabled = true;
            this._cbAdvancedFilter1.Location = new System.Drawing.Point(11, 23);
            this._cbAdvancedFilter1.Name = "_cbAdvancedFilter1";
            this._cbAdvancedFilter1.Size = new System.Drawing.Size(190, 21);
            this._cbAdvancedFilter1.TabIndex = 0;
            // 
            // _gbVehicleSearch
            // 
            this._gbVehicleSearch.Controls.Add(this._cbVehicleSeatFlagsBOperator);
            this._gbVehicleSearch.Controls.Add(this._tbVehicleSeatFlagsB);
            this._gbVehicleSearch.Controls.Add(this._labelVehicleSeatFlagsB);
            this._gbVehicleSearch.Controls.Add(this._tbVehicleSeatFlags);
            this._gbVehicleSearch.Controls.Add(this._cbVehicleSeatFlagsOperator);
            this._gbVehicleSearch.Controls.Add(this._labelVehicleSeatFlags);
            this._gbVehicleSearch.Controls.Add(this._cbVehicleFlagsOperator);
            this._gbVehicleSearch.Controls.Add(this._tbVehicleFlags);
            this._gbVehicleSearch.Controls.Add(this._labelVehicleFlags);
            this._gbVehicleSearch.Controls.Add(this._tbIdOrName);
            this._gbVehicleSearch.Controls.Add(this._cbIdOrName);
            this._gbVehicleSearch.Controls.Add(this._labelPowerType);
            this._gbVehicleSearch.Controls.Add(this._cbPowerType);
            this._gbVehicleSearch.Location = new System.Drawing.Point(359, 27);
            this._gbVehicleSearch.Name = "_gbVehicleSearch";
            this._gbVehicleSearch.Size = new System.Drawing.Size(304, 156);
            this._gbVehicleSearch.TabIndex = 11;
            this._gbVehicleSearch.TabStop = false;
            this._gbVehicleSearch.Text = "Vehicle Search";
            // 
            // _tbVehicleSeatFlags
            // 
            this._tbVehicleSeatFlags.Location = new System.Drawing.Point(120, 75);
            this._tbVehicleSeatFlags.Name = "_tbVehicleSeatFlags";
            this._tbVehicleSeatFlags.Size = new System.Drawing.Size(99, 20);
            this._tbVehicleSeatFlags.TabIndex = 10;
            // 
            // _cbVehicleSeatFlagsOperator
            // 
            this._cbVehicleSeatFlagsOperator.FormattingEnabled = true;
            this._cbVehicleSeatFlagsOperator.Items.AddRange(new object[] {
            "!= 0",
            "== 0"});
            this._cbVehicleSeatFlagsOperator.Location = new System.Drawing.Point(225, 74);
            this._cbVehicleSeatFlagsOperator.Name = "_cbVehicleSeatFlagsOperator";
            this._cbVehicleSeatFlagsOperator.Size = new System.Drawing.Size(69, 21);
            this._cbVehicleSeatFlagsOperator.TabIndex = 9;
            // 
            // _labelVehicleSeatFlags
            // 
            this._labelVehicleSeatFlags.AutoSize = true;
            this._labelVehicleSeatFlags.Location = new System.Drawing.Point(13, 78);
            this._labelVehicleSeatFlags.Name = "_labelVehicleSeatFlags";
            this._labelVehicleSeatFlags.Size = new System.Drawing.Size(101, 13);
            this._labelVehicleSeatFlags.TabIndex = 8;
            this._labelVehicleSeatFlags.Text = "VehicleSeatFlags &&:";
            // 
            // _cbVehicleFlagsOperator
            // 
            this._cbVehicleFlagsOperator.FormattingEnabled = true;
            this._cbVehicleFlagsOperator.Items.AddRange(new object[] {
            "!= 0",
            "== 0"});
            this._cbVehicleFlagsOperator.Location = new System.Drawing.Point(225, 50);
            this._cbVehicleFlagsOperator.Name = "_cbVehicleFlagsOperator";
            this._cbVehicleFlagsOperator.Size = new System.Drawing.Size(69, 21);
            this._cbVehicleFlagsOperator.TabIndex = 7;
            // 
            // _tbVehicleFlags
            // 
            this._tbVehicleFlags.Location = new System.Drawing.Point(120, 49);
            this._tbVehicleFlags.Name = "_tbVehicleFlags";
            this._tbVehicleFlags.Size = new System.Drawing.Size(99, 20);
            this._tbVehicleFlags.TabIndex = 6;
            // 
            // _labelVehicleFlags
            // 
            this._labelVehicleFlags.AutoSize = true;
            this._labelVehicleFlags.Location = new System.Drawing.Point(13, 56);
            this._labelVehicleFlags.Name = "_labelVehicleFlags";
            this._labelVehicleFlags.Size = new System.Drawing.Size(79, 13);
            this._labelVehicleFlags.TabIndex = 5;
            this._labelVehicleFlags.Text = "VehicleFlags &&:";
            // 
            // _labelVehicleSeatFlagsB
            // 
            this._labelVehicleSeatFlagsB.AutoSize = true;
            this._labelVehicleSeatFlagsB.Location = new System.Drawing.Point(13, 102);
            this._labelVehicleSeatFlagsB.Name = "_labelVehicleSeatFlagsB";
            this._labelVehicleSeatFlagsB.Size = new System.Drawing.Size(108, 13);
            this._labelVehicleSeatFlagsB.TabIndex = 11;
            this._labelVehicleSeatFlagsB.Text = "VehicleSeatFlagsB &&:";
            // 
            // _tbVehicleSeatFlagsB
            // 
            this._tbVehicleSeatFlagsB.Location = new System.Drawing.Point(120, 99);
            this._tbVehicleSeatFlagsB.Name = "_tbVehicleSeatFlagsB";
            this._tbVehicleSeatFlagsB.Size = new System.Drawing.Size(99, 20);
            this._tbVehicleSeatFlagsB.TabIndex = 12;
            // 
            // _cbVehicleSeatFlagsBOperator
            // 
            this._cbVehicleSeatFlagsBOperator.FormattingEnabled = true;
            this._cbVehicleSeatFlagsBOperator.Items.AddRange(new object[] {
            "!= 0",
            "== 0"});
            this._cbVehicleSeatFlagsBOperator.Location = new System.Drawing.Point(225, 98);
            this._cbVehicleSeatFlagsBOperator.Name = "_cbVehicleSeatFlagsBOperator";
            this._cbVehicleSeatFlagsBOperator.Size = new System.Drawing.Size(69, 21);
            this._cbVehicleSeatFlagsBOperator.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "About...";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 440);
            this.Controls.Add(this._gbVehicleSearch);
            this.Controls.Add(this._gbAdvancedFilter);
            this.Controls.Add(this._bSearch);
            this.Controls.Add(this._tcSeats);
            this.Controls.Add(this._rtVehicleInfo);
            this.Controls.Add(this._lvSearchResults);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Vehicle Garage";
            this._tcSeats.ResumeLayout(false);
            this._gbAdvancedFilter.ResumeLayout(false);
            this._gbAdvancedFilter.PerformLayout();
            this._gbVehicleSearch.ResumeLayout(false);
            this._gbVehicleSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox _gbAdvancedFilter;
        private System.Windows.Forms.GroupBox _gbVehicleSearch;
        private System.Windows.Forms.TextBox _tbAdvancedFilter2;
        private System.Windows.Forms.TextBox _tbAdvancedFilter1;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter2;
        private System.Windows.Forms.ComboBox _cbAdvancedFilter1;
        private System.Windows.Forms.ComboBox _cbVehicleFlagsOperator;
        private System.Windows.Forms.TextBox _tbVehicleFlags;
        private System.Windows.Forms.Label _labelVehicleFlags;
        private System.Windows.Forms.Label _labelVehicleSeatFlags;
        private System.Windows.Forms.TextBox _tbVehicleSeatFlags;
        private System.Windows.Forms.ComboBox _cbVehicleSeatFlagsOperator;
        private System.Windows.Forms.Label _labelVehicleSeatFlagsB;
        private System.Windows.Forms.TextBox _tbVehicleSeatFlagsB;
        private System.Windows.Forms.ComboBox _cbVehicleSeatFlagsBOperator;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

