namespace EF.Mssql.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameTeacherPrimiryKeyName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Teachers", name: "UserName", newName: "Id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Teachers", name: "Id", newName: "UserName");
        }
    }
}
