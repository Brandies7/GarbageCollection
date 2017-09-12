namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredcustomertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "ExtraPickup", c => c.String());
            AddColumn("dbo.Customers", "NoPickup", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NoPickup");
            DropColumn("dbo.Customers", "ExtraPickup");
        }
    }
}
