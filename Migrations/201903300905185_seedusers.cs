namespace C4DEnterpriseSys_ver1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedusers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7fc6357c-e5d3-4895-aea8-22d7a2882f15', N'student@champions4dance.com', 0, N'AIqG4IKaYb//AZGVfiaGQxtatzeM7wk7K8q3v+Vi7PQ0lqCSQn0g6eCYMLW/osbfiQ==', N'2e8284ae-3df0-4eba-8266-c6c573ed58f7', NULL, 0, 0, NULL, 1, 0, N'student@champions4dance.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fa8fcfe1-14b1-4781-912c-1c0bad66f339', N'admin@champions4dance.com', 0, N'AM7u1rQ7ft19BMT5nbL7JptGhmfo6ftzosA+q1PKIL72ifCmDSl13MEszQCfU8bWuA==', N'5883dffe-25d1-438f-8e41-8a33127c8aeb', NULL, 0, 0, NULL, 1, 0, N'admin@champions4dance.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a8e6c065-f39f-4762-8b18-05c8befeef23', N'CanManageCourses')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fa8fcfe1-14b1-4781-912c-1c0bad66f339', N'a8e6c065-f39f-4762-8b18-05c8befeef23')


");

        }

    public override void Down()
        {
        }
    }
}
