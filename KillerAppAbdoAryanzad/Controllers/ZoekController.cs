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
    public class ZoekController : Controller
    {
        // GET: Zoek
        public ActionResult Index()
        {
            return View();
        }




        [HttpPost]
        public ActionResult Zoek(string Tekst)
        {
            TypeDrugsRepo typedrugsrepo = new TypeDrugsRepo(new MSSQLTypeDrugsContext());
            BijproductRepo bijproductrepo = new BijproductRepo(new MSSQLBijproductContext());
            ZoekProductenModelView model = new ZoekProductenModelView(typedrugsrepo.GetAll(), bijproductrepo.GetAll(), Tekst);
            if(model.BijproductID != 0)
            {
                return RedirectToAction("BijproductProduct", "Home", new { id = model.BijproductID });
            }
            
            if(model.TypedrugID != 0)
            {
                return RedirectToAction("TypeDrugsProduct", "Home", new { id = model.TypedrugID});
            }
            return RedirectToAction("Index", "Zoek");
        }
    }
}