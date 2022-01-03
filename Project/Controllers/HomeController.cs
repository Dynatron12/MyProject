using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Repository.Models;
using Repository.Models.Account;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly CurrenciesRepository _CurrenciesRepository;

        public Account CurrentAccount { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _CurrenciesRepository = new CurrenciesRepository();
        }

        public IActionResult Index(Account account)
        {
            CurrentAccount = account;
            var allCurrencies = _CurrenciesRepository.GetCurrencies();
            HttpContext.Session.SetString("SelectedCurrency", allCurrencies.First().CurrencyId.ToString());
            HttpContext.Session.SetString("accountId", $"account.AccountId");
            ViewBag.Currencies = new SelectList(allCurrencies, "CurrencyId", "CurrencyName");
            ViewBag.CurrentAccount = account;
            return View();
        }


        [HttpPost]
        public IActionResult RedirectToBank(int account)
        {

            return RedirectToAction(nameof(Index), "Bank", CurrentAccount);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult SaveToSession(string selectedCurrency)
        {
            HttpContext.Session.SetString("SelectedCurrency", selectedCurrency);
            return Ok();
        }
    }
}
