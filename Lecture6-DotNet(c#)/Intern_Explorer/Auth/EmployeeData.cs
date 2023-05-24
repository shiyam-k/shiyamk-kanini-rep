using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class EmployeeData
    {
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public string DateOfJoin { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public Roles Roles { get; set; }

    }
}
