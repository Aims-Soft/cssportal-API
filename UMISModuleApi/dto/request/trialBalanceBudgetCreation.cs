using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceBudgetCreation
    {
        public int trialBalanceNameBudgetTypeID{ get; set; }

        public int trialBalanceNameID{ get; set; }

        public int budgetTypeID{ get; set; }

        public int userID  { get; set; }
        
        public string spType  { get; set; }
    }
}