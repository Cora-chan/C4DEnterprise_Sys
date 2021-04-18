namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnumberodcourse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "NumberInClass", c => c.Byte(nullable: false));
            AddColumn("dbo.Courses", "MyProperty", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "MyProperty");
            DropColumn("dbo.Courses", "NumberInClass");
        }
    }
}
