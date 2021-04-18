namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addavaliable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "NumberAvailable", c => c.Byte(nullable: false));
            DropColumn("dbo.Courses", "MyProperty");

            Sql("UPDATE Courses SET NumberAvailable=NumberInClass");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "MyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Courses", "NumberAvailable");
        }
    }
}
