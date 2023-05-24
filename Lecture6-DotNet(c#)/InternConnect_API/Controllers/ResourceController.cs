using InternConnect_API.Models;
using InternConnect_API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternConnect_API.Controllers
{
    [Route("api/[controller]/actions")]
    [ApiController]
    [Authorize]
    public class ResourceController : Controller
    {
        private readonly IRepoEmployee? repocontext;
        public ResourceController(IRepoEmployee? repocontext)
        {
            this.repocontext = repocontext;
        }


        [HttpGet("EId")]

        public async Task<ActionResult<string>> GetEmployeeDetails(string EId)
        {
            EmployeeDetails? result = repocontext.GetEmployeeDetails(EId);
            if (result != null)
            {
                return result.EId;
            }
            return "User Not Found";

        }
    }
}
