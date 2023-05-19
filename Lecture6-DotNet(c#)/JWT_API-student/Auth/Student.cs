using System.ComponentModel.DataAnnotations;

namespace JWT_API_student.Auth
{
    public class Student
    {
        [Key]
        public int sid { get; set; }

        public string sname { get; set; }

        public string specialization { get; set; }
    }
}
