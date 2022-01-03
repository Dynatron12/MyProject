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
    public class LoginController : Controller
    {
        private readonly ProjectDBContext _context;
        private readonly AccountRepository _LoginRepository;

        public LoginController(ProjectDBContext context)
        {
            _context = context;
            _LoginRepository = new AccountRepository();
        }

        // GET: AccountController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult Login()
        {
           return View();
        }

        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind]LoginDataViewModel model)
        {
            try
            {
                var signedAccount = _LoginRepository.SignedAccount(model);

                if (signedAccount != null && signedAccount != default) 
                {
                    return RedirectToAction(nameof(Index), "Home", signedAccount);
                }
                
                throw new Exception();
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Password", "Incorrect password");
                return View(nameof(Index));
            }
        }

        // GET: AccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AccountController/Edit/5
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

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
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
