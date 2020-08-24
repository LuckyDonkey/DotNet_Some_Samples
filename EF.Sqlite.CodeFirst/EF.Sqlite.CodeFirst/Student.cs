using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Sqlite.CodeFirst
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        //使用虚拟方法的作用是：将启用实体框架的延迟加载功能。 
        //延迟加载是指在您尝试访问这些属性时，这些属性的内容将自动从数据库加载。
        public virtual Course Courses { get; set; }
    }
}
