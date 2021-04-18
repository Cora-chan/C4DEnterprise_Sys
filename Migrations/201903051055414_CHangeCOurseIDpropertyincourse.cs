namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CHangeCOurseIDpropertyincourse : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CourseId", c => c.Byte(nullable: false));
        }
    }
}
