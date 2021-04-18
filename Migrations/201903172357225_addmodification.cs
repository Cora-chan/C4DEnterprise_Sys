namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmodification : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false));
        }
    }
}
