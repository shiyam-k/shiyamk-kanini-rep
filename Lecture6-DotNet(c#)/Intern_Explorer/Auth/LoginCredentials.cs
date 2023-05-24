using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class LoginCredentials
    {
        [Key]
        public string EmployeeId { get; set; }
        public string Password { get; set; }
    }
}
