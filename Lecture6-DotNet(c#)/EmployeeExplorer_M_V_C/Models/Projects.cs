using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Projects
    {
        [Key]
        public string ProjectId { get; set; }
        public string ProjectTitle { get; set; } = string.Empty;
        public string ProjectDescription { get; set; } = string.Empty;
        public string ProjectCategory { get; set; } = string.Empty;
        public string ProjectStartDate { get; set; } = string.Empty;
        public string ProjectEndDate { get; set; } = string.Empty;
        public Clients Clients { get; set; }
        public ICollection<Manager_Project> Manager_Projects { get; set; }
        public ICollection<Engineer_Project> Engineer_Projects { get; set; }
    }
}
