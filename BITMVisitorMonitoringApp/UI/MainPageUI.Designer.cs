namespace VisitorMonitoringApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneWiseVisitorNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = " Visitor Entry";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneSpecificToolStripMenuItem,
            this.zoneWiseVisitorNumberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneSpecificToolStripMenuItem
            // 
            this.zoneSpecificToolStripMenuItem.Name = "zoneSpecificToolStripMenuItem";
            this.zoneSpecificToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.zoneSpecificToolStripMenuItem.Text = "Zone Specific Visitor Detail";
            this.zoneSpecificToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificToolStripMenuItem_Click);
            // 
            // zoneWiseVisitorNumberToolStripMenuItem
            // 
            this.zoneWiseVisitorNumberToolStripMenuItem.Name = "zoneWiseVisitorNumberToolStripMenuItem";
            this.zoneWiseVisitorNumberToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.zoneWiseVisitorNumberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.zoneWiseVisitorNumberToolStripMenuItem.Click += new System.EventHandler(this.zoneWiseVisitorNumberToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Developed By\r\nSaidujjaman Sajib\r\nSEIP: 100527\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(281, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "WelCome To Fair";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Main Area";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneWiseVisitorNumberToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

