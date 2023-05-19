using Emp_Exp_API.ModelsDummy;
using Emp_Exp_API.ReturnData;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Exp_API.Repositories
{
    public interface IRepoEmployee
    {
        ActionResult<string> Login(LoginDummy loginCredentials);
        Task<ActionResult<EmployeeProfile>> GetEmployeeProfile(string EmployeeId);

        Task<ActionResult<EmployeeProjects>> GetEmployeeProjectDetails(string EmployeeId);

        Task<ActionResult<string>> AssignProject(AddProjectsDummy projectData);
        Task<ActionResult<string>> UpdateProject(UpdateProjectDummy updateProject);
    }
}
