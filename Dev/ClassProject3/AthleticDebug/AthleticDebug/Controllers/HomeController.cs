﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AthleticDebug.DAL;

namespace AthleticDebug.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private ClassProjectContext db = new ClassProjectContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Athletes()
        {
            ViewBag.Message = "These are the athletes that we have at this moment";
            return View(db.Athletes.OrderBy(a => a.FName).ToList());
        }
    }
}