namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleterequiremt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Courses", "NumberInClass");
            DropColumn("dbo.Courses", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Courses", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.Courses", "NumberInClass", c => c.Byte(nullable: false));
        }
    }
}
