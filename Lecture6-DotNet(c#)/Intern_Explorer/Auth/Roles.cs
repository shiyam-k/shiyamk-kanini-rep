using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class Roles
    {
        [Key]
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public ICollection<EmployeeData> Employees { get; set; }
    }
}
