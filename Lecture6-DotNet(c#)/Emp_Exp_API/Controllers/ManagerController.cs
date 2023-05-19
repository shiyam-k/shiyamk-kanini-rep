using Emp_Exp_API.ModelsDummy;
using Emp_Exp_API.Repositories;
using Emp_Exp_API.ReturnData;
using Microsoft.AspNetCore.Mvc;

namespace Emp_Exp_API.Controllers
{
    [Route("api/[controller]/actions")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IRepoEmployee repocontext;
        Random random = new Random();
        public ManagerController(IRepoEmployee repocontext)
        {
            this.repocontext = repocontext;
        }
        [HttpGet]
        [Route("View Manager Profile")]
        public async Task<ActionResult<EmployeeProfile>> ViewProfile(string EmployeeId)
        {
            return await repocontext.GetEmployeeProfile(EmployeeId);
        }
        [HttpGet]
        [Route("View Project Status")]
        public async Task<ActionResult<EmployeeProjects>> ViewProject(string EmployeeId)
        {
            return await repocontext.GetEmployeeProjectDetails(EmployeeId);
        }
        [HttpPost]
        [Route("Assign Project")]
        public async Task<ActionResult<string>> AddProjectsToEngineers(AddProjectsDummy projectData)
        {
            return await repocontext.AssignProject(projectData);
        }
        [HttpPut]
        [Route("Update Project")]
        public async Task<ActionResult<string>> UpdateProjectEngineer(UpdateProjectDummy updateProject)
        {
            
            return await repocontext.UpdateProject(updateProject);
        }
    }
}
