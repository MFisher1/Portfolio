using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.PortfolioContact());
        }
        [HttpPost]
        public ActionResult Index(Models.PortfolioContact portfolioContact)
        {
            //create a connection to the database
                Models.PortfolioEntities db = new Models.PortfolioEntities();
            //add our contact form to the db
                db.PortfolioContacts.Add(portfolioContact);
            //save changes
                db.SaveChanges();
            //kick the user to the thank you page
                return RedirectToAction("ThankYou", "Contact");
        }
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
