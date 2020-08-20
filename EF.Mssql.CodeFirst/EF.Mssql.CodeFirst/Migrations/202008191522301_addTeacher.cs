namespace EF.Mssql.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeacher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        Lastname = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
        }
    }
}
