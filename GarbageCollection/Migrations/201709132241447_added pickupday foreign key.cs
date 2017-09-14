namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedpickupdayforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "pickupDay_Id", c => c.Int());
            CreateIndex("dbo.Customers", "pickupDay_Id");
            AddForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays");
            DropIndex("dbo.Customers", new[] { "pickupDay_Id" });
            DropColumn("dbo.Customers", "pickupDay_Id");
        }
    }
}
