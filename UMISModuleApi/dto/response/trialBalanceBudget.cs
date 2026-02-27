using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceBudget
    {
        public int trialBalanceNameBudgetTypeID{ get; set; }

        public int trialBalanceNameID{ get; set; }

        public string trialBalanceFullName { get; set; }

        public int budgetTypeID{ get; set; }

        public string budgetTypeName{ get; set; }
    }
}