namespace Bua_Lagbe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buaacceptreject : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "is_accepted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bookings", "is_accepted");
        }
    }
}
