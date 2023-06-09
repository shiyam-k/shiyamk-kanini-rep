namespace InternzConnectAPI.Models
{
    public class EmployeeResponse
    {
        public bool? Status { get; set; }
        public string? Message { get; set; }
        public List<EmployeeData>? EmployeeRequest { get; set; }
    }
}
