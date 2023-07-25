using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class Clients
    {
        [Key]
        public string? ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? ClientAddress { get; set; }
        public string? ContactPersonName { get; set; }
        public string? ContactPersonEmail { get; set; }
        public string? ContactPersonPhone { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt{ get; set; }
        public string? ClientImgUrl { get; set; }
        public ICollection<ProjectData>? Projects { get; set; }
    }
}
