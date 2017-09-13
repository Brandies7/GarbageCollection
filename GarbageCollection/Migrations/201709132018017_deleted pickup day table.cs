namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedpickupdaytable : DbMigration
    {
        public override void Up()
        {
        
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PickupDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Day = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
