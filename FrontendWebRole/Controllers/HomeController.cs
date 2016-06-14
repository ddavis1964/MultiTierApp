using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FrontendWebRole.Models;
using Microsoft.ServiceBus.Messaging;
using Microsoft.ServiceBus;

namespace FrontendWebRole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Submit");
        }

        public ActionResult About()
        {
            // ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Submit()
        {
            //Will put code for displaying queue message count here.
            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }

        //POST: /Home/Submit.
        // Controler method for a view you will create for the submission form
        [HttpPost]
        // Attribute to help prevent cross-site scripting attacks and
        // cross-site request forgery.
        [ValidateAntiForgeryToken]
        public ActionResult Submit(OnlineOrders order)
        {
            if (ModelState.IsValid)
            {
                // Will put code for submitting to queue here.
                return RedirectToAction("Submit");
            }

            else
            {
                return View(order);
            }
        }
    }
}