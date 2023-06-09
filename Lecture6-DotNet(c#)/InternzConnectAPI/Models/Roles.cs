using System.ComponentModel.DataAnnotations;

namespace InternzConnectAPI.Models
{
    public class Roles
    {
        [Key]
        public string? RoleId { get; set; }
        public string ? RoleName { get; set; }
        public ICollection<EmployeeRole>? Employees { get; set; }


    }
}
