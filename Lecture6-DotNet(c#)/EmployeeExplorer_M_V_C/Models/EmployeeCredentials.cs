using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class EmployeeCredentials
    {
        [Key]
        public string EmployeeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
