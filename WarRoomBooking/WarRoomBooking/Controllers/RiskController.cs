using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarRoomBooking.Controllers
{
    public class RiskController : Controller
    {
        // GET: Risk
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Creation()
        {
            return View();
        }
    }
}