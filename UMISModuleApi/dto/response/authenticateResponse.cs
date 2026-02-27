using System.Collections.Generic;
using UMISModuleAPI.Entities;

namespace UMISModuleAPI.Models
{
    public class AuthenticateResponse
    {
        public int userLoginId { get; set; }
        public int roleId { get; set; }
        public bool loginStatus { get; set; }
        public string roleJson { get; set; }
        public string fullName { get; set; }
        public string loginName { get; set; }
        public string password { get; set; }
        public string isPinCode { get; set; }
        public int teacherID { get; set; }
        public string roleTitle { get; set; }
        public string token { get; set; }
        public int company_id { get; set; }

        public AuthenticateResponse(List<User> user, string userToken)
        {
            userLoginId = user[0].userLoginId;
            roleId = user[0].roleId;
            loginStatus = user[0].loginStatus;
            roleJson = user[0].roleJson;
            roleTitle = user[0].roleTitle;
            fullName = user[0].fullName;
            loginName = user[0].loginName;
            password = user[0].password;
            isPinCode = user[0].isPinCode;
            teacherID = user[0].teacherID;
            company_id = user[0].company_id;
            token = userToken;
        }
    }
}