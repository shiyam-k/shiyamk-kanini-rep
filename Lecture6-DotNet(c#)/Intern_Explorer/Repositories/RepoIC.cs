using Intern_Explorer.Auth;
using Intern_Explorer.Models;
using Microsoft.AspNetCore.Mvc;

namespace Intern_Explorer.Repositories
{
    public class RepoIC : IRepoIC
    {
        private readonly InternDBContext context;
        private readonly Random random = new Random();
        public RepoIC(InternDBContext context)
        {
            this.context = context;
        }

         
        public string AddUser(LoginModelDummy loginModelDummy)
        {
            InternData internExists = context.InternData.Find(loginModelDummy.InternId);
            if (internExists != null)
            {
                return "User Exists";
            }
            else
            {
                InternData newIntern = new InternData()
                {
                    InternId = loginModelDummy.InternId,
                    InternName = $"{loginModelDummy.FirstName} {loginModelDummy.LastName}",
                    DateOfJoin = loginModelDummy.DateOfJoin,
                    DateOfBirth = loginModelDummy.DateOfBirth,
                    CourseStream = loginModelDummy.CourseStream,
                    Department = loginModelDummy.Department,
                    Email = loginModelDummy.Email,
                };
                context.InternData.Add(newIntern);
                context.SaveChanges();
                LoginCredentials newlogins = new LoginCredentials()
                {
                    EmployeeId = loginModelDummy.InternId,
                    Password = loginModelDummy.Password,
                };
                context.LoginCredentials.Add(newlogins);
                context.SaveChanges();
                return "User Added";
            }
        }
        public LoggedIn ILogin(LoginModelDummy loginModelDummy)
        {
            LoginCredentials isLogin = context.LoginCredentials.Find(loginModelDummy.InternId);
            LoggedIn loggerData = new LoggedIn();
            if(isLogin == null) 
            {
                loggerData.IsLoggedIn = false;
                loggerData.Message = "User Not Found";
                return loggerData;
            }
            else
            {
                if(isLogin.EmployeeId != loginModelDummy.InternId || isLogin.Password != loginModelDummy.Password) 
                {
                    loggerData.IsLoggedIn = false;
                    loggerData.Message = "Incorrect Login Credentials";
                    return loggerData;
                }
                else
                {
                    LoginLog newLog = new LoginLog()
                    {
                        EmployeeId = loginModelDummy.InternId,
                        SessioId = $"SID{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}"
                    };
                    context.LoginLogs.Add(newLog);
                    context.SaveChanges();
                    loggerData.SessionId = newLog.SessioId;
                    loggerData.IsLoggedIn = true;
                    loggerData.EmployeeId = loginModelDummy.InternId;
                    loggerData.Message = "Loggedin";
                    loggerData.IsLoggedIn = true;

                    return loggerData;
                }
            }
        }
        public ProfileModel GetProfileDetails(string EmployeeId)
        {
            InternData internExists = context.InternData.Find(EmployeeId);
            LoginCredentials loginExists = context.LoginCredentials.Find(EmployeeId);
            ProfileModel profile = new ProfileModel();
            if(internExists == null )
            {
                profile.isProfileExists = false;
                profile.Message = "Intern data Not Exists";
                return profile;
            }
            else if(loginExists == null )
            {
                profile.isProfileExists = false;
                profile.Message = "Login Credentials Not Exists";
                return profile;
            }
            else
            {
                profile.isProfileExists = true;
                profile.InternId = internExists.InternId;
                profile.DateOfBirth = internExists.DateOfBirth;
                profile.DateOfJoin = internExists.DateOfJoin;
                profile.CourseStream = internExists.CourseStream;
                profile.Department = internExists.Department;
                profile.Email = internExists.Email;
                profile.Password = loginExists.Password;
                profile.Message = "Profile Found";
            }
            return profile;
        }
    }
}
