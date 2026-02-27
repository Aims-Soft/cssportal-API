using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UMISModuleApi.Entities
{
    public class LoginResponse
    {
        public int userLoginId { get; set; }
        public string loginName { get; set; }
        public string FullName { get; set; }
        public string userCNIC { get; set; }
        public int companyID { get; set; }
        public bool isTeacher { get; set; }
        public bool isParent { get; set; }
        public bool isEmployee { get; set; }
        public int roleId { get; set; }
        public string pin { get; set; }
        public string token { get; set; }

        public LoginResponse(List<LoginUser> user, string userToken)
        {
            userLoginId = user[0].userLoginId;
            FullName = user[0].FullName;
            loginName = user[0].loginName;
            userCNIC = user[0].userCNIC;
            companyID = user[0].companyID;
            isTeacher = user[0].isTeacher;
            isParent = user[0].isParent;
            isEmployee = user[0].isEmployee;
            roleId = user[0].roleId;
            pin = user[0].pin;
            token = userToken;
        }
    }
}