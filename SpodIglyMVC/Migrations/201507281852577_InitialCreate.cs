namespace SpodIglyMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Albums",
                c => new
                {
                    AlbumID = c.Int(nullable: false, identity: true),
                    GenreID = c.Int(nullable: false),
                    AlbumTitle = c.String(),
                    ArtistName = c.String(),
                    DateAdded = c.DateTime(nullable: false),
                    CoverFileName = c.String(),
                    Description = c.String(),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IsBestseller = c.Boolean(nullable: false),
                    IsHidden = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.AlbumID)
                .ForeignKey("dbo.Genres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.GenreID);

            CreateTable(
                "dbo.Genres",
                c => new
                {
                    GenreID = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    IconFilename = c.String(),
                })
                .PrimaryKey(t => t.GenreID);

            CreateTable(
                "dbo.OrderItems",
                c => new
                {
                    OrderItemId = c.Int(nullable: false, identity: true),
                    OrderId = c.Int(nullable: false),
                    AlbumId = c.Int(nullable: false),
                    Quantity = c.Int(nullable: false),
                    UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Albums", t => t.AlbumId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.AlbumId);

            CreateTable(
                "dbo.Orders",
                c => new
                {
                    OrderId = c.Int(nullable: false, identity: true),
                    FirstName = c.String(maxLength: 100),
                    LastName = c.String(maxLength: 150),
                    Address = c.String(),
                    CodeAndCity = c.String(nullable: false, maxLength: 50),
                    PhoneNumber = c.String(),
                    Email = c.String(),
                    Comment = c.String(),
                    DateCreated = c.DateTime(nullable: false),
                    OrderState = c.Int(nullable: false),
                    TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.OrderId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "AlbumId", "dbo.Albums");
            DropForeignKey("dbo.Albums", "GenreID", "dbo.Genres");
            DropIndex("dbo.OrderItems", new[] { "AlbumId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Albums", new[] { "GenreID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Genres");
            DropTable("dbo.Albums");
        }
    }
}
