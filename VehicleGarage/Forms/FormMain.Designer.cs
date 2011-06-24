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
            this._rtbSeatInfo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._bSearch);
            this.panel1.Controls.Add(this._cbPowerType);
            this.panel1.Location = new System.Drawing.Point(370, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 183);
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
            this._cbPowerType.Location = new System.Drawing.Point(17, 17);
            this._cbPowerType.Name = "_cbPowerType";
            this._cbPowerType.Size = new System.Drawing.Size(140, 21);
            this._cbPowerType.TabIndex = 0;
            this._cbPowerType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // _lvSearchResults
            // 
            this._lvSearchResults.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
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
            this._tcSeats.Location = new System.Drawing.Point(20, 392);
            this._tcSeats.Name = "_tcSeats";
            this._tcSeats.SelectedIndex = 0;
            this._tcSeats.Size = new System.Drawing.Size(323, 18);
            this._tcSeats.TabIndex = 9;
            this._tcSeats.SelectedIndexChanged += new System.EventHandler(this._tcSeats_SelectedIndexChanged);
            // 
            // _rtbSeatInfo
            // 
            this._rtbSeatInfo.Location = new System.Drawing.Point(19, 416);
            this._rtbSeatInfo.Name = "_rtbSeatInfo";
            this._rtbSeatInfo.Size = new System.Drawing.Size(324, 91);
            this._rtbSeatInfo.TabIndex = 10;
            this._rtbSeatInfo.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 517);
            this.Controls.Add(this._rtbSeatInfo);
            this.Controls.Add(this._tcSeats);
            this.Controls.Add(this._rtVehicleInfo);
            this.Controls.Add(this._lvSearchResults);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox _rtbSeatInfo;
    }
}

