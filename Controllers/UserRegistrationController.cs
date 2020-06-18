using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using UserRegistration.Models;
using UserRegistration.Repository;
using Microsoft.Extensions.Logging;

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
            LoadList();
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
        public ActionResult Post(UserRegistrationModel user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    this._userRepository.InsertUser(user);
                    return RedirectToAction("Login");
                }
            }
            catch
            {                
            }
            return RedirectToAction("Index");
        }


        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Submit(UserLoginModel login)
        {
            try
            {
                UserRegistrationModel _user = this._userRepository.LoginVerification(login);
                LoadList();
                return View("Index",_user); 
            }
            catch
            {
                return View("Login");
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

        private void LoadList()
        {
            List<SelectListItem> _locationList = new List<SelectListItem>();
            _locationList.Insert(0, new SelectListItem("Bangalore", "Ban"));
            _locationList.Insert(1, new SelectListItem("Hyderabad", "Hyd"));
            _locationList.Insert(2, new SelectListItem("Kochi", "Koc"));
            ViewBag.ListOfLocation = _locationList;

            List<SelectListItem> _genderList = new List<SelectListItem>();
            _genderList.Insert(0, new SelectListItem("Male", "M"));
            _genderList.Insert(1, new SelectListItem("Female", "F"));
            ViewBag.ListOfGender = _genderList;
        }
    }
}
