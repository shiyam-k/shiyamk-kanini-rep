using System.ComponentModel.DataAnnotations;

namespace EmployeeExplorer_M_V_C.Models
{
    public class Employees
    {
        [Key]
        public string EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DateOfJoin { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;        
        public int Salary { get; set;}
        public  string EmployeeStatus { get; set; } = string.Empty;
        /*public ICollection<Employee_Role> Employee_Roles { get; set; }
        public ICollection<Engineer_Project> EngineerProjects { get; set; }
        public ICollection<Manager_Project> ManagerProjects { get; set; }*/
    }
}
