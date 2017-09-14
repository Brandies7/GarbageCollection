namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedcustomermodel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays");
            DropIndex("dbo.Customers", new[] { "pickupDay_Id" });
            AddColumn("dbo.Customers", "PickupDay", c => c.String());
            
            DropColumn("dbo.Customers", "pickupDay_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "pickupDay_Id", c => c.Int());
            AddColumn("dbo.Customers", "PickupDayId", c => c.String());
          
            CreateIndex("dbo.Customers", "pickupDay_Id");
            AddForeignKey("dbo.Customers", "pickupDay_Id", "dbo.PickupDays", "Id");
        }
    }
}
