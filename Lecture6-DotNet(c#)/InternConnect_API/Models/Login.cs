using System.ComponentModel.DataAnnotations;

namespace InternConnect_API.Models
{
    public class Login
    {
        [Key]
        public string? SessionId { get; set; }
        public string? UserName { get; set; }
    }
}
