namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbegintime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "BeginTime", c => c.String());
            AddColumn("dbo.Courses", "EndTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "EndTime");
            DropColumn("dbo.Courses", "BeginTime");
        }
    }
}
