using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class TrainerExperience
    {
        public int userID { get; set; }
        public string aboutCareer { get; set; }
        public int careerID { get; set; }
        public string json { get; set; }
        public string spType { get; set; }
    }
}