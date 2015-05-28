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
    public partial class ZoneWiseVisitorNumberUI : Form
    {

        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
        }

        private VisitorManager aVisitorManager = new VisitorManager();
        private ZoneManager aZoneManager = new ZoneManager();

        private void ZoneWiseVisitorNumberUI_Load(object sender, EventArgs e)
        {

            List<Zone> zonesList = aZoneManager.GetAllZone();
            List<Zone> finalZoneList =new List<Zone>();
            
            foreach (Zone aZone in zonesList)
            {

                aZone.numberOfVisitor = aVisitorManager.GetVisitorByZone(aZone.zoneId);

                finalZoneList.Add(aZone);

            }

            
            foreach (Zone aZone in finalZoneList)
            {
                ListViewItem item = new ListViewItem(aZone.zoneName);
                item.SubItems.Add(aZone.numberOfVisitor.ToString());
                showAllVisitorNumberListBox.Items.Add(item);

            }
            int totalVisitor = aVisitorManager.GetTotalVisitor();
            totalVisitorTextBox.Text = totalVisitor.ToString();

        }
    }
}