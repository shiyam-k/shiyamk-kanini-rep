using InternzConnectAPI.Models;

namespace InternzConnectAPI.Models_Request_Response_
{
    public class EmployeeRoleResponse
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public List<EmployeeRole>? EmployeeRoles { get; set; }
    }
}
