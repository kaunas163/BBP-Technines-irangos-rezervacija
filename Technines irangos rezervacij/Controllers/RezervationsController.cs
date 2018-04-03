using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Technines_irangos_rezervacij.Controllers
{
    public class RezervationsController : Controller
    {
        // GET: Rezervations
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Pending()
        {
            return View();
        }

        public ActionResult Active()
        {
            return View();
        }

        public ActionResult Archived()
        {
            return View();
        }
    }
}