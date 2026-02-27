using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class UserInfo
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cnic { get; set; }
        public string studyLevelTitle { get; set; }
        public int studylevel { get; set; }
        public int experienceID { get; set; }
        public string experienceRange { get; set; }
        public int genderID { get; set; }
        public string genderName { get; set; }
        public string json { get; set; }
        public string domainTitle { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public string countryName { get; set; }
        public string fatherName { get; set; }
        public string DOB { get; set; }
        public string currentSalary { get; set; }
        public string contactNo { get; set; }
        public string address { get; set; }
        public string eResume { get; set; }
        public string eDoc { get; set; }
        public string profession { get; set; }
    }
}