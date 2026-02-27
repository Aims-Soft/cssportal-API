using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities
{
    public class trialBalance
    {
        // fields for view
        public int trialBalanceNameID { get; set; }
        
        public int sectionLocID { get; set; }

        public string trialBalanceShortName { get; set; }
        
        public string trialBalanceFullName { get; set; }

        public string sectionLocName { get; set; }

        public int isActive { get; set; }

        public int projectID { get; set; }

        public int projectPackageID { get; set; }
    }
}