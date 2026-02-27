using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities
{
    public class LocationCreation
    {
        public int sectionLocID { get; set; }

        public string sectionLocName { get; set; }

        public string sectionLocCode { get; set; }

        public string  sectionLocAddress  { get; set; }

        public string sectionLocCellNo { get; set; }

        public string sectionLocEmailAddress { get; set; }

        public string sectionLocReportTitle { get; set; }
        
        public string sectionLocDbName { get; set; }
        
        public string sectionLocIpAddress { get; set; }
        
        public string sectionLocUserName { get; set; }
        
        public string sectionLocPassword { get; set; }
        
        public int sectionTypeID  { get; set; }

        public int isHardArea { get; set; }

        public int isTaxExempt { get; set; }

        public int userID {get; set;}

        public string spType { get; set; }    

        public int isActive { get; set; }
           
    }
}