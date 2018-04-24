using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Technines_irangos_rezervacij.Models;

namespace Technines_irangos_rezervacij.Controllers
{
    public class EquipmentController : Controller
    {
        private ApplicationDbContext _context;

        public EquipmentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

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

        public ActionResult Types()
        {
            var types = _context.EquipmentTypes.ToList();
            return View(types);
        }

        [Route("Equipment/Type/Details/{id}")]
        public ActionResult TypeDetails(int id)
        {
            var type = _context.EquipmentTypes.FirstOrDefault(x => x.Id == id);

            if (type == null)
            {
                return HttpNotFound();
            }

            return View(type);
        }
    }
}