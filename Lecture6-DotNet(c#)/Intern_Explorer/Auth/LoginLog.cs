using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class LoginLog
    {
        [Key]
        public string SessioId { get; set; }
        public string EmployeeId { get; set; }
        
    }
}
