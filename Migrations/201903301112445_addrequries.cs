namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrequries : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SignIns", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SignIns", "Person_Id", "dbo.People");
            DropIndex("dbo.SignIns", new[] { "Course_Id" });
            DropIndex("dbo.SignIns", new[] { "Person_Id" });
            AlterColumn("dbo.SignIns", "Course_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.SignIns", "Person_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.SignIns", "Course_Id");
            CreateIndex("dbo.SignIns", "Person_Id");
            AddForeignKey("dbo.SignIns", "Course_Id", "dbo.Courses", "Id", cascadeDelete: false);
            AddForeignKey("dbo.SignIns", "Person_Id", "dbo.People", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignIns", "Person_Id", "dbo.People");
            DropForeignKey("dbo.SignIns", "Course_Id", "dbo.Courses");
            DropIndex("dbo.SignIns", new[] { "Person_Id" });
            DropIndex("dbo.SignIns", new[] { "Course_Id" });
            AlterColumn("dbo.SignIns", "Person_Id", c => c.Int());
            AlterColumn("dbo.SignIns", "Course_Id", c => c.Int());
            CreateIndex("dbo.SignIns", "Person_Id");
            CreateIndex("dbo.SignIns", "Course_Id");
            AddForeignKey("dbo.SignIns", "Person_Id", "dbo.People", "Id");
            AddForeignKey("dbo.SignIns", "Course_Id", "dbo.Courses", "Id");
        }
    }
}
