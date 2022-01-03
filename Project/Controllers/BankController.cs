using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Models.Account;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class BankController : Controller
    {
        private readonly ProjectDBContext _context;
        private readonly BankRepository _bankRepository;//!!!!!!!!!!!
        private DateTime currentDate;

        public Account CurrentAccount { get; set; }

        public BankController(ProjectDBContext context)
        {
             _context = context;
            _bankRepository = new BankRepository();//!!!!!!!!!!!!!!
        }
        // GET: BankController
        //public ActionResult Index()
        //{
        //    var selectedCurrency = int.Parse(HttpContext.Session.GetString("SelectedCurrency"));
        //    var availableBanks = _context.Bank
        //        .Join(_context.BankCurrencySB.Where(x => x.CurrencyId == selectedCurrency), 
        //            x => x.BankId, 
        //            y => y.BankId, 
        //            (x, y) => x
        //            );
        //    return View(availableBanks);
        //}

        public ActionResult Index(Account account)
        {
            CurrentAccount = account;
            var selectedCurrency = int.Parse(HttpContext.Session.GetString("SelectedCurrency"));
            var DateTimeNow = _context.DateNow.Select(z => new DateNow
            {
                Date = z.Date
            });
            currentDate = DateTimeNow.FirstOrDefault().Date;
            var availableBanks = _bankRepository.GetAvailableBanks(selectedCurrency);
                

            //List<BankCurrencySB> list = new List<BankCurrencySB>();
            //foreach (var element in bankCurrencySBs)
            //{
            //    if (!list.Any(a => a.UpdateDate.Date == element.UpdateDate.Date))
            //        list.Add(element);
            //}
            //var returnModel = new BankViewModel
            //{
            //    Banks = availableBanks,
            //    BankCurrencySBs = list
            //};
            
            return View(availableBanks);
        }

        // GET: BankController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BankController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
