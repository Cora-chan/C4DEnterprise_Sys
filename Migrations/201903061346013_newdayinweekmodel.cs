namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdayinweekmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DayInWeeks",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "DayInWeekId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Courses", "DayInWeekId");
            AddForeignKey("dbo.Courses", "DayInWeekId", "dbo.DayInWeeks", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "DayInWeekId", "dbo.DayInWeeks");
            DropIndex("dbo.Courses", new[] { "DayInWeekId" });
            DropColumn("dbo.Courses", "DayInWeekId");
            DropTable("dbo.DayInWeeks");
        }
    }
}
