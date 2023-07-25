using Employee_Management_API.Models;
using Employee_Management_API.Models_Dto_;

namespace Employee_Management_API.Models_Reques__Response_
{
    public class ProfileResponse
    {
        public bool Status { get; set; }
        public string? Message { get; set; }
        public ProfileDto? EmployeeProfile { get; set; }
    }
}
