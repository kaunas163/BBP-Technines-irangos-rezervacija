using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Technines_irangos_rezervacij.Controllers
{
    public class EquipmentController : Controller
    {
        // GET: Equipment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Equipment()
        {
            return View();
        }

        public ActionResult Bundles()
        {
            return View();
        }

        public ActionResult ForRent()
        {
            return View();
        }
    }
}