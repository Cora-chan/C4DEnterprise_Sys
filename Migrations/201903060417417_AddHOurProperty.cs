namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHOurProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Hour", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "Hour");
        }
    }
}
