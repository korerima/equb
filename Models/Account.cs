﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace equb.Models
{
    public class Account
    {
        public decimal balance { get; set; }
        public int cust_id { get; set; }
        public Customer Customer { get; set; }

    }
}