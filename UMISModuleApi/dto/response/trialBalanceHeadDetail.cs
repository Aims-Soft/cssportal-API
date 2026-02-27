using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceHeadDetail
    {
        public int tbHeadGroupDetailID { get; set; }
        public int tbHeadGroupID { get; set; }  
        public string  tbHeadGroupTitle { get; set; }      
        public int coaID { get; set; }
        public int accountLevel1 { get; set; }
        public int accountLevel2 { get; set; }
        public string coaCode { get; set; }
        public string coaTitle { get; set; }
    }
}