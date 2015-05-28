namespace VisitorMonitoringApp.UI
{
    partial class ZoneSpecificVisitorDetailUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalVisitorByZoneTextBox = new System.Windows.Forms.TextBox();
            this.visitorListByZoneId = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.showVisitorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Zone";
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(134, 40);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(314, 28);
            this.selectZoneComboBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(459, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export to Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createExelFileButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(387, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total";
            // 
            // totalVisitorByZoneTextBox
            // 
            this.totalVisitorByZoneTextBox.Location = new System.Drawing.Point(446, 354);
            this.totalVisitorByZoneTextBox.Multiline = true;
            this.totalVisitorByZoneTextBox.Name = "totalVisitorByZoneTextBox";
            this.totalVisitorByZoneTextBox.Size = new System.Drawing.Size(148, 33);
            this.totalVisitorByZoneTextBox.TabIndex = 5;
            // 
            // visitorListByZoneId
            // 
            this.visitorListByZoneId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.visitorListByZoneId.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.visitorListByZoneId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visitorListByZoneId.FullRowSelect = true;
            this.visitorListByZoneId.GridLines = true;
            this.visitorListByZoneId.Location = new System.Drawing.Point(49, 133);
            this.visitorListByZoneId.Name = "visitorListByZoneId";
            this.visitorListByZoneId.Size = new System.Drawing.Size(545, 192);
            this.visitorListByZoneId.TabIndex = 6;
            this.visitorListByZoneId.UseCompatibleStateImageBehavior = false;
            this.visitorListByZoneId.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 135;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 207;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 179;
            // 
            // showVisitorButton
            // 
            this.showVisitorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVisitorButton.Location = new System.Drawing.Point(469, 34);
            this.showVisitorButton.Name = "showVisitorButton";
            this.showVisitorButton.Size = new System.Drawing.Size(143, 38);
            this.showVisitorButton.TabIndex = 7;
            this.showVisitorButton.Text = "Show";
            this.showVisitorButton.UseVisualStyleBackColor = true;
            this.showVisitorButton.Click += new System.EventHandler(this.showVisitorButton_Click);
            // 
            // ZoneSpecificVisitorDetailUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 462);
            this.Controls.Add(this.showVisitorButton);
            this.Controls.Add(this.visitorListByZoneId);
            this.Controls.Add(this.totalVisitorByZoneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectZoneComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorDetailUI";
            this.Text = "ZoneSpecificVisitorDetailUI";
            this.Load += new System.EventHandler(this.ZoneSpecificVisitorDetailUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalVisitorByZoneTextBox;
        private System.Windows.Forms.ListView visitorListByZoneId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button showVisitorButton;
    }
}