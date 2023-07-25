using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class EmployeeData
    {
        [Key]
        public string? EmployeeId { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeLastName { get; set; }
        public string? EmployeeDOJ { get; set; }
        public string? EmployeeDOB { get; set; }
        public Domains? Specialization { get; set; } 
        public string? EmployeeQualifications { get; set; }
        public byte[]? EmployeePasswordHash { get; set; }
        public byte[]? EmployeePasswordSalt { get; set; }
        public string? EmployeeProfileImg { get; set; }
        public ICollection<EmployeeRole>? Employee_Roles { get; set; }
        public ICollection<ProjTL>? ProjectsTL { get; set; } 
    }
}
