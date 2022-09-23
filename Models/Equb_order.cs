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
        public int reserve_id { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }
        public int equb_id { get; set; }
        public Equb_detail Equb_Detail { get; set; }
        public int order { get; set; }

    }
}
