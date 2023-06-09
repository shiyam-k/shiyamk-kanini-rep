using InternzConnectAPI.Models_Request_Response_;
using InternzConnectAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InternzConnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class EmployeeRoleController : Controller
    {
        private readonly IRepoEmployeeRole repoContext;
        public EmployeeRoleController(IRepoEmployeeRole repoContext)
        {
            this.repoContext = repoContext;
        }
        [HttpGet]
        public async Task<EmployeeRoleResponse> GetRole()
        {
            return await repoContext.GetEmployeeRoles();
        }

        [HttpGet("id")]
        public async Task<EmployeeRoleResponse> GetRoleById(string id)
        {
            return await repoContext.GetEmployeeRoleById(id);
        }
        [HttpPost]
        public async Task<EmployeeRoleResponse> PostRole(EmployeeRoleRequest request)
        {
            return await repoContext.PostEmployeeRole(request);
        }
        [HttpPut("ID")]
        public async Task<EmployeeRoleResponse> PutRole(string id, EmployeeRoleRequest request)
        {
            return await repoContext.PutEmployeeRole(id, request);
        }
        [HttpDelete("ID")]
        public async Task<EmployeeRoleResponse> DeleteRole(string id)
        {
            return await repoContext.DeleteEmployeeRole(id);
        }

    }
}
