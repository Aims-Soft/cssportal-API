using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class UserSession
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public int careerID { get; set; }
        public string careerTitle { get; set; }
        // public int sessionID { get; set; }
        // public string sessionTitle { get; set; }
        public string Sessions { get; set; }
        // public int isFavorite { get; set; }
        // public string AppliedDate { get; set; }
    }
}