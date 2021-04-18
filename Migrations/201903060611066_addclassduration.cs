namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addclassduration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "ClassDuration", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "ClassDuration");
        }
    }
}
