using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Employee_Management_API.Models
{
    public class EmployeeRole
    {
        [Key]
        public string? ERId { get; set; }
        public EmployeeData? Employees { get; set; }
        public Roles? Role { get; set; }
    }
}
