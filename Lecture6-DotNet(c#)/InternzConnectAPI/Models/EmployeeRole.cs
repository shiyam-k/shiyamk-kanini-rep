using System.ComponentModel.DataAnnotations;

namespace InternzConnectAPI.Models
{
    public class EmployeeRole
    {
        [Key]
        public string? ERId { get; set; }
        public EmployeeData? EmployeeId { get; set; }
        public Roles? RoleId { get; set; }
    }
}
