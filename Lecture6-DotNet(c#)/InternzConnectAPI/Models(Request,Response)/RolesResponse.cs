using InternzConnectAPI.Models;

namespace InternzConnectAPI.Models_Request_Response_
{
    public class RolesResponse
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public List<Roles>? Roles { get; set; }
    }
}
