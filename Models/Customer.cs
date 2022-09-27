using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equb.Models
{
    public class Customer
    {
        [Key]
        [Display(Name = "User ID")]
        public int cust_id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First Name")]
        [StringLength(25, ErrorMessage ="Name shouldn't be longer than 25 letters ")]
        public string f_name { get; set; }

        [Required(ErrorMessage = "Father's name is required")]
        [Display(Name = "Father's Name")]
        [StringLength(25, ErrorMessage = "Name shouldn't be longer than 25 letters ")]
        public string l_name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone]
        [Display(Name = "Phone Number")]
        public int contact { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,15}$",ErrorMessage ="Username shouldn't be longer that 15 letters and characters are not allowed")]
        public string username { get; set; }
        
        [Required(ErrorMessage ="Password is required")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{7,25}$", ErrorMessage = "Password shouldn't be longer that 25 and shorter that 7 letters and characters are not allowed")]
        public string password { get; set; }
    }
}
