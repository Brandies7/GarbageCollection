namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedforeignkey : DbMigration
    {
        public override void Up()
        {
            
            DropIndex("dbo.Customers", new[] { "pickupDay_Id" });
            DropColumn("dbo.Customers", "PickupDayId");
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "pickupDay_Id", c => c.Int());
            AddColumn("dbo.Customers", "PickupDayId", c => c.String(nullable: false));
            
            AddForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays", "Id");
        }
    }
}
