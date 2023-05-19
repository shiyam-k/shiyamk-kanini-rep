using EmployeeExplorer_M_V_C.ModelDummy;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeExplorer_M_V_C.Repositories
{
    public interface IEmployeeRepository
    {
        string Login(LoginDummy loginCredentials);
        string GetEmployeeType(string EmployeeID);
    }
}
