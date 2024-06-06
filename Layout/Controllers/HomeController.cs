using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        // GET: AboutUs

        [HttpGet]
        public ActionResult AboutUs()
        {
            return View();
        }

        // GET: Home

        [HttpGet]
        public ActionResult Staff()
        {
            return View();
        }

        // GET: Sports

        [HttpGet]
        public ActionResult Sports()
        {
            return View();
        }

        // GET: Galery

        [HttpGet]
        public ActionResult Gallery()
        {
            return View();
        }

        // GET: Download

        [HttpGet]
        public ActionResult Download()
        {
            return View();
        }

        // GET: ContactUs

        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }

        // SET: ContactUs

        [HttpPost]
        public ActionResult ContactUs(string name, string e_mail, string message)
        {
            return View();
        }


    }

    
}