
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class DashboardCount
    {
        public int Education { get; set; }
        public int Politics { get; set; }
        public int TotalSessions { get; set; }
        public int  Business { get; set; }
        public int Job { get; set; }
        public int  NewUser { get; set; }
    }
}