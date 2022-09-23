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
        public int trans_id { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal amount { get; set; }
        public string trans_type { get; set; }
        public string trans_to { get; set; }
        public DateTime time { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }
    }
}
