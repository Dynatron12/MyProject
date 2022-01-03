using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class BankViewModel
    {
        public IEnumerable<Bank> Banks { get; set; }
        public IEnumerable<BankCurrencySB> BankCurrencySBs { get; set; } 
    }
}
