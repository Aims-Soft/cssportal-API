using System.ComponentModel.DataAnnotations;

namespace UMISModuleAPI.Models
{
    public class AuthenticateRequest
    {
        // [Required]
        // public string email { get; set; }

        // [Required]
        // public string password { get; set; }

        [Required]
        public string Loginname { get; set; }

        [Required]
        public string password { get; set; }
        public int roleID { get; set; }
    }
}