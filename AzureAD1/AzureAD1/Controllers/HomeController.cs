using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureAD1.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> keys = new List<string>();
            String[] Name = new String[1];
            String[] id = new String[1];
            String[] token = new String[1];
            foreach (var obj in Request.Headers.Keys)
            {
                keys.Add(obj.ToString());
                Name=Request.Headers.GetValues("X-MS-CLIENT-PRINCIPAL-NAME");
                id = Request.Headers.GetValues("X-MS-CLIENT-PRINCIPAL-ID");
                token = Request.Headers.GetValues("X-MS-TOKEN-AAD-ACCESS-TOKEN");
            }
            ViewBag.Keys = keys;
            ViewBag.Name = Name;
            ViewBag.id = id;
            ViewBag.token = token;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}