using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class AllJobs
    {
        public int companyID { get; set; }
        public string companyName { get; set; }
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public string salaryRange { get; set; }
        public string postedAt { get; set; }
        public int jobCategoryID { get; set; }
        public string jobCategoryTitle { get; set; }
        public int jobSpaceID { get; set; }
        public string jobSpaceTitle { get; set; }
        public int jobTypeID { get; set; }
        public string jobTypeTitle { get; set; }
        public int experienceID { get; set; }
        public string experienceRange { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string responsibilities { get; set; }
        public string requirements { get; set; }
        public string skills { get; set; }
        public string eLogo { get; set; }
        public string eDoc { get; set; }
        public string Benefits { get; set; }
        public string DisplayTime { get; set; }
    }
}