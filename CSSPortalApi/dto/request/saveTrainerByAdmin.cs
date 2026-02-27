using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class TrainerByAdmin
    {
        public int userID { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public string address { get; set; }
        public string contactNo { get; set; }
        public int roleID { get; set; }
        public int careerID { get; set; }
        public string aboutCareer { get; set; }
        public int userTypeID { get; set; }
        public int locationTypeID { get; set; }
        public int employmentTypeID { get; set; }
        public string spType { get; set; }
    }
}