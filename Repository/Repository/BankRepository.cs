using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class BankRepository
    {
        private readonly ProjectDBContext _context;

        public BankRepository()
        {
            _context = new ProjectDBContext();
        }

        public IEnumerable<KeyValuePair<string, IEnumerable<BankRowViewModel>>> GetAvailableBanks(int selectedCurrency)
        {
            return _context.Bank
                .Join(_context.BankCurrencySB.Where(x => x.CurrencyId == selectedCurrency),
                    x => x.BankId,
                    y => y.BankId,
                    (x, y) => new
                    {
                        x.BankName,
                        y.UpdateDate,
                        y.PriceForBuying
                    })
                .AsEnumerable()
                .GroupBy(x => x.BankName)
                .ToDictionary(x => x.Key, x => x
                    .Where(y => y.UpdateDate > DateTime.Now.AddDays(-7))
                    .Select(y => new BankRowViewModel
                    {
                        Date = y.UpdateDate.Date,
                        Price = y.PriceForBuying
                    }).OrderByDescending(e => e.Date).AsEnumerable()
                    )
                .OrderByDescending(a => a.Key);
        }

    }
}
