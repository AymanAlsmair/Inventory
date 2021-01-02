namespace InventoryTaskDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AttributeValues", "Att_Nae", c => c.String());
            DropColumn("dbo.AttributeValues", "Color");
            DropColumn("dbo.AttributeValues", "Size");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AttributeValues", "Size", c => c.String());
            AddColumn("dbo.AttributeValues", "Color", c => c.String());
            DropColumn("dbo.AttributeValues", "Att_Nae");
        }
    }
}
