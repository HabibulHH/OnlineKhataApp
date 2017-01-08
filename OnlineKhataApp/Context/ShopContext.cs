using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OnlineKhataApp.Context
{
    public class ShopContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ShopContext() : base("name=ShopContext")
        {
        }

        public System.Data.Entity.DbSet<OnlineKhataApp.Models.DailyCashFlow> DailyCashFlows { get; set; }

        public System.Data.Entity.DbSet<OnlineKhataApp.Models.DailySellsRecord> DailySellsRecords { get; set; }

        public System.Data.Entity.DbSet<OnlineKhataApp.Models.Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<OnlineKhataApp.Models.CustomersBuyingRecord> CustomersBuyingRecords { get; set; }

        public System.Data.Entity.DbSet<OnlineKhataApp.Models.CustomerPayment> CustomerPayments { get; set; }
    
    }
}
