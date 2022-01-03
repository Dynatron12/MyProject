using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Repository.Models;
using Repository.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repository
{
    class HomeRepository
    {

        private readonly ProjectDBContext _context;

        public Account CurrentAccount { get; set; }


        public HomeRepository()
        {
            _context = new ProjectDBContext();
        }

        public List<Currency> Home()
        {
            return _context.Currencies.ToList();
        }
    }
}