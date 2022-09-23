using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace equb.Models
{
    public class Equb_detail
    {
        [Key]
        public int equb_id { get; set; }
        public string equb_name { get; set; }
        public string cycle { get; set; }
        public int duration { get; set; }
        public string status { get; set; }
        public string password { get; set; }
        public int number_of_users { get; set; }
        public decimal amount { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }


    }
}
