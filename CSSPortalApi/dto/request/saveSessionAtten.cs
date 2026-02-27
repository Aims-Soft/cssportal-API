using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SessionAttend
    {
        //public int userID { get; set; }
        public int sessionID { get; set; }
        public int sessionStartStatus { get; set; }
        //public string startDate { get; set; }
        //public string endDate { get; set; }
        public int ispresent { get; set; }
        public string json { get; set; }
        public int trainerID { get; set; }
        public string spType { get; set; }
    }
}