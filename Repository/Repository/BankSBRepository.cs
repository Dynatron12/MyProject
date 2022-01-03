using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class BankSBRepository
    {

        public BankSBRepository()
        {
            _context = new ProjectDBContext();
        }

        private readonly ProjectDBContext _context;

        public IQueryable<BankCurrencySB> GetAvailableBanksSB(int selectedCurrency)
        {
            return _context.BankCurrencySB.Where(x => x.CurrencyId == selectedCurrency && x.UpdateDate >= DateTime.Now.AddDays(-5)).Select(x => x);
        }
    }
}
