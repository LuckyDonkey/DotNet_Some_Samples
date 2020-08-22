using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst.Custom.Migration
{
    class CourseraContextHelper
    {
        public CourseraContextHelper()
        {
            Migrations = new Dictionary<int, IList<string>>();

            MigrationVersion1();
        }

        public Dictionary<int, IList<string>> Migrations { get; set; }

        private void MigrationVersion1()
        {
            IList<string> steps = new List<string>();

            steps.Add("CREATE TABLE \"Courses\" (\"Id\" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , \"Name\" TEXT, \"Url\" TEXT)");
            steps.Add("CREATE TABLE \"Students\" (\"Id\" INTEGER, \"FirstName\" TEXT, \"LastName\" TEXT, \"CourseId\" INTEGER)");

            Migrations.Add(1, steps);
        }
    }
}
