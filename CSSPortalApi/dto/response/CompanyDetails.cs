using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class CompanyDetails
    {
        public int userID { get; set; }
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string email { get; set; }
        public string foundedIn { get; set; }
        public string websiteLink { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string eLogo { get; set; }
        public string eDoc { get; set; }
        public string eLicense { get; set; }
        public string eLetter { get; set; }
        public string eBill { get; set; }
        public string eAgreement { get; set; }
        public int employeeID { get; set; }
        public string employeeRange { get; set; }
        public int companyTypeID { get; set; }
        public int companyStatusID { get; set; }
        public int cityID { get; set; }
        public string cityName { get; set; }
        public int countryID { get; set; }
        public string countryName { get; set; }
        public string remarkes { get; set; }
        public string json { get; set; }
    }
}