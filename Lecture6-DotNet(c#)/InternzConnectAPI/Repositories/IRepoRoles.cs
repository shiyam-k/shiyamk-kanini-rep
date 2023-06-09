using InternzConnectAPI.Models;
using InternzConnectAPI.Models_Request_Response_;

namespace InternzConnectAPI.Repositories
{
    public interface IRepoRoles
    {
        Task<RolesResponse> GetRoles();
        Task<RolesResponse> GetRoleById(string employeeId);
        Task<RolesResponse> PutRole(string id, string role);
        Task<RolesResponse> DeleteRole(string id);
        Task<RolesResponse> PostRole(string role);
    }
}
