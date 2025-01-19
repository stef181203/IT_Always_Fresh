namespace IT_PROJECT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedCartItemModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CartItems", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CartItems", "Price");
        }
    }
}
