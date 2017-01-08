namespace OnlineKhataApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class versisonOne : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DailyCashFlows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DailyShopCost = c.Single(nullable: false),
                        BariKhoroch = c.Single(nullable: false),
                        TransportLabourCost = c.Single(nullable: false),
                        CompanyPayment = c.Single(nullable: false),
                        PublicLoanBankPayment = c.Single(nullable: false),
                        PublicCashIn = c.Single(nullable: false),
                        DailySells = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailySellsRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalSell = c.Single(nullable: false),
                        SellOnCash = c.Single(nullable: false),
                        SellsOnDue = c.Single(nullable: false),
                        Collection = c.Single(nullable: false),
                        AccountRecivable = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DailySellsRecords");
            DropTable("dbo.DailyCashFlows");
        }
    }
}
