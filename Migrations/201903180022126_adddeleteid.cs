namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddeleteid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.People", "SchoolId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.People", "SchoolId", c => c.Int(nullable: false));
        }
    }
}
