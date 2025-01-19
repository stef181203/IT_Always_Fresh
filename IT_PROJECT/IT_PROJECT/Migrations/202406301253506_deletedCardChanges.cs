namespace IT_PROJECT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletedCardChanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "CardIdentificator");
            DropTable("dbo.Cards");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameAndSurname = c.String(nullable: false),
                        CardNumber = c.String(nullable: false),
                        CVV2 = c.Int(nullable: false),
                        ValidityPeriod = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "CardIdentificator", c => c.Int(nullable: false));
        }
    }
}
