using System.ComponentModel.DataAnnotations;

namespace InternzConnectAPI.Models
{
    public class LoginLogs
    {
        [Key]
        public string? SessionId { get; set; }
        public EmployeeData? EmployeeId { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }

    }
}
