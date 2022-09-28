using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace equb.Models
{
    public class Reserves
    {
        [Key]
        [Display(Name = "Reservation ID")]
        public int reserve_id { get; set; }

        [Display(Name = "User ID")]
        [ForeignKey("Customer")]
        public int? cust_id { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Equb ID")]
        [ForeignKey("Equb_detail")]
        public int? equb_id { get; set; }
        public Equb_detail Equb_detail { get; set; }

        [Display(Name = "Order Number")]
        public int order { get; set; }

    }
    
}
