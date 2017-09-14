namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredpickupday : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PickupDayId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PickupDayId", c => c.String(nullable: false));
        }
    }
}
