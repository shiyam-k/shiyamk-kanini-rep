using Employee_Management_API.Models;
using Employee_Management_API.Models_Dto_;
using System.IdentityModel.Tokens.Jwt;

namespace Employee_Management_API.Models_Response_
{
    public class LoginResponse
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
        public string? SessionId { get; set; }
        public LoginLogs? LoginLog { get; set; }
    }
}
