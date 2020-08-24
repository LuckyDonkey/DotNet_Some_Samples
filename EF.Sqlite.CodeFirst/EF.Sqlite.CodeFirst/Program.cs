using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            EnterCourse();
        }

        protected static void EnterCourse()
        {
            string name = "";
            while (name != "0")
            {
                Console.WriteLine("请输入课程：");
                name = Console.ReadLine();

                using (var db = new CourseraContext())
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
