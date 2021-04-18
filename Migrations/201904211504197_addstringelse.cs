namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstringelse : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Mobile", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Mobile", c => c.String(nullable: false));
        }
    }
}
