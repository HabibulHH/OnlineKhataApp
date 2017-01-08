namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIdChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerPayments", "CustomerId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerPayments", "CustomerId", c => c.String(nullable: false));
        }
    }
}
