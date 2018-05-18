namespace LibraryMgmtApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductModelWithNewColumns : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductGenres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Products", "NumberInStock", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Genre_Id", c => c.Int());
            CreateIndex("dbo.Products", "Genre_Id");
            AddForeignKey("dbo.Products", "Genre_Id", "dbo.ProductGenres", "Id");
            DropColumn("dbo.Products", "ReleaseYear");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ReleaseYear", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "Genre_Id", "dbo.ProductGenres");
            DropIndex("dbo.Products", new[] { "Genre_Id" });
            DropColumn("dbo.Products", "Genre_Id");
            DropColumn("dbo.Products", "NumberInStock");
            DropColumn("dbo.Products", "DateAdded");
            DropColumn("dbo.Products", "ReleaseDate");
            DropTable("dbo.ProductGenres");
        }
    }
}
