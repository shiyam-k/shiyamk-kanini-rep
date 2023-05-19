using System.ComponentModel.DataAnnotations;

namespace Design_Pattern_10_5_23.Models
{
    public class Projects
    {
        [Key]
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectCategory { get; set; }
    }
}
