using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst
{
    public class CourseraContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //实现自动Migration
            var initializer = new SqliteDropCreateDatabaseWhenModelChanges<CourseraContext>(modelBuilder);
            Database.SetInitializer(initializer);
        }
    }
}
