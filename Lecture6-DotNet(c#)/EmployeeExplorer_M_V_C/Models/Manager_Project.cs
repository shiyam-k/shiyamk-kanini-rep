using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Manager_Project
    {
        [Key]
        public string ManagerProjectId { get; set; }
        public Employees Manager { get; set; }
    }
}
