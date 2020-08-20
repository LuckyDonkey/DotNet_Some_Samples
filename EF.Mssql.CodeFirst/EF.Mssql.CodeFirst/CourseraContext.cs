using EF.Mssql.CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Mssql.CodeFirst
{
    internal class CourseraContext : DbContext
    {
        public CourseraContext()
        //: base("Coursera") //DbContext构造方法参数： nameOrConnectionString 可以是数据库名称也可以是数据库链接串，
                             //如不指定数据库名，默认数据库名为类名CourseraContext去掉Context部分，例如此类的默认数据库名是Coursera
        : base("DefaultConnection") //这里指定的是数据库连接串，加在配置文件App.config中。
        {
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>()
                .Property(u => u.UserName)
                .HasColumnName("Id"); //将Teacher表的主键UserName重命名为Id
        }
    }
}
