using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class AssignedSessions
    {
        public int sessionID { get; set; }
        public string sessionTitle { get; set; }
        public string location { get; set; }
        public string date { get; set; }
        public string startTime { get; set; }
        public string DurationHours { get; set; }
        public int sessionTypeID { get; set; }
        public string sessionTypeName { get; set; }
        public int locationTypeID { get; set; }
        public string locationTypeTitle { get; set; }
        public string Fee { get; set; }
    }
}