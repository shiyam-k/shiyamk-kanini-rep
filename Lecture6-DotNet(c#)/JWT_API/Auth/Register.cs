using System.ComponentModel.DataAnnotations;

namespace JWT_API.Auth
{
    public class Register
    {
        [Required(ErrorMessage = "Employee Id is required")]
        public string? EmployeeID { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
        
    }
}
