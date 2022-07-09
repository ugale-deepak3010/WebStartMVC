using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStartMVC.Models;

namespace WebStartMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]  // access only via Post method not get
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Dashboard", "Home");
            }
            return View();
        }
    }
}