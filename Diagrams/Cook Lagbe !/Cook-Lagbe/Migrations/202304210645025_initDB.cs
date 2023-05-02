namespace Bua_Lagbe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
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
                        bua_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.booking_id)
                .ForeignKey("dbo.Buas", t => t.bua_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.bua_id);
            
            CreateTable(
                "dbo.Buas",
                c => new
                    {
                        bua_id = c.Int(nullable: false, identity: true),
                        bua_name = c.String(nullable: false),
                        bua_address = c.String(nullable: false, maxLength: 100),
                        bua_phone = c.String(nullable: false),
                        bua_image = c.String(nullable: false),
                        bua_bio = c.String(nullable: false, maxLength: 100),
                        bua_NID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.bua_id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        payment_id = c.Int(nullable: false, identity: true),
                        payment_date = c.DateTime(nullable: false),
                        payment_amount = c.Int(nullable: false),
                        user_id = c.Int(nullable: false),
                        bua_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.payment_id)
                .ForeignKey("dbo.Buas", t => t.bua_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.bua_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        user_id = c.Int(nullable: false, identity: true),
                        user_name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                        user_photo = c.String(nullable: false),
                        user_NID = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.user_id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        review_id = c.Int(nullable: false, identity: true),
                        review_text = c.String(maxLength: 200),
                        review_date = c.DateTime(nullable: false),
                        user_id = c.Int(nullable: false),
                        bua_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.review_id)
                .ForeignKey("dbo.Buas", t => t.bua_id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.user_id, cascadeDelete: true)
                .Index(t => t.user_id)
                .Index(t => t.bua_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "user_id", "dbo.Users");
            DropForeignKey("dbo.Reviews", "bua_id", "dbo.Buas");
            DropForeignKey("dbo.Payments", "user_id", "dbo.Users");
            DropForeignKey("dbo.Bookings", "user_id", "dbo.Users");
            DropForeignKey("dbo.Payments", "bua_id", "dbo.Buas");
            DropForeignKey("dbo.Bookings", "bua_id", "dbo.Buas");
            DropIndex("dbo.Reviews", new[] { "bua_id" });
            DropIndex("dbo.Reviews", new[] { "user_id" });
            DropIndex("dbo.Payments", new[] { "bua_id" });
            DropIndex("dbo.Payments", new[] { "user_id" });
            DropIndex("dbo.Bookings", new[] { "bua_id" });
            DropIndex("dbo.Bookings", new[] { "user_id" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Users");
            DropTable("dbo.Payments");
            DropTable("dbo.Buas");
            DropTable("dbo.Bookings");
        }
    }
}
