namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PickupDays : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickupDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PickupDays");
        }
    }
}
