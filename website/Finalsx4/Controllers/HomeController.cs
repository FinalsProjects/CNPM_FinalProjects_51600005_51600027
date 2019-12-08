using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Finalsx4.Models;

namespace Finalsx4.Controllers
{
    public class HomeController : Controller
    {
        private Finalsx4Entities db = new Finalsx4Entities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Item()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Login()
        {
            return View();
        }


    }
}