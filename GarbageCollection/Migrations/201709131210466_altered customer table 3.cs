namespace GarbageCollection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alteredcustomertable3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Employees_Id", "dbo.Employees");
            DropIndex("dbo.Customers", new[] { "Employees_Id" });
            DropColumn("dbo.Customers", "Employees_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Employees_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "Employees_Id");
            AddForeignKey("dbo.Customers", "Employees_Id", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
