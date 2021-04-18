namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "BeginTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Courses", "EndTime", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Courses", "BeginTime", c => c.DateTime(nullable: false));
        }
    }
}
