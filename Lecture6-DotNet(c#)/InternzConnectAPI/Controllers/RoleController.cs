using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using InternzConnectAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InternzConnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class RoleController : Controller
    {
        private readonly IRepoRoles repoContext;
        public RoleController(IRepoRoles repoContext)
        {
            this.repoContext = repoContext;
        }
        [HttpGet]
        public async Task<RolesResponse> GetRole()
        {
            return await repoContext.GetRoles();
        }

        [HttpGet("id")]
        public async Task<RolesResponse> GetRoleById(string id)
        {
            return await repoContext.GetRoleById(id);
        }
        [HttpPost]
        public async Task<RolesResponse> PostRole(string role)
        {
            return await repoContext.PostRole(role);
        }
        [HttpPut("ID")]
        public async Task<RolesResponse> PutRole(string id, string role)
        {
            return await repoContext.PutRole(id, role);
        }
        [HttpDelete("ID")]
        public async Task<RolesResponse> DeleteRole(string id)
        {
            return await repoContext.DeleteRole(id);
        }
    }
}
