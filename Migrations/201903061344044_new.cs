namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "DayOfWeek");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "DayOfWeek", c => c.Int(nullable: false));
        }
    }
}
