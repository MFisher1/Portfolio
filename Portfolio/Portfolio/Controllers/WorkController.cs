using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class WorkController : Controller
    {
        //
        // GET: /Work/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Battleship()
        {
            return View();
        }
        public ActionResult TheWakingDead()
        {
            return View();
        }
        public ActionResult HangMan()
        {
            return View();
        }
        public ActionResult GuessThatNumber()
        {
            return View();
        }

    }
}
