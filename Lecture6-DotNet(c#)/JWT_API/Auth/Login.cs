using System.ComponentModel.DataAnnotations;

namespace JWT_API.Auth
{
    public class Login
    {
        [Required(ErrorMessage = "Employee ID is required")]
        public string? EmployeeID { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
