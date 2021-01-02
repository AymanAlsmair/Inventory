namespace InventoryTaskDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Orders", "Date_Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "Date_Time", c => c.DateTime(nullable: false));
        }
    }
}
