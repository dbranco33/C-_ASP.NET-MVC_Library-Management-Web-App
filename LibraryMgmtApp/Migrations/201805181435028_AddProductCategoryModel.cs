namespace LibraryMgmtApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductCategoryModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Category_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "Category_Id");
            AddForeignKey("dbo.Products", "Category_Id", "dbo.ProductCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "Category_Id", "dbo.ProductCategory");
            DropIndex("dbo.Products", new[] { "Category_Id" });
            DropColumn("dbo.Products", "Category_Id");
            DropTable("dbo.ProductCategories");
        }
    }
}
