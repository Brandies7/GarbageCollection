namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickupDay : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.PickupDay",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                        CustomerId = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            
            
        }
    }
}
