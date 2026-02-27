
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class JobApplications
    {
        public int jobID { get; set; }
        public string jobTitle { get; set; }
        public string salaryRange { get; set; }
        public string postedAt { get; set; }
        public string expireAt { get; set; }
        public int jobSpaceID { get; set; }
        public string jobSpaceTitle { get; set; }
        public int jobTypeID { get; set; }
        public int totalApplicants { get; set; }
        public string jobTypeTitle { get; set; }
        public int jobStatusID { get; set; }
        public string jobStatusTitle { get; set; }
        public int experienceID { get; set; }
        public string experienceRange { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string TimeRemaining { get; set; }
        public string AppliedUser { get; set; }
    }
}