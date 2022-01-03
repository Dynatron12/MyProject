using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    public class CurrenciesRepository
    {
        private readonly ProjectDBContext _context;

        public CurrenciesRepository()
        {
            _context = new ProjectDBContext();
        }


        public List<Currency> GetCurrencies()
        {
            
            return _context.Currencies.ToList(); ;
        }

    }
}
