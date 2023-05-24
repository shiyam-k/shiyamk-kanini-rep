using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class Projects
    {
        [Key]
        public string ProjectId { get; set; }
        public string ProjectName { get; set; } = string.Empty;
        public string ProjectDescription { get; set; } = string.Empty;
    }
}
