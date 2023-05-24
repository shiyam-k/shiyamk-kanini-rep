using InternConnect_API.ModelDummy;
using InternConnect_API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InternConnect_API.Repositories
{
    public class RepoEmployee : IRepoEmployee
    {
        private readonly EmployeeDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly SignInManager<Employee> signInManager;
        private readonly IConfiguration configuration;
        private readonly Random random = new Random();
        public RepoEmployee(EmployeeDbContext context, UserManager<Employee> userManager, SignInManager<Employee> signInManager, IConfiguration configuration)
        {
            this.context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.configuration = configuration;
        }
        public EmployeeDetails GetEmployeeDetails(string id)
        {
            EmployeeDetails isEmployee = context.EmployeeDetails.Find(id);
            if(isEmployee != null)
            {
                return isEmployee;
            }
            return null;
        }
        public async Task<IdentityResult> SignUpEmployee(SignUpModel employeeDetails)
        {
            var employee = new Employee()
            {
                Email = employeeDetails.email,
                //Id = $"EID{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}",
                DOB = employeeDetails.DOB,
                DOJ = employeeDetails.DOJ,
                CourrseStream = employeeDetails.CourrseStream,
                Department = employeeDetails.Department,
                FirstName = employeeDetails.FirstName,
                LastName = employeeDetails.LastName,
                UserName = employeeDetails.FirstName + employeeDetails.LastName,
            };
            var result = await userManager.CreateAsync(employee, employeeDetails.Password);
            return result;
        }
        public async Task<string> Login(LoginModel logger)
        {
            var result =await signInManager.PasswordSignInAsync(logger.Email, logger.Password, false, false);
            if(!result.Succeeded)
            {
                return "";
            }

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, logger.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var authSignKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(1),
                claims : authClaims,
                signingCredentials : new SigningCredentials(authSignKey, SecurityAlgorithms.HmacSha256Signature)
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
