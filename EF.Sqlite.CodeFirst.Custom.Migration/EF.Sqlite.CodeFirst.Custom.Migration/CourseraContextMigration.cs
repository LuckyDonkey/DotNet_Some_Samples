using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst.Custom.Migration
{
    public class CourseraContextMigration : DbContext
    {
        public static int RequiredDatabaseVersion = 1;

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<SchemaInfo> SchemaInfoes { get; set; }

        public static void Initialize()
        {
            using (CourseraContextMigration courseraContext = new CourseraContextMigration())
            {
                int currentVersion = 0;
                if (courseraContext.SchemaInfoes.Count() > 0)
                    currentVersion = courseraContext.SchemaInfoes.Max(x => x.Version);
                CourseraContextHelper mmSqliteHelper = new CourseraContextHelper();
                while (currentVersion < RequiredDatabaseVersion)
                {
                    currentVersion++;
                    foreach (string migration in mmSqliteHelper.Migrations[currentVersion])
                    {
                        courseraContext.Database.ExecuteSqlCommand(migration);
                    }
                    courseraContext.SchemaInfoes.Add(new SchemaInfo() { Version = currentVersion });
                    courseraContext.SaveChanges();
                }
            }

        }
    }
}
