namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerPaymentTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        CustomerId = c.String(nullable: false),
                        Amount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerPayments");
        }
    }
}
