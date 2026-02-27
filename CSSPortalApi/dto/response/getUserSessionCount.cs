using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SessionCount
    {
        public int userID { get; set; }
        public int AppliedSessions { get; set; }
        public int FavoriteSessions { get; set; }
        public int AttendedSessions { get; set; }
   }
}