using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class TrainerSessionCount
    {
        public int userID { get; set; }
        public string TodaySessions { get; set; }
        public string UpcomingSessions { get; set; }
        public string ComingWeekSessions { get; set; }
        public string ComingMonthSessions { get; set; }
   }
}