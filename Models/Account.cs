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
        public int account_id { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal balance { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }
        public int sth_test { get; set;}

    }
}
