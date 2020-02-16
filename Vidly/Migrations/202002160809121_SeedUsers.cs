namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'07352def-81e7-4b4a-bdb5-dc8c774ae957', N'guest@vidly.com', 0, N'AFkN31v7VcXkEGz2q4mRBaYzi7XHnwTKz/64PzTtTs/Cex7kmaEEQ5+GktiCSFmJWg==', N'a12861f0-7cbf-47b5-9582-cc910f0b4861', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6cf8b536-9d4b-4c61-9558-a968bf59e295', N'admin@vidly.com', 0, N'AOTywSo+DgqP4qHpK+ry3WgjbeCGzcjFRU4XEorcNPDxEJsHYXopYdFrbkgRUEkkPQ==', N'18ff7b19-016e-48f1-a435-3f593d9c47da', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3bd3d669-0b4b-4434-9d51-b9c8830ca941', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'6cf8b536-9d4b-4c61-9558-a968bf59e295', N'3bd3d669-0b4b-4434-9d51-b9c8830ca941')
");
        }
        
        public override void Down()
        {
        }
    }
}
