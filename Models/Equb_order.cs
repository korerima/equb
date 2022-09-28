using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equb.Models
{
    public class Equb_order
    {
        [Key]
        [Display(Name = "Equb order ID")]
        public int equb_order_id { get; set; }

        [Display(Name = "User ID")]
        [ForeignKey("Customer")]
        public int? cust_id { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Equb ID")]
        [ForeignKey("Equb_detail")]
        public int? equb_id { get; set; }
        public Equb_detail Equb_detail { get; set; }

        [Display(Name = "Order Number")]
        [Range(0.00, 50.00, ErrorMessage = "The order placement should't be greater than 50 and less than 0")]
        [Required(ErrorMessage = "Winning order is required")]
        public int order { get; set; }

        [Display(Name = "Order Status")]
        [Required(ErrorMessage = "Order status is required")]
        public string status { get; set; }

        [Required(ErrorMessage = "Win date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Win Date")]
        public DateTime win_date { get; set; }
    }
}
