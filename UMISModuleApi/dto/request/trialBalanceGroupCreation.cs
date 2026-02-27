using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceGroupCreation
    {
        public int trialBalanceGroupID { get; set; }
        
        public string trialBalanceGroupTitle { get; set; }

        public int userID { get; set; }
        
        public string spType { get; set; }
    }
}