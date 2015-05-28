using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BITMVisitorMonitoringApp.MODEL;

namespace BITMVisitorMonitoringApp.DAL
{
    public class VisitorGateWay
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["FairVisitorMonitorintString"].ConnectionString;
        public int InsertVisitorAndGetVisitorId(Visitor aVisitor)
        {
            SqlConnection aConnection = new SqlConnection(connectionString);
            string insertQuery = "INSERT INTO VisitorTable VALUES('"+aVisitor.name+"', '"+aVisitor.email+"', '"+aVisitor.contactNumber+"')";
            string selectQuery = "SELECT ID FROM VisitorTable WHERE Email = '" + aVisitor.email + "'";
            SqlCommand insertCommand = new SqlCommand(insertQuery, aConnection);
            SqlCommand selectCommand = new SqlCommand(selectQuery, aConnection);

            aConnection.Open();

            insertCommand.ExecuteNonQuery();
            SqlDataReader idReader = selectCommand.ExecuteReader();
            int id = 0;
            while (idReader.Read())
            {
                id = int.Parse(idReader["ID"].ToString());
            }
            idReader.Close();
            aConnection.Close();
            return id;
        }

        public int InsertVisitorInterestedZones(int visitorId, List<Zone> visitorInterestedZoneList)
        {

            int rowEffect = 0;
               SqlConnection aConnection = new SqlConnection(connectionString);
             foreach (Zone aZone in visitorInterestedZoneList)
            {
                string query = "INSERT INTO VisitorZoneTable VALUES('" + visitorId + "', '" + aZone.zoneId + "')";
                SqlCommand aCommand = new SqlCommand(query, aConnection);
                aConnection.Open();
               rowEffect = aCommand.ExecuteNonQuery();
                aConnection.Close();
            }

            return rowEffect;

        }

  

        public List<Visitor> GetVisitorByZoneId(int zoneId)
        {
            SqlConnection aConnection = new SqlConnection(connectionString);
            string query = "SELECT Name,Email,ContactNumber FROM VisitorDetailView WHERE ZoneId = '" + zoneId + "'";
            SqlCommand aCommand = new SqlCommand(query,aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Visitor> visitorList =new List<Visitor>();
            while (aReader.Read())
            {
                
                Visitor aVisitor = new Visitor();
                aVisitor.name = aReader["Name"].ToString();
                aVisitor.email = aReader["Email"].ToString();
                aVisitor.contactNumber = aReader["ContactNumber"].ToString();
                visitorList.Add(aVisitor);
            }
            
            aReader.Close();
            aConnection.Close();
            return visitorList;

        }

        public int GetVisitorByZone(int zoneId)
        {
            int count =0;
            SqlConnection aConnection = new SqlConnection(connectionString);
            string query = "SELECT Name FROM VisitorDetailView WHERE ZoneId = '" + zoneId + "'";
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                count++;
            }

            aReader.Close();
            aConnection.Close();
            return count;
        }
    }
  }
