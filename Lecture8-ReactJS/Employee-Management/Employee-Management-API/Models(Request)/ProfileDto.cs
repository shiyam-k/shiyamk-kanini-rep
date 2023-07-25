using Employee_Management_API.Models;

namespace Employee_Management_API.Models_Dto_
{
    public class ProfileDto
    {
        public string? SessionId { get; set; }
        public string? EmployeeId { get; set; }
        public string? EmployeeFirstName { get; set; }
        public string? EmployeLastName { get; set; }
        public string? EmployeeDOJ { get; set; }
        public string? EmployeeDOB { get; set; }
        public string? Specialization { get; set; }
        public dynamic? Skills { get; set; }
        public string? ProfileImgURL { get; set; }
        public string? EmployeeQualifications { get; set; }
    }
}
