using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SaveJobApplication
    {
        public int jobApplicationID { get; set; }
        public int userID { get; set; }
        public int jobID { get; set; }
        public string appliedAt { get; set; }
        public string description { get; set; }
        public string lastStatus { get; set; }
        public string resume { get; set; }
        public int jobApplicationStatusID { get; set; }
        public int experienceID { get; set; }
        public int jobStatusID { get; set; }
        public int studyLevelID { get; set; }
        public string spType { get; set; }
    }
}