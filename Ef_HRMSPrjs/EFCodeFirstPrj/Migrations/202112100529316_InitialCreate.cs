namespace EFCodeFirstPrj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_order",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.tbl_product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                        OrderId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tbl_order", t => t.OrderId_Id)
                .Index(t => t.OrderId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tbl_product", "OrderId_Id", "dbo.tbl_order");
            DropIndex("dbo.tbl_product", new[] { "OrderId_Id" });
            DropTable("dbo.tbl_product");
            DropTable("dbo.tbl_order");
        }
    }
}
