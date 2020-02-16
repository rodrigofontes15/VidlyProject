namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAdminRole : DbMigration
    {
        public override void Up()
        {
            Sql(@" INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83c721c9-4a88-48a0-9f22-2bfa113c5707', N'3bd3d669-0b4b-4434-9d51-b9c8830ca941')
");
        }
        
        public override void Down()
        {
        }
    }
}
