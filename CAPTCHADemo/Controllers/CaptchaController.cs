using CAPTCHADemo.Models;
using CaptchaMvc.HtmlHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CAPTCHADemo.Controllers
{
    public class CaptchaController : Controller
    {
        public ActionResult Index()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult Index(Comments comments)
        { 
            if (this.IsCaptchaValid("Captcha is invalid")) //Here the validation will happen
            {

                return RedirectToAction("AfterVerifying"); //redirect to this controller after verification
            }

            ViewBag.Error = "Invalid Captcha";
            return View();
        }

        public ActionResult AfterVerifying()
        {
            return View();
        }
    }
}