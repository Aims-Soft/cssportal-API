using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SessionByAdmin
    {
        public int sessionID { get; set; }
        public string sessionTitle { get; set; }
        public string description { get; set; }
        public string totalSeats { get; set; }
        public string location { get; set; }
        public string meetingLink { get; set; }
        public string  startTime { get; set; }
        public string endTime { get; set; }
        public string date { get; set; }
        public string fee { get; set; }
        public int sessionTypeID { get; set; }
        public int locationTypeID { get; set; }
        public int employmentTypeID { get; set; }
        public int assignTo { get; set; }
        public int userID { get; set; }
        public string spType { get; set; }
    }
}