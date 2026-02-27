using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SaveJobStatusIsPauseClosed
    {
        public int userID { get; set; }
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public int? isPause { get; set; }
        public int? isClosed { get; set; }
        public string spType { get; set; }
    }
}