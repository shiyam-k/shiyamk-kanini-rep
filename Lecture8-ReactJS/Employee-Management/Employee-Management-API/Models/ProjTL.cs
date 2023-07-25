using System.ComponentModel.DataAnnotations;

namespace Employee_Management_API.Models
{
    public class ProjTL
    {
        [Key]
        public string? PTLID { get; set; }
        public ProjectData? ProjectId { get; set; }
        public EmployeeData? TL { get; set; }
    }
}
