namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerBuyingrecDateTimeUpdate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomersBuyingRecords", "CustomerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomersBuyingRecords", "CustomerId", c => c.Single(nullable: false));
        }
    }
}
