namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDanceType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DanceTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "TypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Courses", "TypeId");
            AddForeignKey("dbo.Courses", "TypeId", "dbo.DanceTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "TypeId", "dbo.DanceTypes");
            DropIndex("dbo.Courses", new[] { "TypeId" });
            DropColumn("dbo.Courses", "TypeId");
            DropTable("dbo.DanceTypes");
        }
    }
}
