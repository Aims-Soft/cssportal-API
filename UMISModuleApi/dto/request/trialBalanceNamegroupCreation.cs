using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceNamegroupCreation
    {
        public int trialBalanceNameGroupID { get; set; }

        public int trialBalanceGroupID { get; set; }
        
        public int trialBalanceNameID{ get; set; }

        public int userID { get; set; }
        
        public string spType { get; set; }
    }
}