using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Technines_irangos_rezervacij.Models;

namespace Technines_irangos_rezervacij.Controllers
{
    public class NotificationsController : Controller
    {
        private ApplicationDbContext _context;

        public NotificationsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var notifications = _context.Notifications.Where(x => x.IsArchived == false).OrderByDescending(x => x.Id).ToList();
            return View(notifications);
        }

        public ActionResult Archived()
        {
            var notifications = _context.Notifications.Where(x => x.IsArchived).OrderByDescending(x => x.Id).ToList();
            return View(notifications);
        }
    }
}