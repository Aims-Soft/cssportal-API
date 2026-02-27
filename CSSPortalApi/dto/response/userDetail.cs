using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class userDetail
    {
        public int userID { get; set; }     
        public int roleId { get; set; }     
        public string userName { get; set; }
        public string fatherName { get; set; }
        public string email { get; set; }
        public string roleTitle { get; set; }
        public string CNIC { get; set; }
        public int userTypeID { get; set; }
        public string userTypeName { get; set; }
        public string contactNo { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public int careerID { get; set; }
        public string careerTitle { get; set; }
        public string aboutcareer { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public string countryName { get; set; }
        public int genderID { get; set; }
        public string genderName { get; set; }
        public string eDoc { get; set; }
    }
}