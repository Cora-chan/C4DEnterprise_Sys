namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsigninmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SignIns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateSignIn = c.DateTime(nullable: false),
                        Course_Id = c.Int(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .ForeignKey("dbo.People", t => t.Person_Id)
                .Index(t => t.Course_Id)
                .Index(t => t.Person_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SignIns", "Person_Id", "dbo.People");
            DropForeignKey("dbo.SignIns", "Course_Id", "dbo.Courses");
            DropIndex("dbo.SignIns", new[] { "Person_Id" });
            DropIndex("dbo.SignIns", new[] { "Course_Id" });
            DropTable("dbo.SignIns");
        }
    }
}
