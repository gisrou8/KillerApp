﻿using KillerAppAbdoAryanzad.Database;
using KillerAppAbdoAryanzad.Database.Repositories;
using KillerAppAbdoAryanzad.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppAbdoAryanzad.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult SoftDrugs()
        {
            TypeDrugsRepo TypeDrugsrepo = new TypeDrugsRepo(new MSSQLTypeDrugsContext());
            SpecificatieRepo specificatie = new SpecificatieRepo(new MSSQLSpecificatieContext());
            SpecifactieSoftdrugsRepo ST = new SpecifactieSoftdrugsRepo(new MSSQLSpecificatieSoftdrugsSoftdrugsContext());
            TypeDrugsSpecificatieViewModel model = new TypeDrugsSpecificatieViewModel(TypeDrugsrepo.GetAll(), specificatie.GetAll(), ST.GetAll());

            return View(model);
        }

        public ActionResult Bijproduct()
        {
            ViewBag.Message = "Your contact page.";
            BijproductRepo bijproduct = new BijproductRepo(new MSSQLBijproductContext());
            BijproductViewModel model = new BijproductViewModel(bijproduct.GetAll());

            return View(model);
        }


        public ActionResult Product(int id)
        {
            TypeDrugsRepo typeDrugsrepo = new TypeDrugsRepo(new MSSQLTypeDrugsContext());
            BijproductRepo bijproductrepo = new BijproductRepo(new MSSQLBijproductContext());
            ProductModelView model = new ProductModelView(id, typeDrugsrepo.GetAll(), bijproductrepo.GetAll());

            return View(model);
            
        }
    }
}