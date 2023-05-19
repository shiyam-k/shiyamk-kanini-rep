using Emp_Exp_API.Models;

namespace Emp_Exp_API.ReturnData
{
    public class EmployeeProjects
    {
        public string EmployeeId { get; set; } = "No Data";
        public List<EngineerProject> EProjects { get; set; }
        public List<ManagerProject> MProjects { get; set; }

    }
}
