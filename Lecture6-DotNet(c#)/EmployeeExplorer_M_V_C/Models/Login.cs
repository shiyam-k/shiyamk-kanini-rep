using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Login
    {
        [Key]
        public string SessionId { get; set; }
        public string? LoginEmployeeId { get; set; }
        public EmployeeCredentials? EmployeeCredentials { get; set; }

        public string? Password { get; set; }
        public string? Status { get; set; }
    }
}
