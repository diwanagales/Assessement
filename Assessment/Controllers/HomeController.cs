using Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

namespace Assessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUs(ContactUs record)
        {
            using (MailMessage mail = new MailMessage("contact.ccap2021@gmail.com", record.Email))
            {
                mail.Subject = record.Subject;

                string message = "Hello, " + record.SenderName + "!<br/><br/>" +
                    "Our team has received your inquiry. Here are the details: <br/><br/>" +
                    "Contact Number: <strong>" + record.ContactNo + "</strong><br/>" + "<br/>" +
                    "Message:<br/><strong>" + record.Message + "</strong><br/><br/>" +
                    "Please wait for our reply. Thank you!";
                mail.Body = message;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential("contact.ccap2021@gmail.com", "gboyabiwanikissleged24");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mail);
                    ViewBag.Message = "Inquiry sent.";
                }
            }
            return View();
        }
        
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult AssessmentReg()
        {
            return View();
        }
    }
}
