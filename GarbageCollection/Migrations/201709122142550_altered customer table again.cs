namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredcustomertableagain : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "PaymentOption", c => c.String());
            AddColumn("dbo.Customers", "ChangePickup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "ChangePickup");
            DropColumn("dbo.Customers", "PaymentOption");
        }
    }
}
