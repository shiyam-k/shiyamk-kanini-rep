namespace Intern_Explorer.Models
{
    public class ProfileModel
    {
        public bool isProfileExists { get; set; }
        public string InternId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DateOfJoin { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string CourseStream { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;

    }
}
