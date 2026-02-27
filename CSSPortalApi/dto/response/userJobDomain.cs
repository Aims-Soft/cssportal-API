using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class UserJobDomains
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public int companyID { get; set; }
        public string domainTitle { get; set; }
   }
}