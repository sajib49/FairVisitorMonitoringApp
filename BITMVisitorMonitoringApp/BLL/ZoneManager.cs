using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BITMVisitorMonitoringApp.MODEL;
using VisitorMonitoringApp.DAL;

namespace VisitorMonitoringApp.BLL
{
    
    public class ZoneManager
    {
        ZoneGateWay aZoneGateWay = new ZoneGateWay();

        public string InsertZone(Zone aZone)
        {
            int isInsert = aZoneGateWay.InsertZone(aZone);
            
            if (isInsert>0)
            {
                return "Zone type name has been successfully stored. ";
            }
            else
            {
                return "Sorry! Zone has not been successfully stored.";
            }
        }

        public List<Zone> GetAllZone()
        {
            return  aZoneGateWay.GetAllZone();
        }

  
    }
}
