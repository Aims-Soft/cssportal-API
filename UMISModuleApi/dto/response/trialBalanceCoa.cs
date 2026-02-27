using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceCoa
    {
        public int trialBalanceNameCOAID { get; set; }

        public int trialBalanceNameID { get; set; }
        
        public string trialBalanceShortName { get; set; }
        
        public string trialBalanceFullName { get; set; }
        
        public int coaID { get; set; }
        
        public int accountLevel1 { get; set; }
        
        public int accountLevel2 { get; set; }
        
        public string coaCode { get; set; }

        public string coaTitle { get; set; }

        public int Selection { get; set; }  //static field

        public int tbHeadGroupID { get; set; }

        public int tbHeadGroupDetailID { get; set; }
    }
}