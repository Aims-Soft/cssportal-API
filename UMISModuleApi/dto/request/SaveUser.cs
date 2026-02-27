
namespace UMISModuleAPI.Entities
{
    public class SaveUser
    {
        public int  userID  { get; set; }  
        public string userName { get; set; }
        public string contact { get; set; }
        public string password { get; set; }
        public string email {get; set;}
        public int roleID {get; set;}
        public int userRoleID {get; set;}
        public int createdBy {get; set;}
        public string spType { get; set; }    
    }
}