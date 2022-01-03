using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class BankCurrencySB 
    {
        [Key]
        public int BankCurrencySBId { get; set; }
        public int BankId { get; set; }
        public int CurrencyId { get; set; }
        public double PriceForSelling { get; set; }
        public double PriceForBuying { get; set; }
        public double MaxForBuying { get; set; }
        public double MaxForSelling { get; set; }
        public short isPrimary { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
