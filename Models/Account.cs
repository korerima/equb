using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equb.Models
{
    public class Account
    {
        [Key]
        [Display(Name ="Account Number")]
        public int account_id { get; set; }

        [Required(ErrorMessage = "Please enter the amount")]
        [DataType(DataType.Currency)]
        [Range(0.00, 1000000.00, ErrorMessage = "The maximum amount is 1,000,000 ETB")]
        public float? balance { get; set; }

        [Display(Name = "User ID")]
        [ForeignKey("Customer")]
        public int? cust_id { get; set; }
        public Customer Customer { get; set; }

    }
}
