namespace Intern_Explorer.Models
{
    public class LoggedIn
    {
        public bool IsLoggedIn { get; set; }
        public string SessionId { get; set; }
        public string EmployeeId { get; set; }
        public string Message { get; set; }
    }
}
