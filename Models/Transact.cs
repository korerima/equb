using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equb.Models
{
    public class Transact
    {
        [Key]
        [Display(Name ="Transaction ID")]
        public int trans_id { get; set; }

        [Required(ErrorMessage = "Please enter the amount")]
        [DataType(DataType.Currency)]
        [Range(100.00,100000.00,ErrorMessage ="The minimum amount is 100 ETB and maximum amount is 100,000 ETB")]
        public float? amount { get; set; }

        [Required(ErrorMessage = "Please enter the transaction type")]
        [Display(Name ="Transaction Type")]
        public string trans_type { get; set; }

        [Required(ErrorMessage = "Please enter where to transfer")]
        [Display(Name = "Transaction to")]
        public string trans_to { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Transaction Date")]
        public DateTime time { get; set; }

        [Display(Name ="User ID")]
        public int cust_id { get; set; }
        public Customer Customer { get; set; }
    }
}
