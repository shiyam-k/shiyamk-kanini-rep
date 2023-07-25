using Employee_Management_API.Models;
using Employee_Management_API.Models_Reques__Response_;

namespace Employee_Management_API.Repositories
{
    public interface IRepoProfile
    {
        ProfileResponse ViewProfile(string SId);
    }
}
