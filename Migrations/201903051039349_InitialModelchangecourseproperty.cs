namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModelchangecourseproperty : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "CourseId", "dbo.Courses");
            DropIndex("dbo.People", new[] { "CourseId" });
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.People", "CourseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "Id");
            CreateIndex("dbo.People", "CourseId");
            AddForeignKey("dbo.People", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "CourseId", "dbo.Courses");
            DropIndex("dbo.People", new[] { "CourseId" });
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.People", "CourseId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Courses", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.Courses", "Id");
            CreateIndex("dbo.People", "CourseId");
            AddForeignKey("dbo.People", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
        }
    }
}
