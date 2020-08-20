using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseSample.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; } //新增加的属性

        //使用虚拟方法的作用是：将启用实体框架的延迟加载功能。 
        //延迟加载是指在您尝试访问这些属性时，这些属性的内容将自动从数据库加载。
        public virtual List<Student> Students { get; set; }
    }
}
