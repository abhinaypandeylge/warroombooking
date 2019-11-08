using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarRoomBooking.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LoadProjectDetails(DateTime? startDate, DateTime? endDate)
        {
            if (endDate != null)
            {

            }
            return Json(true);
        }
        public ActionResult Creation()
        {
            return View();
        }
    }
}