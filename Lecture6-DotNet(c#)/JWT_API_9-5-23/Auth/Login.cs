using System.ComponentModel.DataAnnotations;

namespace JWT_API_9_5_23.Auth
{
    public class Login
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
