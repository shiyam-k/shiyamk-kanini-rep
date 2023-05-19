using System.ComponentModel.DataAnnotations;

namespace Design_Pattern_10_5_23.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public Roles Role { get; set; }

    }
}
