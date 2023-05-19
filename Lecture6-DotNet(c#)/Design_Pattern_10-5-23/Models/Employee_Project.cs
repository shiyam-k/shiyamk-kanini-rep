using System.ComponentModel.DataAnnotations;

namespace Design_Pattern_10_5_23.Models
{
    public class Employee_Project
    {
        [Key]
        public string EPID { get; set; }
        public Projects Project { get; set; }
        public Employee Employee { get; set; }
        public string ProjectRole { get; set; }
    }
}
