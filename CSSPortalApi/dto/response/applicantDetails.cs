using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class ApplicantDetails
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string cnic { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public string address { get; set; }
        public int countryID { get; set; }
        public string countryName { get; set; }
        public string contact { get; set; }
        public string profession { get; set; }
        public string eResume { get; set; }
        public string eDoc { get; set; }
        public string ApplicantInfo { get; set; }
   }
}