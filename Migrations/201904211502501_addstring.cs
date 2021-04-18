namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Mobile", c => c.String(nullable: false));
            AlterColumn("dbo.People", "PostalCode", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "PostalCode", c => c.Int(nullable: false));
            AlterColumn("dbo.People", "Mobile", c => c.Int(nullable: false));
        }
    }
}
