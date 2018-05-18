namespace LibraryMgmtApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductCategoryModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CategoryId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CategoryId");
        }
    }
}
