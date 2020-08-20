namespace CodeFirstNewDatabaseSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCourse_Url : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Url");
        }
    }
}
