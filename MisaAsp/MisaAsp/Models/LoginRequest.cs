using System.ComponentModel.DataAnnotations;

namespace MisaAsp.Models
{
    public class LoginRequest
    {
        [Required]
        public string EmailOrPhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
