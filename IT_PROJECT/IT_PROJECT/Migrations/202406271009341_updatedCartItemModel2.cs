namespace IT_PROJECT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedCartItemModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartItems", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.CartItems", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.CartItems", "TotalPrice");
        }
    }
}
