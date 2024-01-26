using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesTracker.Areas.Sales.Controllers
{
    public class SalesTrackerController : Controller
    {
        // GET: Sales/SalesTracker
        public ActionResult Index()
        {
            return View();
        }

        // Billing
        public ActionResult Billing()
        {
            return View();
        }

        // Report
        public ActionResult Report()
        {
            return View();
        }
    }
}