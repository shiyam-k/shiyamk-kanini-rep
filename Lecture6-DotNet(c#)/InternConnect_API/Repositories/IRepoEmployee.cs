using InternConnect_API.ModelDummy;
using InternConnect_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InternConnect_API.Repositories
{
    public interface IRepoEmployee
    {
        EmployeeDetails GetEmployeeDetails(string id);
        Task<IdentityResult> SignUpEmployee(SignUpModel employeeDetails);
        Task<string> Login(LoginModel logger);
    }
}
