using System.ComponentModel.DataAnnotations;

namespace Design_Pattern_10_5_23.Models
{
    public class Roles
    {
        [Key]
        public string Role { get; set; } 
        public ICollection<Employee> Employees { get; set; }
    }
}
