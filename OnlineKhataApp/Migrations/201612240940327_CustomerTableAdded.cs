namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomernName = c.String(nullable: false),
                        CustomerId = c.String(),
                        AccountRecivable = c.Single(nullable: false),
                        MobileNumber = c.String(nullable: false),
                        Region = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
