using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class UserJobDetails
    {
        public int companyID { get; set; }
        public int userID { get; set; }
        public string userName { get; set; }
        public string cnic { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string profession { get; set; }
        public string eResume { get; set; }
        public string email { get; set; }
        public string eDoc { get; set; }
        public int jobApplicationID { get; set; }
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public string DisplayTime { get; set; }
        public string userDomain { get; set; }
   }
}