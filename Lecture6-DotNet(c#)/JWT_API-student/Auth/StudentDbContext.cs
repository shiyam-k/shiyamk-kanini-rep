using Microsoft.EntityFrameworkCore;

namespace JWT_API_student.Auth
{
    public class StudentDbContext : DbContext
    {

        public StudentDbContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Student> Students { get; set; }

    }
}
}
