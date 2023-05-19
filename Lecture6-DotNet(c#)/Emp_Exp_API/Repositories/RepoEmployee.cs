using Emp_Exp_API.Models;
using Emp_Exp_API.ModelsDummy;
using Emp_Exp_API.ReturnData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Emp_Exp_API.Repositories
{
    public class RepoEmployee : IRepoEmployee
    {
        private readonly EmployeeDbContext context;
        private readonly Random random = new Random();
        
        public RepoEmployee(EmployeeDbContext context)
        {
            this.context = context;
        }
        public ActionResult<string> Login(LoginDummy loginCredentials)
        {
            Login? session = null;
            EmployeeCredential empCred = context.EmployeeCredentials.Find(loginCredentials.LoginEmployeeId);
            if (empCred == null)
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentialsEmployee = empCred,
                    EmployeeCredentialsEmployeeId = empCred.EmployeeId,
                    Status = "Failure"
                };
                context.Logins.Add(session);
                context.SaveChanges();
                return "No Employee Found";


            }
            else if (loginCredentials.Password != empCred.Password)
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentialsEmployee = empCred,
                    Status = "Failure"
                };
                context.Logins.Add(session);
                context.SaveChanges();
                return "Password Dont Match";
            }
            else
            {
                session = new Login()
                {
                    SessionId = $"SID{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}{random.Next(1, 9)}",
                    LoginEmployeeId = loginCredentials.LoginEmployeeId,
                    Password = loginCredentials.Password,
                    EmployeeCredentialsEmployee = empCred,
                    Status = "Success"
                };
                 context.Logins.Add(session);
                context.SaveChanges();
                var role = context.EmployeeRoles
                    .Where(er => er.Employee.EmployeeId == loginCredentials.LoginEmployeeId)
                    .Select(er => er.Role.RoleName)
                    .FirstOrDefault().ToString();
                if (role.Equals("Engineer"))
                {
                    string isAdmin = context.EmployeeRoles.Where(ia => ia.Employee.EmployeeId == loginCredentials.LoginEmployeeId).
                        Select(ia => ia.Designation).FirstOrDefault().ToString();
                    if (isAdmin.Equals("Admin"))
                    {
                        return isAdmin;
                    }
                }
                return role;
            }
        }

               

        public async Task<ActionResult<EmployeeProfile>> GetEmployeeProfile(string EmployeeId)
        {
            Employee employeeData = await context.Employees.FindAsync(EmployeeId);
            EmployeeCredential employeeCredential = await context.EmployeeCredentials.FindAsync(EmployeeId);
            EmployeeProfile employeeProfile = new EmployeeProfile();
            if (employeeCredential == null && employeeData == null)
            {
                return new EmployeeProfile();
            }
            else if(employeeCredential != null && employeeData == null) 
            {
                employeeProfile = new EmployeeProfile()
                {
                    EmployeeId = employeeCredential.EmployeeId,
                    Password = employeeCredential.Password,
                    Email = employeeCredential.Email,
                };
                return employeeProfile;
            }
            else if(employeeCredential == null && employeeData != null)
            {
                employeeProfile = new EmployeeProfile()
                {
                    EmployeeId = employeeData.EmployeeId,
                    FirstName = employeeData.FirstName,
                    LastName = employeeData.LastName,
                    DateOfBirth = employeeData.DateOfBirth,
                    Gender = employeeData.Gender,
                    Phone = employeeData.Phone,
                };
                return employeeProfile;
            }
            else
            {
                employeeProfile = new EmployeeProfile()
                {
                    EmployeeId = employeeCredential.EmployeeId,
                    Password = employeeCredential.Password,
                    Email = employeeCredential.Email,
                    FirstName = employeeData.FirstName,
                    LastName = employeeData.LastName,
                    DateOfBirth = employeeData.DateOfBirth,
                    Gender = employeeData.Gender,
                    Phone = employeeData.Phone,
                    Role = context.EmployeeRoles.Where(x => x.EmployeeId == EmployeeId).Select(x => x.Role).Select(x => x.RoleName).FirstOrDefault().ToString(),

                };
            }
            return employeeProfile;
        }

        public async Task<ActionResult<EmployeeProjects>> GetEmployeeProjectDetails(string EmployeeId)
        {
            string employeeRole = context.EmployeeRoles.Where(r => r.EmployeeId == EmployeeId).Select(r => r.RoleId).FirstOrDefault().ToString();

            EmployeeProjects employeeProjects = new EmployeeProjects();

            if (employeeRole.Equals("RID101"))
            {
                employeeProjects = new EmployeeProjects()
                {
                    EmployeeId = EmployeeId,
                    EProjects = await context.EngineerProjects.Include(x => x.ProjectsProject).Where(x => x.EngineerEmployeeId == EmployeeId).ToListAsync(),
                };
            }
            else if (employeeRole.Equals("RID102"))
            {
                employeeProjects = new EmployeeProjects()
                {
                    EmployeeId = EmployeeId,
                    MProjects = await context.ManagerProjects.Include(x => x.ProjectsProject).Where(x => x.ManagerEmployeeId == EmployeeId).ToListAsync(),
                };
            }

            
            return employeeProjects ;
        } 
        public async Task<ActionResult<string>> AssignProject(AddProjectsDummy projectData)
        {
            Employee employee = await context.Employees.FindAsync(projectData.EmployeeId);
            Project project = await context.Projects.FindAsync(projectData.ProjectId);
            ManagerProject managerProject = await context.ManagerProjects.FindAsync(projectData.ManagerId);
            if(employee == null)
            {
                return "Employee Not Found";
            }
            if(project == null)
            {
                return "Project Not Found";
            }
            if (managerProject == null)
            {
                return "Manager Not Found";
            }
            EngineerProject projectAllocation = new EngineerProject()
            {
                EngineerProjectId = "EPID" + (random.Next(0, 9)) + (random.Next(0, 9)) + (random.Next(0, 9)),
                EngineerEmployeeId = employee.EmployeeId,
                ProjectsProjectId= projectData.ProjectId,
                ManagerProjectId = projectData.ManagerId,
                ProjectsProject = project,
                EngineerEmployee = employee,
                ManagerProject = managerProject
            };
            await context.EngineerProjects.AddAsync(projectAllocation);
            await context.SaveChangesAsync();
            return "Added";
        }
        public async Task<ActionResult<string>> UpdateProject(UpdateProjectDummy updateProject)
        {
            EngineerProject project = await context.EngineerProjects.FindAsync(updateProject.EngineerProjectId);
            if(project == null)
            {
                return "Project Not availabe";
            }
            project.EngineerEmployeeId = updateProject.EngineerId;
            project.EngineerEmployee = await context.Employees.FindAsync(updateProject.EngineerId);
            context.EngineerProjects.Update(project);
            await context.SaveChangesAsync();
            
            return "Updated";
        }
    }
}
