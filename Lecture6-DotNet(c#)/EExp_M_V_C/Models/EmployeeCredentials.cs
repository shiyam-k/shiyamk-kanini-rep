using System.ComponentModel.DataAnnotations;

namespace EExp_M_V_C.Models
{
    public class EmployeeCredentials
    {
        [Key]
        public string EmployeeId { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserType { get; set; }
    }
}
