using CodeFirstNewDatabaseSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseSample
{
    internal class CourseraContext : DbContext
    {
        public CourseraContext() : base("DefaultConnection") { }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //使用Fluent API，将Student的属性LastName长度限制为20字符
            //效果和[MaxLength(20)]相同
            modelBuilder.Entity<Student>()
                .Property(u => u.LastName)
                .HasMaxLength(20);
        }
    }
}
