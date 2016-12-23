using KillerAppAbdoAryanzad.Database;
using KillerAppAbdoAryanzad.Database.Repositories;
using KillerAppAbdoAryanzad.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppAbdoAryanzad.Controllers
{
    public class BestellingController : Controller
    {
        // GET: Bestelling
        public ActionResult Index()
        {
            BestellingToevoegenViewModel model = new BestellingToevoegenViewModel();
            return View(model);
        }



        [HttpPost]
        public ActionResult Index(string Product, double Prijs)
        {
           
            BestellingToevoegenViewModel model = new BestellingToevoegenViewModel();
            model.AddToTable(Product, Prijs);

            return View(model);
        }

        [HttpPost]
        public ActionResult VerwijderProduct()
        {

            BestellingToevoegenViewModel model = new BestellingToevoegenViewModel();


            return RedirectToAction("Index", "Bestelling");
        }
    }
}