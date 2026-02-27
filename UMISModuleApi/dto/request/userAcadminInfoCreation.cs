using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.dto.request
{
    public class UserAcadmicInfo
    {
        public int userID { get; set; }
        public int uniID { get; set; }
        public int degreeID { get; set; }
        public string completedYear { get; set; }
        public string json { get; set; }
        public string eResume { get; set; }
        public string eResumePath { get; set; }
        public string eResumeExt { get; set; }
        public string spType { get; set; }
    }
}