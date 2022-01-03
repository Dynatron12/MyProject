using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class DateSwitchController : Controller
    {
        private readonly ProjectDBContext _context;

        public DateSwitchController(ProjectDBContext context)
        {
            _context = context;
        }
        // GET: DateSwitch
        public ActionResult Index()
        {
            return View();
        }

        // GET: DateSwitch/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DateSwitch/Create
        [HttpPost]
        public ActionResult DateSwitchControl()
        {
            try
            {
                var date = _context.DateNow.First();
                date.Date = date.Date.AddDays(1);
                _context.DateNow.Update(date);
                _context.SaveChanges();
                return Redirect("/Home");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // POST: DateSwitch/Create
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

        // GET: DateSwitch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DateSwitch/Edit/5
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

        // GET: DateSwitch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DateSwitch/Delete/5
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
