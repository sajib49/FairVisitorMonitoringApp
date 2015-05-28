using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITMVisitorMonitoringApp.BLL;
using BITMVisitorMonitoringApp.MODEL;
using VisitorMonitoringApp.BLL;

namespace VisitorMonitoringApp.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }

        static ZoneManager aZoneManager =new ZoneManager();
        List<Zone> zoneList = aZoneManager.GetAllZone();
        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {

            CreateCheckBoxes();
        }
        List<CheckBox> CheckBoxes = new List<CheckBox>();
        private void CreateCheckBoxes()
        {
            
            int intialTop = 240;
            foreach (Zone aZone in zoneList)
            {
                CheckBox chk = new CheckBox();
                chk.Top = intialTop;
                chk.AutoSize = true;
                chk.Left = 250;
                chk.Text = aZone.zoneName;
                chk.Name = aZone.zoneName+"CheckBox";
                chk.Tag = aZone;
                this.Controls.Add(chk);
                CheckBoxes.Add(chk);
                intialTop += 20;
            
            }
        }

        Visitor aVisitor = new Visitor();
        VisitorManager aVisitorManager = new VisitorManager();
        private void saveVisitorButton_Click(object sender, EventArgs e)
        {
            
            if (nameEntryTextBox.Text != "" && emailentryTextBox.Text != "" && contactNumberEntryTextBox.Text!="")
            {
                List<Zone> visitorInterestedZoneList = new List<Zone>();
                aVisitor.name = nameEntryTextBox.Text;
                aVisitor.email = emailentryTextBox.Text;
                aVisitor.contactNumber = contactNumberEntryTextBox.Text;

                int visitorId = aVisitorManager.InsertVisitorAndGetVisitorId(aVisitor);


                foreach (CheckBox aCheckBox in CheckBoxes)
                {
                    if (aCheckBox.Checked)
                    {
                        Zone aZone = (Zone)aCheckBox.Tag;
                        visitorInterestedZoneList.Add(aZone);
                    }
                }

                string isSuccessfullyInsert = aVisitorManager.InsertVisitorInterestedZones(visitorId, visitorInterestedZoneList);
                ClearAllBoxes();
                MessageBox.Show(isSuccessfullyInsert);
            }

            else
            {
                MessageBox.Show("Insert Visitor Info First.\n");
            }
            
        }

        public void ClearAllBoxes()
        {
             nameEntryTextBox.Text ="";
             emailentryTextBox.Text="";
            contactNumberEntryTextBox.Text="";

            foreach (CheckBox aCheckBox in CheckBoxes)
            {
                if (aCheckBox.Checked == true)
                {
                    aCheckBox.Checked = false;
                }
            }
            
        }

        private void ChekAndUncheckButton_Click(object sender, EventArgs e)
        {
            foreach (CheckBox aCheckBox in CheckBoxes)
            {
                if (aCheckBox.Checked == false)
                {
                    aCheckBox.Checked = true;
                    ChekAndUncheckButton.Text = "Uncheck All";
                }

                else
                {
                    aCheckBox.Checked = false;
                    ChekAndUncheckButton.Text = "Check All";
                }
            }
        }
       

        
    }
}
