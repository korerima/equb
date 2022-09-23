using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace equb.Models
{
    public class Reserves
    {
        [Key]
        public int equb_order_id { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }
        public int equb_id { get; set; }
        public Equb_detail Equb_Detail { get; set; }
        public int order { get; set; }
        public string status { get; set; }
        public DateTime win_date { get; set; }
    }
}
