namespace VisitorMonitoringApp.UI
{
    partial class VisitorEntryUI
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
            this.contactNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailentryTextBox = new System.Windows.Forms.TextBox();
            this.nameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveVisitorButton = new System.Windows.Forms.Button();
            this.ChekAndUncheckButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contactNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.emailentryTextBox);
            this.groupBox1.Controls.Add(this.nameEntryTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(89, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor Information";
            // 
            // contactNumberEntryTextBox
            // 
            this.contactNumberEntryTextBox.Location = new System.Drawing.Point(143, 116);
            this.contactNumberEntryTextBox.Name = "contactNumberEntryTextBox";
            this.contactNumberEntryTextBox.Size = new System.Drawing.Size(213, 20);
            this.contactNumberEntryTextBox.TabIndex = 2;
            // 
            // emailentryTextBox
            // 
            this.emailentryTextBox.Location = new System.Drawing.Point(143, 78);
            this.emailentryTextBox.Name = "emailentryTextBox";
            this.emailentryTextBox.Size = new System.Drawing.Size(213, 20);
            this.emailentryTextBox.TabIndex = 1;
            // 
            // nameEntryTextBox
            // 
            this.nameEntryTextBox.Location = new System.Drawing.Point(143, 39);
            this.nameEntryTextBox.Name = "nameEntryTextBox";
            this.nameEntryTextBox.Size = new System.Drawing.Size(213, 20);
            this.nameEntryTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(76, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 36);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone Type Visitor Want To Visit";
            // 
            // saveVisitorButton
            // 
            this.saveVisitorButton.Location = new System.Drawing.Point(537, 413);
            this.saveVisitorButton.Name = "saveVisitorButton";
            this.saveVisitorButton.Size = new System.Drawing.Size(91, 38);
            this.saveVisitorButton.TabIndex = 0;
            this.saveVisitorButton.Text = "Save";
            this.saveVisitorButton.UseVisualStyleBackColor = true;
            this.saveVisitorButton.Click += new System.EventHandler(this.saveVisitorButton_Click);
            // 
            // ChekAndUncheckButton
            // 
            this.ChekAndUncheckButton.Location = new System.Drawing.Point(287, 424);
            this.ChekAndUncheckButton.Name = "ChekAndUncheckButton";
            this.ChekAndUncheckButton.Size = new System.Drawing.Size(125, 27);
            this.ChekAndUncheckButton.TabIndex = 2;
            this.ChekAndUncheckButton.Text = "Check All";
            this.ChekAndUncheckButton.UseVisualStyleBackColor = true;
            this.ChekAndUncheckButton.Click += new System.EventHandler(this.ChekAndUncheckButton_Click);
            // 
            // VisitorEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 478);
            this.Controls.Add(this.ChekAndUncheckButton);
            this.Controls.Add(this.saveVisitorButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorEntryUI";
            this.Text = "VisitorEntryUI";
            this.Load += new System.EventHandler(this.VisitorEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactNumberEntryTextBox;
        private System.Windows.Forms.TextBox emailentryTextBox;
        private System.Windows.Forms.TextBox nameEntryTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveVisitorButton;
        private System.Windows.Forms.Button ChekAndUncheckButton;
    }
}