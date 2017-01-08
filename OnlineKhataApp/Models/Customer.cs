using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineKhataApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required]
        public  string  CustomernName { get; set; }

        [Display(Name = "Give a id")]
        public string CustomerId { get; set; }
        public float AccountRecivable { get; set; }
        [Display(Name = "Mobile Number")]
        [Required]
        public string MobileNumber { get; set; }

        public string Region { get; set; }
    }
}