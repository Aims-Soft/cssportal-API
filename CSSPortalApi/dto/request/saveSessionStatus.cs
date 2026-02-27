using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SessionStatus
    {
        public int userID { get; set; }
        public int sessionID { get; set; }
        public string sessionStatus { get; set; }
        public string spType { get; set; }
    }
}