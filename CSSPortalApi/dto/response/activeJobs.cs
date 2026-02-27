
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class ActiveJob
    {
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public string salaryRange { get; set; }
        public string postingDate { get; set; }
        public string expireDate { get; set; }
        public int jobSpaceID { get; set; }
        public string jobSpaceTitle { get; set; }
        public int jobTypeID { get; set; }
        public string jobTypeTitle { get; set; }
        public int jobCategoryID { get; set; }
        public string jobCategoryTitle { get; set; }
        public int jobStatusID { get; set; }
        public string jobStatusTitle { get; set; }
        public int experienceID { get; set; }
        public string experienceRange { get; set; }
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string eLogo { get; set; }
        public string eDoc { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public string countryName { get; set; }
        public string location { get; set; }
        public string responsibilities { get; set; }
        public string requirements { get; set; }
        public string Skills { get; set; }
        public string Benefits { get; set; }
        public string DisplayTime { get; set; }
    }
}