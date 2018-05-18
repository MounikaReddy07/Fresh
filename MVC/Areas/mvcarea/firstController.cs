using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Areas.mvcarea
{
    public class firstController : Controller
    {
        // GET: mvcarea/first
        public ActionResult Index()
        {
            Console.ReadLine();
            return View();
        }
    }
}