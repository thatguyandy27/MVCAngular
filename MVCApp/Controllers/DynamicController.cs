using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace MVCApp.Controllers
{
    public class DynamicObject
    {
        public string Name { get; set; }
    }

    public class DynamicController : Controller
    {
        

        public ActionResult Index(string id)
        {
            return View(new DynamicObject { Name = "Dynamic Object Name " + id });
        }
    }
}
