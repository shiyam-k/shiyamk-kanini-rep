using EmployeeExplorer_M_V_C.ModelDummy;
using EmployeeExplorer_M_V_C.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeExplorer_M_V_C.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext context;
        private readonly Random random = new Random();
        public EmployeeRepository(EmployeeDBContext context) 
        {
            this.context = context;
        } 
        public string Login(LoginDummy loginCredentials)
        {
            string result = "";
            Login? session = null;
            EmployeeCredentials empCred = context.EmployeeCredentials.Find(loginCredentials.LoginEmployeeId);
            if (empCred == null)
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentials = empCred,
                    Status = "Employee ID Not Found"
                };
                context.Logins.Add(session);
                context.SaveChanges();
                result = session.Status;
                return result;


            }
            else if (loginCredentials.Password != empCred.Password)
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentials = empCred,
                    Status = "Passwords Dont Match"
                };
                context.Logins.Add(session);
                context.SaveChanges();
                result = session.Status;
                return result;
            }
            else
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentials = empCred,
                    Status = "Success"
                };
                context.Logins.AddAsync(session);
                context.SaveChanges();
                result = context.EmployeeRoles
                    .Where(er => er.Employee.EmployeeId == loginCredentials.LoginEmployeeId)
                    .Select(er => er.Role.RoleName)
                    .FirstOrDefault().ToString();
                if (result.Equals("Engineer"))
                {
                    string isAdmin = context.EmployeeRoles.Where(ia => ia.Employee.EmployeeId == loginCredentials.LoginEmployeeId).
                        Select(ia => ia.Designation).ToString();
                    if (isAdmin.Equals("Admin"))
                    {
                        return isAdmin;
                    }
                }
                return result;
            }
        }
       
    }
}
