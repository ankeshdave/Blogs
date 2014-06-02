using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootswatchDemo.Models;

namespace BootswatchDemo.Controllers
{
    public class TemplateDemoController : Controller
    {
        // GET: TemplateDemo
        public ActionResult Index()
        {
            return View(new Person() {Name = "Some Name"});
        }
    }
}