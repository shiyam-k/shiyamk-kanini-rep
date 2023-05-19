using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Engineer_Project
    {
        [Key]
        public string Engineer_projectId { get; set; }
        public Employees Engineer { get; set; }
        public Projects Projects { get; set; }
        public Manager_Project Manager { get; set; } 

    }
}
