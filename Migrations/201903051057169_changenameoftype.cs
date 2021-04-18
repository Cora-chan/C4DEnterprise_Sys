namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changenameoftype : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DanceTypes", newName: "ClassTypes");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ClassTypes", newName: "DanceTypes");
        }
    }
}
