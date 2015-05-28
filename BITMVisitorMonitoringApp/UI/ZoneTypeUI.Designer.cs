namespace VisitorMonitoringApp.UI
{
    partial class ZoneTypeUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveZoneNameButton = new System.Windows.Forms.Button();
            this.zoneTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveZoneNameButton);
            this.groupBox1.Controls.Add(this.zoneTypeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type Entry";
            // 
            // saveZoneNameButton
            // 
            this.saveZoneNameButton.Location = new System.Drawing.Point(320, 110);
            this.saveZoneNameButton.Name = "saveZoneNameButton";
            this.saveZoneNameButton.Size = new System.Drawing.Size(111, 36);
            this.saveZoneNameButton.TabIndex = 2;
            this.saveZoneNameButton.Text = "Save";
            this.saveZoneNameButton.UseVisualStyleBackColor = true;
            this.saveZoneNameButton.Click += new System.EventHandler(this.saveZoneNameButton_Click);
            // 
            // zoneTypeNameTextBox
            // 
            this.zoneTypeNameTextBox.Location = new System.Drawing.Point(167, 72);
            this.zoneTypeNameTextBox.Name = "zoneTypeNameTextBox";
            this.zoneTypeNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.zoneTypeNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone Type Name:";
            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneTypeListView.FullRowSelect = true;
            this.zoneTypeListView.GridLines = true;
            this.zoneTypeListView.Location = new System.Drawing.Point(128, 234);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(341, 112);
            this.zoneTypeListView.TabIndex = 1;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial";
            this.columnHeader1.Width = 49;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Type";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 276;
            // 
            // ZoneTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 395);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ZoneTypeUI";
            this.Text = "ZoneTypeUI";
            this.Load += new System.EventHandler(this.ZoneTypeUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveZoneNameButton;
        private System.Windows.Forms.TextBox zoneTypeNameTextBox;
        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}