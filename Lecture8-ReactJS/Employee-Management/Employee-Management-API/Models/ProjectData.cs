using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class ProjectData
    {
        [Key]
        public string? ProjectId { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDescription { get; set; }
        public string? ProjectType { get; set; }
        public string? ProjectImg { get; set; }
        public Clients? Client { get; set; }
        public bool? IsCreated { get; set; }
        public List<Domains>? ProjectDomain { get; set; }
        public ICollection<ProjTL>? ProjectsTLs { get; set; }
        public ICollection<ProjEmployees>? ProjectEmployees { get; set; }
    }
}
