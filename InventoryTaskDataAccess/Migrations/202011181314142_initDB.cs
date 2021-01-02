namespace InventoryTaskDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attributes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ATTRIBUTE_Name = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AttributeValues",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Color = c.String(),
                        Size = c.String(),
                        att_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Attributes", t => t.att_id, cascadeDelete: true)
                .Index(t => t.att_id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(),
                        Product_Name = c.String(),
                        SKU = c.String(),
                        Price = c.Double(nullable: false),
                        QTY = c.Int(nullable: false),
                        Description = c.String(),
                        color_id = c.Int(nullable: false),
                        Size_id = c.Int(nullable: false),
                        Brand_id = c.Int(nullable: false),
                        category_id = c.Int(nullable: false),
                        stor_id = c.Int(nullable: false),
                        Availability = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.Brand_id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.stor_id, cascadeDelete: true)
                .ForeignKey("dbo.AttributeValues", t => t.color_id, cascadeDelete: true)
                .ForeignKey("dbo.AttributeValues", t => t.Size_id, cascadeDelete: false)
                .Index(t => t.color_id)
                .Index(t => t.Size_id)
                .Index(t => t.Brand_id)
                .Index(t => t.category_id)
                .Index(t => t.stor_id);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Brand_Name = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Category_Name = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Store_Name = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(),
                        Charge_Amount = c.Double(nullable: false),
                        Vat_Charge = c.Double(nullable: false),
                        Address = c.String(),
                        Phone = c.String(),
                        Country_id = c.Int(nullable: false),
                        Message = c.String(),
                        Currency_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_id, cascadeDelete: true)
                .ForeignKey("dbo.Currencies", t => t.Currency_id, cascadeDelete: true)
                .Index(t => t.Country_id)
                .Index(t => t.Currency_id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Pill_NO = c.Int(nullable: false),
                        Customer_Name = c.String(),
                        Customer_Address = c.String(),
                        Customer_Phone = c.String(),
                        Product_id = c.Int(nullable: false),
                        qty = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Gross_Amount = c.Double(nullable: false),
                        Vat = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Net_Amount = c.Double(nullable: false),
                        Date_Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_id, cascadeDelete: true)
                .Index(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "Product_id", "dbo.Products");
            DropForeignKey("dbo.Companies", "Currency_id", "dbo.Currencies");
            DropForeignKey("dbo.Companies", "Country_id", "dbo.Countries");
            DropForeignKey("dbo.Products", "Size_id", "dbo.AttributeValues");
            DropForeignKey("dbo.Products", "color_id", "dbo.AttributeValues");
            DropForeignKey("dbo.Products", "stor_id", "dbo.Stores");
            DropForeignKey("dbo.Products", "category_id", "dbo.Categories");
            DropForeignKey("dbo.Products", "Brand_id", "dbo.Brands");
            DropForeignKey("dbo.AttributeValues", "att_id", "dbo.Attributes");
            DropIndex("dbo.Orders", new[] { "Product_id" });
            DropIndex("dbo.Companies", new[] { "Currency_id" });
            DropIndex("dbo.Companies", new[] { "Country_id" });
            DropIndex("dbo.Products", new[] { "stor_id" });
            DropIndex("dbo.Products", new[] { "category_id" });
            DropIndex("dbo.Products", new[] { "Brand_id" });
            DropIndex("dbo.Products", new[] { "Size_id" });
            DropIndex("dbo.Products", new[] { "color_id" });
            DropIndex("dbo.AttributeValues", new[] { "att_id" });
            DropTable("dbo.Orders");
            DropTable("dbo.Currencies");
            DropTable("dbo.Countries");
            DropTable("dbo.Companies");
            DropTable("dbo.Stores");
            DropTable("dbo.Categories");
            DropTable("dbo.Brands");
            DropTable("dbo.Products");
            DropTable("dbo.AttributeValues");
            DropTable("dbo.Attributes");
        }
    }
}
