using System.ComponentModel.DataAnnotations;

namespace Dependency_Injection_MVC_11_5_23.Models
{
    public class Projects
    {
        [Key]
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
       
    }
}
