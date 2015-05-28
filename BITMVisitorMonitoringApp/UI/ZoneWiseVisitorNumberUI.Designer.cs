namespace VisitorMonitoringApp.UI
{
    partial class ZoneWiseVisitorNumberUI
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
            this.showAllVisitorNumberListBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisitorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showAllVisitorNumberListBox
            // 
            this.showAllVisitorNumberListBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.showAllVisitorNumberListBox.FullRowSelect = true;
            this.showAllVisitorNumberListBox.GridLines = true;
            this.showAllVisitorNumberListBox.Location = new System.Drawing.Point(30, 35);
            this.showAllVisitorNumberListBox.Name = "showAllVisitorNumberListBox";
            this.showAllVisitorNumberListBox.Size = new System.Drawing.Size(439, 156);
            this.showAllVisitorNumberListBox.TabIndex = 0;
            this.showAllVisitorNumberListBox.UseCompatibleStateImageBehavior = false;
            this.showAllVisitorNumberListBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 269;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No. of Visitor";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // totalVisitorTextBox
            // 
            this.totalVisitorTextBox.Location = new System.Drawing.Point(266, 220);
            this.totalVisitorTextBox.Name = "totalVisitorTextBox";
            this.totalVisitorTextBox.Size = new System.Drawing.Size(184, 20);
            this.totalVisitorTextBox.TabIndex = 2;
            // 
            // ZoneWiseVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 275);
            this.Controls.Add(this.totalVisitorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showAllVisitorNumberListBox);
            this.Name = "ZoneWiseVisitorNumberUI";
            this.Text = "ZoneWiseVisitorNumberUI";
            this.Load += new System.EventHandler(this.ZoneWiseVisitorNumberUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView showAllVisitorNumberListBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalVisitorTextBox;
    }
}