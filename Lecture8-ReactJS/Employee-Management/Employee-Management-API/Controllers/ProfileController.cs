using Employee_Management_API.Models;
using Employee_Management_API.Models_Reques__Response_;
using Employee_Management_API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Employee_Management_API.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    [Authorize(Roles = "ROLE001")]
    public class ProfileController : ControllerBase
    {
        private readonly IRepoProfile repoContext;
        public ProfileController(IRepoProfile repoContext)
        {
            this.repoContext = repoContext;
        }
        [HttpGet]
        public ActionResult<ProfileResponse> GetProfile(string SId)
        {
            var res = repoContext.ViewProfile(SId);
            if(res.Status)
            {
                return Ok(res);
            }
            return NotFound(res);
        }
        
    }
}
