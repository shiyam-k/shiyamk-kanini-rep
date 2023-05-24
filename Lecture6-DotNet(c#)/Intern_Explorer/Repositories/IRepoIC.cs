using Intern_Explorer.Models;

namespace Intern_Explorer.Repositories
{
    public interface IRepoIC
    {
        string AddUser(LoginModelDummy loginModelDummy);
        LoggedIn ILogin(LoginModelDummy loginModelDummy);
        ProfileModel GetProfileDetails(string EmployeeId);

    }
}
