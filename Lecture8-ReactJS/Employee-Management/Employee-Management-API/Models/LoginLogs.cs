using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;

namespace Employee_Management_API.Models
{
    public class LoginLogs
    {
        [Key]
        public string? SessionId { get; set; }
        public string? LoginId { get; set; }
        public string? Token { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}
