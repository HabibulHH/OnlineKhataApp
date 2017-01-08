using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineKhataApp.Models
{
    public class DailyCashFlow
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Display(Name = "Dokan Khoroch")]
        public float DailyShopCost { get; set; }
        [Display(Name = "Bari Khoroch")]
        public float BariKhoroch { get; set; }

        [Display(Name = "Transport/Labour")]
        public float TransportLabourCost { get; set; }

        [Display(Name = "Mokam payment")]
        public float CompanyPayment  { get; set; }

        [Display(Name = "Public/Bank Porishodh")]
        public float PublicLoanBankPayment { get; set; }
       
        [Display(Name = "Public loan")]
        public float PublicCashIn { get; set; }

        [Display(Name = "Nogod/Collection")]
        public float DailySells { get; set; }
    
    }
}