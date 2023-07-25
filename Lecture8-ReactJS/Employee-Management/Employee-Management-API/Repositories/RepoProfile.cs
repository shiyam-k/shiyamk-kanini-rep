using Employee_Management_API.Models;
using Employee_Management_API.Models_Dto_;
using Employee_Management_API.Models_Reques__Response_;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_API.Repositories
{
    public class RepoProfile : IRepoProfile
    {
        private readonly EmployeeManagementDBContext _dbContext;
        public RepoProfile(EmployeeManagementDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public ProfileResponse profileResponse = new();
        public LoginLogs? isLoggedIn= new();
        public EmployeeData? isEmployee = new();
        public ProfileDto profile = new();
        public ProfileResponse ViewProfile(string SId)
        {
            try
            {
                isLoggedIn = _dbContext.LoginLogs.Find(SId); 
                if (isLoggedIn == null)
                {
                    AddResponse(false, "Session Has Expired or Login to Proceed", profile);
                    return profileResponse;
                }
                isEmployee = _dbContext.EmployeeData.Where(x => x.EmployeeId.Equals(isLoggedIn.LoginId)).Include(y => y.Specialization).FirstOrDefault();
                if (isEmployee == null)
                {
                    AddResponse(false, $"No employee data availabe for {isLoggedIn.LoginId}", profile);
                    return profileResponse;
                }
                else
                {
                    SetProfile(isEmployee, isLoggedIn);
                    AddResponse(true, $"Welcome Mx.{isEmployee.EmployeeFirstName} {isEmployee.EmployeLastName}!", profile);
                    return profileResponse;
                }
            }
            catch(Exception ex)
            {
                AddResponse(false, ex.Message, profile);
                return profileResponse;
            }
        }

        
        

        private void AddResponse(bool status, string message, ProfileDto profile)
        {
            profileResponse = new ProfileResponse()
            {
                Status= status,
                Message= message,
                EmployeeProfile= profile
            };
        }
        private void SetProfile(EmployeeData employee, LoginLogs loginLog)
        {
            profile = new ProfileDto()
            {
                SessionId = loginLog.SessionId,
                EmployeeFirstName = employee.EmployeeFirstName,
                EmployeLastName = employee.EmployeLastName,
                EmployeeDOB = employee.EmployeeDOB,
                EmployeeDOJ = employee.EmployeeDOJ,
                EmployeeId = employee.EmployeeId,
                EmployeeQualifications = employee.EmployeeQualifications,
                Specialization = employee?.Specialization?.DomainName,
                ProfileImgURL = employee.EmployeeProfileImg,
                /*Skills = _dbContext.TopicDomain
                    .Where(td => td.DomainId.DomainId == employee.Specialization.DomainId)
                    .Select(td => td.TopicId.TopicName)
                    .ToList(),*/
            };
        }




    }
}
