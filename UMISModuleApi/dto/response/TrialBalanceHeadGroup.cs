using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class TrialBalanceHeadGroup
    {
        public int tbHeadGroupID { get; set; }
        public string tbHeadGroupTitle { get; set; }
        public string tbDescription { get; set; }
        public int isActive { get; set; }
    }
}