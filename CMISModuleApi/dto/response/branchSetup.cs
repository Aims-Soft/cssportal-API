using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMISModuleApi.Entities
{
    public class BranchSetup
    {
        public int branch_id { get; set; }
        public string branch_name { get; set; }
        public int company_branch_id { get; set; }
    }
}