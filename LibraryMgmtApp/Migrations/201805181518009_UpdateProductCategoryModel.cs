namespace LibraryMgmtApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategoryModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Byte(nullable: false));
        }
    }
}