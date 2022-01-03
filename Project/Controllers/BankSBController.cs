using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers 
{
    public class BankSBController : Controller
    {
        private readonly ProjectDBContext _context;
        private readonly BankSBRepository _BankSBRepository;

        public BankSBController(ProjectDBContext context)
        {
            _context = context;
            _BankSBRepository = new BankSBRepository();
        }

        // GET: BankSBController
        public ActionResult Index()
        {
            var selectedCurrency = int.Parse(HttpContext.Session.GetString("SelectedCurrency"));
            var availableBanks = _BankSBRepository.GetAvailableBanksSB(selectedCurrency);
                   
            return View(availableBanks);
        }

        // GET: BankSBController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BankSBController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankSBController/Create
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

        // GET: BankSBController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BankSBController/Edit/5
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

        // GET: BankSBController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BankSBController/Delete/5
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
