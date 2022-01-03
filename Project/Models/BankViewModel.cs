using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BankViewModel
    {
        public IEnumerable<Bank> Banks { get; set; }
        public IEnumerable<BankCurrencySB> BankCurrencySBs { get; set; } 
    }
}
