using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SaveJobApplicationStatus
    {
        public int jobApplicationID { get; set; }
        public int jobApplicationStatusID { get; set; }
        public int userID { get; set; }
        public int jobID { get; set; }
        public string spType { get; set; }
    }
}