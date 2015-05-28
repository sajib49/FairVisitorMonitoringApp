using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using BITMVisitorMonitoringApp.MODEL;

namespace VisitorMonitoringApp.DAL
{
    public class ZoneGateWay
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FairVisitorMonitorintString"].ConnectionString;
        public int InsertZone(Zone aZone)
        {
            SqlConnection aConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO ZoneTable VALUES('" + aZone.zoneName + "')";
            SqlCommand aCommand =new SqlCommand(query,aConnection);
            aConnection.Open();
            int rowEffect = aCommand.ExecuteNonQuery();
            aConnection.Close();
            return rowEffect;

        }

        public List<Zone> GetAllZone()
        {
            SqlConnection aConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ZoneTable";
            SqlCommand aCommand = new SqlCommand(query,aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();

            List<Zone> ZoneList = new List<Zone>();
            while (aReader.Read())
            {
                Zone aZone = new Zone();
                aZone.zoneId = int.Parse(aReader["ID"].ToString());
                aZone.zoneName = aReader["ZoneName"].ToString();
                ZoneList.Add(aZone);
            }
            aReader.Close();
            aConnection.Close();
            return ZoneList;
        }


  
    }
}
