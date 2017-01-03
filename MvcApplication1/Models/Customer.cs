using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Customer
    {
        public long ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [Display(Name = "Customer Name")]
        public string Customer_Name { get; set; }
        [Required]
        [Range(18, 100)]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter the Email address in the correct format")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string Confirm_Password { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"[0-9]{3}\-[0-9]{3}\-[0-9]{4}", ErrorMessage = "Please enter a valid Phone Number in the format, XXX-XXX-XXXX")]
        [Display(Name = "Phone Number")]
        public string Phone_Number { get; set; }
        public bool Subscription { get; set; }
    }
}
