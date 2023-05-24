using Microsoft.AspNetCore.Identity;

namespace InternConnect_API.Models
{
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string DOJ { get; set; } = string.Empty;
        public string CourrseStream { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;


    }
}
