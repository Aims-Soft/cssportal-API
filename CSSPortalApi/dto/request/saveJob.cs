using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SaveJob
    {
        public int userID { get; set; }
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public int companyID { get; set; }
        public int jobTypeID { get; set; }
        public int jobCategoryID { get; set; }
        public int experienceID { get; set; }
        public string educationReq { get; set; }
        public string salaryRange { get; set; }
        public string postingDate { get; set; }
        public string expireDate { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public int jobStatusID { get; set; }
        public int jobSpaceID { get; set; }
        public string location { get; set; }
        public string responsibilities { get; set; }
        public string requirements { get; set; }
        public string benefitjson { get; set; }
        //public string skilljson { get; set; }
        public string spType { get; set; }
    }
}