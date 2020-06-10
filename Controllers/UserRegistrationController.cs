using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistration.Models;
using UserRegistration.Repository;

namespace UserRegistration.Controllers
{
    public class UserRegistrationController : Controller
    {

        private readonly IUserRepository _userRepository;

        public UserRegistrationController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        } 

        // GET: UserRegistrationController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        // GET: UserRegistrationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        
        // POST: UserRegistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserRegistrationModel user)
        {
            try
            {
                this._userRepository.InsertUser(user);
                return RedirectToAction("Login");
            }
            catch
            {
                return View("Index");
            }
        }

        // GET: UserRegistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRegistrationController/Edit/5
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

        // GET: UserRegistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRegistrationController/Delete/5
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
