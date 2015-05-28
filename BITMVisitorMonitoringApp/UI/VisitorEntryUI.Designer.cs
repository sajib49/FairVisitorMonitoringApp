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
            this.saveVisitorButton = new System.Windows.Forms.Button();
            this.ChekAndUncheckButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visitor Information";
            // 
            // contactNumberEntryTextBox
            // 
            this.contactNumberEntryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contactNumberEntryTextBox.Location = new System.Drawing.Point(167, 128);
            this.contactNumberEntryTextBox.Multiline = true;
            this.contactNumberEntryTextBox.Name = "contactNumberEntryTextBox";
            this.contactNumberEntryTextBox.Size = new System.Drawing.Size(246, 31);
            this.contactNumberEntryTextBox.TabIndex = 2;
            // 
            // emailentryTextBox
            // 
            this.emailentryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.emailentryTextBox.Location = new System.Drawing.Point(167, 81);
            this.emailentryTextBox.Multiline = true;
            this.emailentryTextBox.Name = "emailentryTextBox";
            this.emailentryTextBox.Size = new System.Drawing.Size(246, 30);
            this.emailentryTextBox.TabIndex = 1;
            // 
            // nameEntryTextBox
            // 
            this.nameEntryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nameEntryTextBox.Location = new System.Drawing.Point(167, 31);
            this.nameEntryTextBox.Multiline = true;
            this.nameEntryTextBox.Name = "nameEntryTextBox";
            this.nameEntryTextBox.Size = new System.Drawing.Size(246, 32);
            this.nameEntryTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contact Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // saveVisitorButton
            // 
            this.saveVisitorButton.Location = new System.Drawing.Point(547, 489);
            this.saveVisitorButton.Name = "saveVisitorButton";
            this.saveVisitorButton.Size = new System.Drawing.Size(103, 38);
            this.saveVisitorButton.TabIndex = 0;
            this.saveVisitorButton.Text = "Save";
            this.saveVisitorButton.UseVisualStyleBackColor = true;
            this.saveVisitorButton.Click += new System.EventHandler(this.saveVisitorButton_Click);
            // 
            // ChekAndUncheckButton
            // 
            this.ChekAndUncheckButton.Location = new System.Drawing.Point(287, 500);
            this.ChekAndUncheckButton.Name = "ChekAndUncheckButton";
            this.ChekAndUncheckButton.Size = new System.Drawing.Size(125, 27);
            this.ChekAndUncheckButton.TabIndex = 2;
            this.ChekAndUncheckButton.Text = "Check All";
            this.ChekAndUncheckButton.UseVisualStyleBackColor = true;
            this.ChekAndUncheckButton.Click += new System.EventHandler(this.ChekAndUncheckButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Zone Type Visitor Want To Visit";
            // 
            // VisitorEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChekAndUncheckButton);
            this.Controls.Add(this.saveVisitorButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitorEntryUI";
            this.Text = "VisitorEntryUI";
            this.Load += new System.EventHandler(this.VisitorEntryUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contactNumberEntryTextBox;
        private System.Windows.Forms.TextBox emailentryTextBox;
        private System.Windows.Forms.TextBox nameEntryTextBox;
        private System.Windows.Forms.Button saveVisitorButton;
        private System.Windows.Forms.Button ChekAndUncheckButton;
        private System.Windows.Forms.Label label4;
    }
}