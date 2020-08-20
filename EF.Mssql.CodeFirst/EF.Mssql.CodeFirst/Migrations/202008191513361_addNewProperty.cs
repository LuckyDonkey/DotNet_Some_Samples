namespace EF.Mssql.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "NewField", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "NewField");
        }
    }
}
