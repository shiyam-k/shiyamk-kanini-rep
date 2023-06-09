using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;
using Microsoft.AspNetCore.Mvc;

namespace InternzConnectAPI.Repositories
{
    public interface IRepoEmployees
    {
        Task<EmployeeResponse> GetEmployees();
        Task<EmployeeResponse> GetEmployeeById(string employeeId);
        Task<EmployeeResponse> PutEmployee(string id, EmployeeRequest employee);
        Task<EmployeeResponse> DeleteEmployee(string id);
        Task<EmployeeResponse> PostEmployee(EmployeeRequest employee);
    }
}
