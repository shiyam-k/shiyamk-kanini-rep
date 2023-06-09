using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using InternzConnectAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InternzConnectAPI.Controllers
{
    [ApiController]
    [Route("[controller]/actions")]
    public class EmployeeController : Controller
    {
        private readonly IRepoEmployees repoContext;
        public EmployeeController(IRepoEmployees repoContext)
        {
            this.repoContext = repoContext;
        }
        [HttpGet]
        public async Task<Models.EmployeeResponse> GetEmployees()
        {
            return await repoContext.GetEmployees();
        }

        [HttpGet("id")]
        public async Task<EmployeeResponse> GetEmployeeById(string id)
        {
            return await repoContext.GetEmployeeById(id);
        }
        [HttpPost]
        public async Task<EmployeeResponse> PostEmployee(EmployeeRequest employee)
        {
            return await repoContext.PostEmployee(employee);
        }
        [HttpPut("id")]
        public async Task<EmployeeResponse> PutEmployee(string id, EmployeeRequest employee)
        {
            return await repoContext.PutEmployee(id, employee);
        }
        [HttpDelete("id")]
        public async Task<EmployeeResponse> DeleteEmployee(string id)
        {
            return await repoContext.DeleteEmployee(id);
        }
    }
}
