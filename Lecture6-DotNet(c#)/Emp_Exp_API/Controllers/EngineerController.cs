using Emp_Exp_API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Emp_Exp_API.ReturnData;
using Emp_Exp_API.Models;

namespace Emp_Exp_API.Controllers
{
    [Route("api/[controller]/actions")]
    [ApiController]
    public class EngineerController : Controller
    {
        private readonly IRepoEmployee repocontext;
        Random random = new Random();
        public EngineerController(IRepoEmployee repocontext)
        {
            this.repocontext = repocontext;
        }

        [HttpGet]
        [Route("View Employee Profile")]
        public async Task<ActionResult<EmployeeProfile>> ViewProfile(string EmployeeId) 
        { 
            return await repocontext.GetEmployeeProfile(EmployeeId);
        }

        [HttpGet]
        [Route("View Project")]
        public async Task<ActionResult<EmployeeProjects>> ViewProject(string EmployeeId)
        {
                        
            return await repocontext.GetEmployeeProjectDetails(EmployeeId);
        }
    }
}
