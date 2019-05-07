using MyFirstWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Save(TestingWebApi model)
        {
            if (!ModelState.IsValid)
            {

                return Json("Error");
            }

            return Json("Success");
        }

    }
}
