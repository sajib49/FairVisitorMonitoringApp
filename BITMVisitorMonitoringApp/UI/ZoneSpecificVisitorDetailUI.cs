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
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;

namespace VisitorMonitoringApp.UI
{
    public partial class ZoneSpecificVisitorDetailUI : Form
    {
        public ZoneSpecificVisitorDetailUI()
        {
            InitializeComponent();
        }
        ZoneManager aZoneManager = new ZoneManager();
        VisitorManager aVisitorManager = new VisitorManager();
        private void ZoneSpecificVisitorDetailUI_Load(object sender, EventArgs e)
        {
            List<Zone> zoneList =aZoneManager.GetAllZone();
            selectZoneComboBox.DisplayMember = "zoneName";
            selectZoneComboBox.ValueMember = "zoneId";

            selectZoneComboBox.DataSource = null;
            selectZoneComboBox.DataSource = zoneList;

           
        }
        List<Visitor> visitorsByZoneId = new List<Visitor>();
        
        private void showVisitorButton_Click(object sender, EventArgs e)
        {
            int zoneId = int.Parse(selectZoneComboBox.SelectedValue.ToString());

            visitorsByZoneId = aVisitorManager.GetVisitorByZoneId(zoneId);
            visitorListByZoneId.Items.Clear();
            int visitorCountByZoneId = 0;
            
            foreach (Visitor aVisitor in visitorsByZoneId)
            {
                ListViewItem item = new ListViewItem(aVisitor.name);
                item.SubItems.Add(aVisitor.email);
                item.SubItems.Add(aVisitor.contactNumber);
                visitorListByZoneId.Items.Add(item);
                visitorCountByZoneId++;
            }

            totalVisitorByZoneTextBox.Text = visitorCountByZoneId.ToString();
        }

        private void createExelFileButton_Click(object sender, EventArgs e)
        {
            CreateExelFile();
            MessageBox.Show("Successfully generate exel file.\n"+ @"Check Path:F:\ASP.NET\WindowForm\BITMVisitorMonitoringApp\BITMVisitorMonitoringApp\newdoc.xls");


        }

        public void CreateExelFile()
        {
            //create new xls file
            string file = @"F:\ASP.NET\WindowForm\BITMVisitorMonitoringApp\BITMVisitorMonitoringApp\newdoc.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell("Name");
            worksheet.Cells[0, 1] = new Cell("Email");
            worksheet.Cells[0, 2] = new Cell("Contact No");

            int i = 1;
            foreach (Visitor aVisitor in visitorsByZoneId)
            {
                worksheet.Cells[i, 0] = new Cell(aVisitor.name);
                worksheet.Cells[i, 1] = new Cell(aVisitor.email);
                worksheet.Cells[i, 2] = new Cell(aVisitor.contactNumber);
                i++;
            }

            worksheet.Cells[i, 0] = new Cell("Total Visitor:");
            worksheet.Cells[i, 1] = new Cell(i - 1);
           worksheet.Cells.ColumnWidth[0, 1] = 30000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            // open xls file
            Workbook book = Workbook.Load(file);
            Worksheet sheet = book.Worksheets[0];
        }
    }
}
