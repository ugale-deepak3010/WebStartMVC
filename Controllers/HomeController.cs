using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebStartMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //https://localhost:44317/Home/Add?x=5&y=9
        public int Add(int x, int y)
        {
            return x + y;
        }

        // can't access https://localhost:44317/Home/Add2?x=5&y=9 because protected.
        protected int Add2(int x, int y)
        {
            return x + y;
        }


       // also can't access https://localhost:44317/Home/Add3?x=5&y=9
        [NonAction]
        protected int Add3(int x, int y)
        {
            return x + y;
        }
    }
}