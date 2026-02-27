using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSSPortalApi.Entities
{
    public class SaveCompanyUser
    {
        public int userID { get; set; }
        public string userName { get; set; }
        public int companyID { get; set; }
        public string companyName { get; set; }
        public string password { get; set; }
        public string companyEmail { get; set; }
        public string foundedIn { get; set; }
        public string websiteLink { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string eLogo { get; set; }
        public string eLogoPath { get; set; }
        public string eLogoExt { get; set; }
        public string eDoc { get; set; }
        public string eDocPath { get; set; }
        public string eDocExt { get; set; }
        public string eLicense  { get; set; }
        public string eLicensePath { get; set; }
        public string eLicenseExt { get; set; }
        public string eBill  { get; set; }
        public string eBillPath { get; set; }
        public string eBillExt { get; set; }
        public string eLetter { get; set; }
        public string eLetterPath { get; set; }
        public string eLetterExt { get; set; }
        public string eAgreement  { get; set; }
        public string eAgreementPath { get; set; }
        public string eAgreementExt { get; set; }
        public int employeeID { get; set; }
        public int companyTypeID { get; set; }
        public int companyStatusID { get; set; }
        public string contact { get; set; }
        public int cityID { get; set; }
        public int roleID { get; set; }
        public int userTypeID { get; set; }
        public string pin { get; set; }
        public string json { get; set; }
        public string spType { get; set; }
    }
}