using System.ComponentModel.DataAnnotations;


namespace EmployeeExplorer_M_V_C.Models
{
    public class Role
    {
        [Key] public string RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public string RoleDescription { get; set; } = string.Empty;
        public ICollection<Employee_Role> Roles { get; set;}
    }
}
