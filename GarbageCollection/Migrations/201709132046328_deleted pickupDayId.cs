namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedpickupDayId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays");
            DropIndex("dbo.Customers", new[] { "pickupDay_Id" });
            DropColumn("dbo.Customers", "pickupDay_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "pickupDay_Id", c => c.Int());
            CreateIndex("dbo.Customers", "pickupDay_Id");
            AddForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays", "Id");
        }
    }
}
