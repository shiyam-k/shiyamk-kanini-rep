using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class Domains
    {
        [Key]
        public string? DomainId { get; set; }
        public string? DomainName { get; set; }
        public string? DomainDescription { get; set; }
        public ICollection<EmployeeData>? Data { get; set; }
        public ICollection<ProjectData>? Projects { get; set; }
        public ICollection<TopicsDomains>? TopicDomains { get; set; }

    }
}
