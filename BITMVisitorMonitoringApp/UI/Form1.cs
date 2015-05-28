using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitorMonitoringApp.UI;

namespace VisitorMonitoringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI aVisitorEntryUi = new VisitorEntryUI();
            aVisitorEntryUi.Show();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeUI aZoneTypeUi = new ZoneTypeUI();
            aZoneTypeUi.Show();
        }

        private void zoneSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorDetailUI aZoneSpecificVisitorDetailUi = new ZoneSpecificVisitorDetailUI();
            aZoneSpecificVisitorDetailUi.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberUI aZoneWiseVisitorNumberUi = new ZoneWiseVisitorNumberUI();
            aZoneWiseVisitorNumberUi.Show();
        }
    }
}
