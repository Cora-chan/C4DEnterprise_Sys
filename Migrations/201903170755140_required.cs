namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(maxLength: 255));
        }
    }
}
