using CodeFirstNewDatabaseSample.Models;
using System;

namespace CodeFirstNewDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {


            int option = -1;
            while (option != 0)
            {
                Console.WriteLine("Choose an option (0, 1, 2):" + Environment.NewLine +
                    "1. Enter a course" + Environment.NewLine +
                    "2. Enter a student" + Environment.NewLine +
                    "3. List all courses" + Environment.NewLine +
                    "4. List all students" + Environment.NewLine +
                    "0. Exit" + Environment.NewLine);
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            EnterCourse();
                            break;

                        case 2:
                            EnterStudent();
                            break;

                        case 3:
                            ListAllCourses();
                            break;

                        case 4:
                            ListAllStudents();
                            break;
                    }
                }
            }
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }

        private static void ListAllStudents()
        {
            throw new NotImplementedException();
        }

        private static void ListAllCourses()
        {
            using (var db = new CourseraContext())
            {
                foreach (Course course in db.Courses)
                    Console.WriteLine(string.Format("Course: {0} - {1}", course.Id, course.Name) + Environment.NewLine);
            }
        }

        private static void EnterStudent()
        {
            throw new NotImplementedException();
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
}
