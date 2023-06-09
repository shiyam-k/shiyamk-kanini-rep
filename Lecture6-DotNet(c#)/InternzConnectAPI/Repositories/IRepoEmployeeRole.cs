using InternzConnectAPI.Models_Request_Response_;

namespace InternzConnectAPI.Repositories
{
    public interface IRepoEmployeeRole
    {
        Task<EmployeeRoleResponse> GetEmployeeRoles();
        Task<EmployeeRoleResponse> GetEmployeeRoleById(string id);
        Task<EmployeeRoleResponse> PutEmployeeRole(string id, EmployeeRoleRequest request);
        Task<EmployeeRoleResponse> DeleteEmployeeRole(string id);
        Task<EmployeeRoleResponse> PostEmployeeRole(EmployeeRoleRequest request);
    }
}
