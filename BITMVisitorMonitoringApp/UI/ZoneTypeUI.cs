using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITMVisitorMonitoringApp.MODEL;
using VisitorMonitoringApp.BLL;

namespace VisitorMonitoringApp.UI
{
    public partial class ZoneTypeUI : Form
    {
        public ZoneTypeUI()
        {
            InitializeComponent();
        }

        static ZoneManager aZoneManager = new ZoneManager();
        
        private void saveZoneNameButton_Click(object sender, EventArgs e)
        {
            InsertAllZone();
            showAllZoneInListView();

        }

        public void InsertAllZone()
        {
            if (zoneTypeNameTextBox.Text != "")
            {
                Zone aZone = new Zone();
                string isSuccessfullyInsert = "";
                string zoneTypeName = zoneTypeNameTextBox.Text;
                aZone.zoneName = zoneTypeName;
                isSuccessfullyInsert = aZoneManager.InsertZone(aZone);
                zoneTypeNameTextBox.Text = string.Empty;
                MessageBox.Show(isSuccessfullyInsert);
            }
            else
            {
                MessageBox.Show("Please Insert a name first.");
            }
            
        }

        
        private void ZoneTypeUI_Load(object sender, EventArgs e)
        {
            showAllZoneInListView();
        }

        public void showAllZoneInListView()
        {
             List<Zone> zoneList = aZoneManager.GetAllZone(); 
            int i = 1;
            zoneTypeListView.Items.Clear();
            foreach (Zone aZone in zoneList)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(aZone.zoneName);

                zoneTypeListView.Items.Add(item);
                i++;
            }
        }

        
    }
}
