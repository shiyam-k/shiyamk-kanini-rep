using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class Topic
    {
        [Key]
        public string? TopicId { get; set; }
        public string? TopicName { get; set; }
        public string? TopicDescription { get; set; }
        public ICollection<TopicsDomains>? TopicDomains { get; set; }
    }
}
