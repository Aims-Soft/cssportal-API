
namespace UMISModuleAPI.Entities
{
    public class SaveUserInterest
    {
        public int  userID  { get; set; }  
        public string aboutCareer { get; set; }
        public int careerID { get; set; }
        public string domainjson { get; set; }
        public string hobbiejson {get; set;}
        public string spType { get; set; }    
    }
}