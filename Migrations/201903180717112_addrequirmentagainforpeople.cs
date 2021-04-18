namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequirmentagainforpeople : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Address", c => c.String());
        }
    }
}
