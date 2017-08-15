using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CityWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CityName = ConfigurationManager.AppSettings["CityName"];
            ViewBag.Region = ConfigurationManager.AppSettings["Region"];
            ViewBag.ConfiguredFqdn = ConfigurationManager.AppSettings["FQDN"];
            ViewBag.ActualFqdn = HttpContext.Request.Url.Host;

            return View();
        }
        
    }
}