using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleAPI.Entities{
    public class AllUser
    {
        public int userID { get; set; }    
        public string userName { get; set; }
        public string fatherName { get; set; }
        public string email { get; set; }
        public string loginStatus { get; set; }
        public string CNIC { get; set; }
        public int userTypeID { get; set; }
        public string userTypeName { get; set; }
        public string contactNo { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public int careerID { get; set; }
        public string careerTitle { get; set; }
        public string aboutcareer { get; set; }
        public int employmentTypeID { get; set; }    
        public string employmentTypeTitle { get; set; }
        public int locationTypeID { get; set; }    
        public string locationTypeTitle { get; set; }
    }
}