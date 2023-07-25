using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class Roles
    {
        [Key]
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? RoleDescription { get; set; }

        public ICollection<EmployeeRole>? Employee_Roles { get; set; }
    }
}
