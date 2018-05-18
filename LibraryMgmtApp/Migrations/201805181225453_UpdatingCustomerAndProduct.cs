namespace LibraryMgmtApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatingCustomerAndProduct : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
