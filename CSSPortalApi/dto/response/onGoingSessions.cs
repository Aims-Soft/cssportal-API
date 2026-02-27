
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class OnGoingSession
    {
        public int sessionID { get; set; }
        public string sessionTitle { get; set; }
        public string date { get; set; }
        public string  startTime { get; set; }
        public string endTime { get; set; }
        public string  Participant { get; set; }
        public string  AppliedPercentage { get; set; }
    }
}