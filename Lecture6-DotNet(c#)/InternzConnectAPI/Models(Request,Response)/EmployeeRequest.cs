using InternzConnectAPI.Models;

namespace InternzConnectAPI.Models_Request_Response_
{
    public class EmployeeRequest
    {
        public string? EmployeeFirstName { get; set; }
        public string? EmployeeLastName { get; set; }
        public DateTime? EmployeeDOB { get; set; }
        public DateTime? EmployeeDOJ { get; set; }
        public string? Course { get; set; }
        public string? Stream { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
