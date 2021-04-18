namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeclasstype : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "TypeId", newName: "CTypeId");
            RenameIndex(table: "dbo.Courses", name: "IX_TypeId", newName: "IX_CTypeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_CTypeId", newName: "IX_TypeId");
            RenameColumn(table: "dbo.Courses", name: "CTypeId", newName: "TypeId");
        }
    }
}
