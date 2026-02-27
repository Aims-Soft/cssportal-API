using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities
{
    public class trialBalanceCreation   // fields for the page trial balance config
    {
        public int sectionLocID { get; set; }

        public int trialBalanceNameID { get; set; }

        public string trialBalanceShortName { get; set; }
        
        public string trialBalanceFullName { get; set; }
        
        public string spType { get; set; } 

        public int userID {get; set;}

        public int projectID { get; set; }

        public Nullable<int> projectPackageID { get; set; }
        
        public int isActive { get; set; }
        
    }
}