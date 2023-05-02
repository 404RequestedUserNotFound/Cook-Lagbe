namespace Cook_Lagbe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BuaLagbeChangetoCookLagbe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        booking_id = c.Int(nullable: false, identity: true),
                        booking_date = c.DateTime(nullable: false),
                        user_id = c.Int(nullable: false),
                        cook_id = c.Int(nullable: false),
                        is_accepted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.booking_id)
                .ForeignKey("dbo.Cooks", t => t.cook_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.cook_id);
            
            CreateTable(
                "dbo.Cooks",
                c => new
                    {
                        cook_id = c.Int(nullable: false, identity: true),
                        cook_name = c.String(nullable: false),
                        cook_address = c.String(nullable: false, maxLength: 100),
                        cook_phone = c.String(nullable: false),
                        cook_image = c.String(nullable: false),
                        cook_description = c.String(nullable: false, maxLength: 100),
                        cook_NID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.cook_id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        payment_id = c.Int(nullable: false, identity: true),
                        payment_date = c.DateTime(nullable: false),
                        payment_amount = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                        cook_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.payment_id)
                .ForeignKey("dbo.Cooks", t => t.cook_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.cook_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(nullable: false, maxLength: 50),
                        user_image = c.String(nullable: false),
                        user_address = c.String(nullable: false, maxLength: 200),
                        user_phone = c.String(nullable: false),
                        user_profession = c.String(nullable: false),
                        user_NID = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.user_id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        review_id = c.Int(nullable: false, identity: true),
                        review_text = c.String(nullable: false, maxLength: 200),
                        review_date = c.DateTime(nullable: false),
                        user_id = c.Int(nullable: false),
                        cook_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.review_id)
                .ForeignKey("dbo.Cooks", t => t.cook_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.cook_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "user_id", "dbo.Users");
            DropForeignKey("dbo.Reviews", "cook_id", "dbo.Cooks");
            DropForeignKey("dbo.Payments", "user_id", "dbo.Users");
            DropForeignKey("dbo.Bookings", "user_id", "dbo.Users");
            DropForeignKey("dbo.Payments", "cook_id", "dbo.Cooks");
            DropForeignKey("dbo.Bookings", "cook_id", "dbo.Cooks");
            DropIndex("dbo.Reviews", new[] { "cook_id" });
            DropIndex("dbo.Reviews", new[] { "user_id" });
            DropIndex("dbo.Payments", new[] { "cook_id" });
            DropIndex("dbo.Payments", new[] { "user_id" });
            DropIndex("dbo.Bookings", new[] { "cook_id" });
            DropIndex("dbo.Bookings", new[] { "user_id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Payments");
            DropTable("dbo.Cooks");
            DropTable("dbo.Bookings");
        }
    }
}
