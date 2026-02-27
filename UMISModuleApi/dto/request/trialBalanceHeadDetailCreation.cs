using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class trialBalanceHeadDetailCreation
    {
        public int ID { get; set; }  //tbHeadGroupDetailID
        
        public string json  { get; set; }

        public int userID  { get; set; }
        
        public string spType  { get; set; }
    }
}