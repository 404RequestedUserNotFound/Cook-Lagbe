namespace Bua_Lagbe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buaacceptrejectattribiurs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Buas", "bua_Description", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Users", "user_image", c => c.String(nullable: false));
            AddColumn("dbo.Users", "user_address", c => c.String(nullable: false, maxLength: 200));
            AddColumn("dbo.Users", "user_phone", c => c.String(nullable: false));
            AddColumn("dbo.Users", "user_profession", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "user_name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Reviews", "review_text", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Buas", "bua_bio");
            DropColumn("dbo.Users", "user_photo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "user_photo", c => c.String(nullable: false));
            AddColumn("dbo.Buas", "bua_bio", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Reviews", "review_text", c => c.String(maxLength: 200));
            AlterColumn("dbo.Users", "user_name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "user_profession");
            DropColumn("dbo.Users", "user_phone");
            DropColumn("dbo.Users", "user_address");
            DropColumn("dbo.Users", "user_image");
            DropColumn("dbo.Buas", "bua_Description");
        }
    }
}
