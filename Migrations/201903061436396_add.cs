namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "CourseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
        }
    }
}
