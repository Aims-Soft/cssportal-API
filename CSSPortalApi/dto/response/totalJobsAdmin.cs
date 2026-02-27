
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class TotalJobAdmin
    {
        public int Totaljobs { get; set; }
        public string JobGrowthPercent { get; set; }
        public int Activejobs { get; set; }
        public int TotalCompany { get; set; }
        public string CompanyGrowthPercent { get; set; }
        public int TotalCandidates { get; set; }
        public string CandidateGrowthPercent { get; set; }
        public int ExpiredJob { get; set; }
        public int TotalApplications { get; set; }
        public string ApplicationGrowthPercent { get; set; }
        public int TotalApplicants { get; set; }
    }
}