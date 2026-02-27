using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class AllSessions
    {
        public int userID { get; set; }    
        public string userName { get; set; }
        public int careerID { get; set; }
        public string careerTitle { get; set; }
        public string aboutcareer { get; set; }
        public int employmentTypeID { get; set; }
        public string employmentTypeTitle { get; set; }
        public int locationTypeID { get; set; }
        public string locationTypeTitle { get; set; }
        public int sessionID { get; set; }
        public string sessionTitle { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string date { get; set; }
        public string meetingLink { get; set; }
        public string DurationHours { get; set; }
        public string totalSeats { get; set; }
        public int sessionTypeID { get; set; }
        public string sessionTypeName { get; set; }
        public string sessionStatus { get; set; }
        public string Participants { get; set; }
        public string fee { get; set; }
    }
}