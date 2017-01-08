using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineKhataApp.Models
{
    public class CustomersBuyingRecord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public string CustomerId  { get; set; }
        [Required]
        public float Amount { get; set; }
    }
}