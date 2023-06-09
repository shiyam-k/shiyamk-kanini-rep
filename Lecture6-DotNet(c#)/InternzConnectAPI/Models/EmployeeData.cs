using System.ComponentModel.DataAnnotations;

namespace InternzConnectAPI.Models
{
    public class EmployeeData
    {
        [Key]
        public string? EmployeeId { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public DateTime? EmployeeDOB { get; set; }
        public DateTime? EmployeeDOJ { get; set; }
        public string? Course { get; set; }
        public string? Stream { get; set; }
        public string? Email { get; set; }
        public byte[]? EmployeePasswordHash { get; set; }
        public byte[]? EmployeePasswordKey { get; set; }
        public ICollection<EmployeeRole>? EmployeeRoles { get; set; }
        public ICollection<LoginLogs>? LoginLogs { get; set; }
    }
}
