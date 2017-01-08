namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBuyingRecEnabled : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomersBuyingRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.Single(nullable: false),
                        Amount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomersBuyingRecords");
        }
    }
}
