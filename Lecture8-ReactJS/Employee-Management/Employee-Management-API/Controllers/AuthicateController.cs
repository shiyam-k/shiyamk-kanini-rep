using Employee_Management_API.Models_Request_;
using Employee_Management_API.Models_Response_;
using Employee_Management_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Management_API.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class AuthicateController : Controller
    {
        private readonly IRepoAuth repoContext;
        public AuthicateController(IRepoAuth? repoContext)
        {
            this.repoContext = repoContext;
        }
        [HttpPost]
        [Route("login")]
        public async Task<LoginResponse> Login(LoginDto loginCredentials)
        {
            return await repoContext.Login(loginCredentials);
        }
        [HttpGet]
        [Route("logout")]
        public async Task<LoginResponse> Logout(string SId)
        {
            return await repoContext.Logout(SId);

        }
    }
}
