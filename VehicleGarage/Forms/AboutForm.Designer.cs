namespace VehicleGarage.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this._gbAcknowledgements = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this._gbVersion = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this._gbAcknowledgements.SuspendLayout();
            this._gbVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // _gbAcknowledgements
            // 
            this._gbAcknowledgements.Controls.Add(this.richTextBox1);
            this._gbAcknowledgements.Location = new System.Drawing.Point(13, 11);
            this._gbAcknowledgements.Name = "_gbAcknowledgements";
            this._gbAcknowledgements.Size = new System.Drawing.Size(261, 151);
            this._gbAcknowledgements.TabIndex = 0;
            this._gbAcknowledgements.TabStop = false;
            this._gbAcknowledgements.Text = "Acknowledgements";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(13, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 129);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // _buttonOk
            // 
            this._buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._buttonOk.Location = new System.Drawing.Point(87, 219);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(102, 24);
            this._buttonOk.TabIndex = 1;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = true;
            // 
            // _gbVersion
            // 
            this._gbVersion.Controls.Add(this.richTextBox2);
            this._gbVersion.Location = new System.Drawing.Point(17, 171);
            this._gbVersion.Name = "_gbVersion";
            this._gbVersion.Size = new System.Drawing.Size(256, 42);
            this._gbVersion.TabIndex = 2;
            this._gbVersion.TabStop = false;
            this._gbVersion.Text = "Version";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(9, 21);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(238, 24);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "Supports client build 12340.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this._gbVersion);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._gbAcknowledgements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Vehicle Garage";
            this._gbAcknowledgements.ResumeLayout(false);
            this._gbVersion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbAcknowledgements;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.GroupBox _gbVersion;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}