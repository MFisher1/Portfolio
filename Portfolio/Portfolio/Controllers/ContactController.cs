using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Mail;

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
        //[HttpPost]
        //public ActionResult Index(Models.PortfolioContact portfolioContact)
        //{
        //create a connection to the database
        //Models.PortfolioEntities db = new Models.PortfolioEntities();
        //add our contact form to the db
        //db.PortfolioContacts.Add(portfolioContact);
        //save changes
        //db.SaveChanges();
        //kick the user to the thank you page
        //return RedirectToAction("ThankYou", "Contact");
        //new contact form post to send me an email
        //email with the info
        [HttpPost]
        public ActionResult Index(Models.PortfolioContact contact)
        {
            //sending an email
            //step 1. adding using System.net.Mail;
            //step 2. create a new message
            MailMessage message = new MailMessage("theRobots@seedpaths.com", "anthony.mjones@gmail.com");
            //step 3. set the subject
            message.Subject = "Contact Request from " + contact.FirstName;
            //step 4. construct the body
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("You have a new contact request.");
            sb.AppendLine("Name: " + contact.FirstName);
            sb.AppendLine("Email: " + contact.Email);
            sb.AppendLine("Message: " + contact.Comment);
            sb.AppendLine("I love you,");
            sb.AppendLine("The Robots");
            //step 5. add the body to the message
            message.Body = sb.ToString();
            //step 6. Declare the SMTP client aka the mail server
            SmtpClient smtpClient = new SmtpClient("mail.dustinkraft.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("postmaster@dustinkraft.com", "techIsFun1");
            //step 7. send the message
            smtpClient.Send(message);
            //done
            //kick the user to the thank you page
            return RedirectToAction("ThankYou", "Contact"); 
        }



        public ActionResult ThankYou()
        {
            return View();
        }
    }
}