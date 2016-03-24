using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AGA.Data;

namespace AGASQLI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var cntx = new AGA.Data.AGADataBaseContainer();
            //Statut tmp = new Statut() { Label = "En attente de traitement" };

            //cntx.StatutSet.Add(tmp);
            //cntx.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
