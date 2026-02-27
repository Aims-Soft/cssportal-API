using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class ApplicantSession
    {
        public int applicantSessionID { get; set; }
        public int userID { get; set; }
        public int sessionID { get; set; }
        public int isFavorite { get; set; }
        public string appliedDate { get; set; }
        public string spType { get; set; }
    }
}