using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst.Custom.Migration
{
    public class Program
    {
        static void Main(string[] args)
        {
            CourseraContextMigration.Initialize();
            
            EnterCourse();
        }

        private static void EnterCourse()
        {
            string name = "";

            while (name != "0")
            {
                Console.WriteLine("Enter name of course (0 to exit):");
                name = Console.ReadLine().Trim();
                if (name != "0")
                {
                    //using (var db = new CourseraContext())
                    using (var db = new CourseraContextMigration())
                    {
                        Course course = new Course();
                        course.Name = name;
                        db.Courses.Add(course);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
