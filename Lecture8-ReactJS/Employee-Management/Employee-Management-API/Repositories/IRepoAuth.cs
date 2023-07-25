using Employee_Management_API.Models_Request_;
using Employee_Management_API.Models_Response_;

namespace Employee_Management_API.Repositories
{
    public interface IRepoAuth
    {
        Task<LoginResponse> Login(LoginDto loginCredentials);
        Task<LoginResponse> Logout(string sessionId);
    }
}
