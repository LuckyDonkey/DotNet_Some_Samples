using System.Data.Entity;

namespace EF.Sqlite.CodeFirst.Custom.Migration
{
    public class CourseraContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
