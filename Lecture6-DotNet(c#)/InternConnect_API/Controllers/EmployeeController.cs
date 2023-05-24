using InternConnect_API.ModelDummy;
using InternConnect_API.Models;
using InternConnect_API.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InternConnect_API.Controllers
{
    [Route("api/[controller]/actions")]
    [ApiController]
    public class EmployeeController
    {
        private readonly IRepoEmployee? repocontext;
        public EmployeeController(IRepoEmployee? repocontext)
        {
            this.repocontext = repocontext;
        }

       
        [HttpPost]
        [Route("Register")]
        [Authorize]
        public async Task<ActionResult<string>> SignUpEmployee(SignUpModel employeeData)
        {
            var result = await repocontext.SignUpEmployee(employeeData);
            if (result.Succeeded)
            {
                return "created";
            }
            else
            {
                return "Failed";
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<string>> Login([FromBody]LoginModel employeeData)
        {
            string result = await repocontext.Login(employeeData);
            if (result.Equals(""))
            {
                return "UnAuthorized";
            }
            return result;

        }

    }
}
