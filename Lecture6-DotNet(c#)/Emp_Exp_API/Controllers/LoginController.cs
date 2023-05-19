using Emp_Exp_API.ModelsDummy;
using Emp_Exp_API.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Emp_Exp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IRepoEmployee repocontext;
        Random random = new Random();
        public LoginController(IRepoEmployee repocontext)
        {
            this.repocontext = repocontext;
        }
        [Route("Employee Login")]
        [HttpPost]
        public async Task<ActionResult<string>> Login(LoginDummy loginCredentials)
        {
            return $"{repocontext.Login(loginCredentials).Value} has logged in";
        }

    }
}
