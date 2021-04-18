namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adddeletereuiredagain : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Email", c => c.String());
            AlterColumn("dbo.People", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.People", "Email", c => c.String(nullable: false));
        }
    }
}
