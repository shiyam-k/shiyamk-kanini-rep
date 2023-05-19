using System.ComponentModel.DataAnnotations;

namespace JWT_API_9_5_23.Auth
{
    public class ProjectResources
    {
        [Key]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
    }
}
