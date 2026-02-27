using System.ComponentModel.DataAnnotations;

namespace UMISModuleAPI.Models
{
     public class GoogleAuthenticateRequest
    {
        // [Required]
        // public string email { get; set; }

        // [Required]
        // public string password { get; set; }

        [Required]
        public string Loginname { get; set; }
        [Required]
        public int roleID { get; set; }
       // public string SpType { get; set; }
    }
}