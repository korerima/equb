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
        public int cust_id { get; set; }
        public string f_name { get; set; }
        public string l_name { get; set; }
        public int contact { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
