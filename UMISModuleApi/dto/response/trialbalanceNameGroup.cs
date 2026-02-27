using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialbalanceNameGroup
    {
        public int sectionLocID { get; set; }
        public string sectionLocName { get; set; }
        public int trialBalanceGroupID { get; set; }
        public int trialBalanceNameID { get; set; }
        public int trialBalanceNameGroupID { get; set; }
        public string trialBalanceShortName { get; set; } 
        public string trialBalanceFullName { get; set; } 
     
    }
}