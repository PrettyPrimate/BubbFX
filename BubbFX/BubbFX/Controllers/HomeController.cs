﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BubbFX.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Comments()
        {
            ViewBag.Message = "Your comments page.";

            return View();
        }

        public ActionResult Weddings()
        {
            ViewBag.Message = "Your weddings page.";

            return View();
        }
    }
}