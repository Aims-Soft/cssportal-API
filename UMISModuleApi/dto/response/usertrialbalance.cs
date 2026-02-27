using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities
{
    public class userTrialBalance
    {
        public int sectionLocID { get; set; }

        public string sectionLocName { get; set; }
        
        public int Selection { get; set; }  //static field in view_sectionTrialBalanceName

        public int trialBalanceNameID { get; set; }
        
        public string trialBalanceShortName { get; set; }
        
        public string trialBalanceFullName { get; set; }
        
    }
}