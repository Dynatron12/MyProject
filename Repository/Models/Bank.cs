﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public string BankName { get; set; }
    }
    
}
