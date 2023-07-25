using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class TopicsDomains
    {
        [Key]
        public string? DDID { get; set; }
        public Domains? DomainId { get; set; }
        public Topic? TopicId { get; set; }
    }
}
