using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Repository.Models.Account;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class RegistrationController : Controller
    {

        private readonly ProjectDBContext _context;
        private readonly AccountRepository _RegistrationRepository;

        public RegistrationController(ProjectDBContext context)
        {
            _context = context;
            _RegistrationRepository = new AccountRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: RegistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RegistrationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind]RegistrationDataViewModel model)
        {
            try
            {
                //   var isSigned = _context.Registration
                //         .Any(x => x.AccountName == model.UserName
                //        && x.AccountPassword == model.Password
                //        && x.Email == model.Email);
                // AccountTableAdapters.AccountTableAdapter AccountTableAdapter =
                //new AccountTableAdapters.AccountTableAdapter();
                // AccountTableAdapter.Insert(x.UserName, x.AccountPassword, x.Email);
                if (ModelState.IsValid)
                {
                    _RegistrationRepository.Registration(model);
                    return RedirectToAction(nameof(Index), "Login");
                }

                return View(nameof(Index));

            }
            catch (Exception ex)
            {
                return View(nameof(Index));
            }
        }

        // GET: RegistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RegistrationController/Edit/5
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

        // GET: RegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RegistrationController/Delete/5
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
