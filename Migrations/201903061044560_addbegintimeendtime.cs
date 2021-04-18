namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbegintimeendtime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "BeginDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Courses", "EndDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "EndDate");
            DropColumn("dbo.Courses", "BeginDate");
        }
    }
}
