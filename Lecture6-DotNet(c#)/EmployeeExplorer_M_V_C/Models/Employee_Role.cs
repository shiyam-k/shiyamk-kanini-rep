using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Employee_Role
    {
        [Key]
        public string ERId { get; set; }
        public Employees Employee { get; set; }
        public Role Role { get; set; }
        public string Designation { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}