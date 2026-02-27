using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class UserTrialBalanceName
    {
        
        public int userID { get; set; }

        public int trialBalanceNameID { get; set; }
        
        public int userTrialBalanceNameID { get; set; }
        
        public string trialBalanceShortName { get; set; }
        
        public int sectionLocID { get; set; }

        public string sectionLocName { get; set; }
    
    }
}