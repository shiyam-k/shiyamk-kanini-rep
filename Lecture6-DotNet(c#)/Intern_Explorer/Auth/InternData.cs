using System.ComponentModel.DataAnnotations;

namespace Intern_Explorer.Auth
{
    public class InternData
    {
        [Key]
        public string InternId { get; set; }
        public string InternName { get; set; } = string.Empty;
        public string DateOfJoin { get; set; } = string.Empty;
        public string DateOfBirth { get; set; } = string.Empty;
        public string CourseStream { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

    }
}
