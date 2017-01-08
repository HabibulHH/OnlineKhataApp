using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineKhataApp.Models
{
    public class DailySellsRecord
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Date" )]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public float TotalSell { get; set; }
         [Required]
        [Display(Name = "Nogod Bikroy")]
        public float SellOnCash { get; set; }

         [Required]
         [Display(Name = "Baki Bikroy")]
         public float SellsOnDue { get; set; }
         [Required]
         [Display(Name = "Baki Aday")]
         public float Collection { get; set; }

        [Display(Name = "Daily Baki Briddhi")]
        public float AccountRecivable
        {
            get; set; //{ AccountRecivable = this.TotalSell - (this.Collection + this.SellOnCash); } 
        }
        

    }
}