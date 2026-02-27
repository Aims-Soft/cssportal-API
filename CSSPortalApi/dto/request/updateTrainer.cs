using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class UpdateTrainer
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cnic { get; set; }
        public int genderID { get; set; }
        public int cityID { get; set; }
        public int countryID { get; set; }
        public string fatherName { get; set; }
        public string DOB { get; set; }
        public string contactNo { get; set; }
        public string address { get; set; }
        // public string eResume { get; set; }
        // public string eResumePath { get; set; }
        // public string eResumeExt { get; set; }
        public string eDoc { get; set; }
        public string eDocPath { get; set; }
        public string eDocExt { get; set; }
        public int roleID { get; set; }
        public int userTypeID { get; set; }
        public string spType { get; set; }
    }
}