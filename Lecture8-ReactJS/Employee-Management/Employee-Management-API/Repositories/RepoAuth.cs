using Employee_Management_API.Models;
using Employee_Management_API.Models_Request_;
using Employee_Management_API.Models_Response_;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Employee_Management_API.Repositories
{
    public class RepoAuth : IRepoAuth
    {
        private readonly Random random = new();
        private readonly EmployeeManagementDBContext _dbContext;
        private readonly IConfiguration Configuration;
        
        public RepoAuth(EmployeeManagementDBContext context, IConfiguration configuration)
        {
            _dbContext = context;
            Configuration = configuration;
        }
        public LoginResponse loginResponse = new LoginResponse();
        public LoginLogs loginLog = new LoginLogs();
        public EmployeeData? isEmployeeExists = new EmployeeData();
        public async Task<LoginResponse> Login(LoginDto loginCredentials)
        {
            try
            {
                isEmployeeExists = await _dbContext.EmployeeData.FindAsync(loginCredentials.LoginId);
                if(isEmployeeExists == null)
                {
                    AddResponse(false, $"Employee Id {loginCredentials.LoginId} Not Found", "", "ERROR FETCHING ROLES", "ERROR FETCHING SESSION ID", loginLog);
                    return loginResponse;
                }
                else if(!VerifyPassword(loginCredentials.Password ?? "", isEmployeeExists.EmployeePasswordHash, isEmployeeExists.EmployeePasswordSalt))
                {
                    AddResponse(VerifyPassword(loginCredentials.Password ?? "", isEmployeeExists.EmployeePasswordHash, isEmployeeExists.EmployeePasswordSalt), "Passwords Dont Match", "ERROR FETCHING TOKEN", "ERROR FETCHING ROLES", "ERROR FETCHING SESSION ID", loginLog);
                    return loginResponse;
                }
                else
                {
                    string role = _dbContext.EmployeeRoles.Where(x => (x.Employees.EmployeeId).Equals(loginCredentials.LoginId)).Select(y => y.Role).FirstOrDefaultAsync().Result.RoleId;
                    string tokenString = CreateToken(loginCredentials, role);
                    AddLoginLogs($"SID{random.Next(100, 999)}", loginCredentials, true, tokenString);
                    await _dbContext.LoginLogs.AddAsync(loginLog);
                    await _dbContext.SaveChangesAsync();
                    AddResponse(true, $"User {isEmployeeExists.EmployeeFirstName} {isEmployeeExists.EmployeLastName} Logged In on Session Id : {loginLog.SessionId}", tokenString, role, loginLog.SessionId, loginLog);
                    return loginResponse;
                }
            }
            catch(Exception ex)
            {
                AddResponse(false, $"{ex.Message}", "", "ERROR FETCHING ROLES", "ERROR FETCHING SESSION ID", loginLog);
                return loginResponse;
            }
        }

        public async Task<LoginResponse> Logout(string sessionId)
        {
            try
            {
                loginLog = await _dbContext.LoginLogs.FindAsync(sessionId);
                if(loginLog == null )
                {
                    AddResponse(false, $"Session Id : {sessionId} is inactive", "", "", "", loginLog);
                    return loginResponse;
                }
                else if (!loginLog.IsLoggedIn)
                {
                    AddResponse(false, $"Session Id {sessionId} is Expired", "", "", "", loginLog);
                    return loginResponse;
                }
                loginLog.IsLoggedIn = false;
                _dbContext.Update(loginLog);
                await _dbContext.SaveChangesAsync();
                AddResponse(true, $"User {loginLog.LoginId} has logged out of session {loginLog.SessionId}", "", "", "", loginLog);
                return loginResponse;
            }
            catch(Exception ex)
            {
                    AddResponse(false, ex.Message, "", "", "", loginLog);
                return loginResponse;
            }
        }

        private void AddResponse(bool status, string message, string token, string role, string sId, LoginLogs log)
        {
            loginResponse = new LoginResponse()
            {
                Status = status,
                Message = message,
                Token = token,
                Role = role,
                SessionId = sId,
                LoginLog= log
            };
        }
        private void AddLoginLogs(string sessionId, LoginDto loginCredentials, bool isLoggedIn, string token)
        {
            loginLog = new LoginLogs()
            {
                SessionId = sessionId,
                LoginId= loginCredentials.LoginId,
                Token = token,
                IsLoggedIn= isLoggedIn
            };
        }
        public bool VerifyPassword(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                byte[] computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        
        public string CreateToken(LoginDto loginCredentials, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginCredentials.LoginId ?? ""),
                new Claim(ClaimTypes.Role, role)
            };
            string secretKey = Configuration["JWT:Key"] ?? ""; 
            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: Configuration["JWT:ValidIssuer"],
                audience: Configuration["JWT:ValidAudience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(2),
                signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordKey)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordKey = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }



        


    }
}
