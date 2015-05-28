using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITMVisitorMonitoringApp.DAL;
using BITMVisitorMonitoringApp.MODEL;

namespace BITMVisitorMonitoringApp.BLL
{
    public class VisitorManager
    {
        VisitorGateWay aVisitorGateWay = new VisitorGateWay();
        public int InsertVisitorAndGetVisitorId(Visitor aVisitor)
        {
            int visitorId  = aVisitorGateWay.InsertVisitorAndGetVisitorId(aVisitor);
            return visitorId;

        }

        public string InsertVisitorInterestedZones(int visitorId, List<Zone> visitorInterestedZoneList)
        {
            
            int isSuccessfullyInsert = aVisitorGateWay.InsertVisitorInterestedZones(visitorId, visitorInterestedZoneList);
            if (isSuccessfullyInsert>0)
            {
                return "Visitor has been successfully insert. Thank You.";
            }
            else
            {
                return "Sorry visitor has not been insert! Try again. ";
            }
        }


        public List<Visitor> GetVisitorByZoneId(int zoneId)
        {
            return aVisitorGateWay.GetVisitorByZoneId(zoneId);
        }

        public int GetVisitorByZone(int zoneId)
        {
            return aVisitorGateWay.GetVisitorByZone(zoneId);
        }
    }
}
