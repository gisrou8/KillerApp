using KillerAppAbdoAryanzad.Database;
using KillerAppAbdoAryanzad.Database.Repositories;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillerAppAbdoAryanzad.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Registreren()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registreren(string Gebruikersnaam, string Wachtwoord, string Email, string Naam, string Status, string Woonplaats)
        {
            UserRepo userrepo = new UserRepo(new MSSQLUserContext());
            User u = new User(Gebruikersnaam, Wachtwoord, Email);
            userrepo.Add(u);
            

            List<User> users = userrepo.GetAll();
            GebruikerRepo gebruikerrepo = new GebruikerRepo(new MSSQLGebruikerContext());
            Gebruiker g = null;
            string AccountTypen = "Gebruiker";
            

            foreach (var i in users)
            {
                if(i.Gebruikersnaam == u.Gebruikersnaam)
                {
                    g = new Gebruiker(i.ID, AccountTypen, Naam, Status, Woonplaats);
                    gebruikerrepo.Add(g);
                    return View(g);
                }
            }
            return View(g);
        }


        [HttpPost]
        public ActionResult Login(string Gebruikersnaam, string Wachtwoord)
        {
            try
            {
                UserRepo urepo = new UserRepo(new MSSQLUserContext());
                GebruikerRepo gebruikerrepo = new GebruikerRepo(new MSSQLGebruikerContext());
                List<Gebruiker> gebruikers = gebruikerrepo.GetAll();
                Gebruiker g = null;
                User loggedInUser = urepo.Login(Gebruikersnaam, Wachtwoord);
                if (loggedInUser == null)
                {
                    ModelState.AddModelError("", "");
                    return View();
                }

                foreach (var i in gebruikers)
                {
                    if(i.Account_ID == loggedInUser.ID)
                    {
                        g = i;
                    }
                }
                Session["ID"] = g.ID;
                Session["Account_ID"] = g.Account_ID;
                Session["AccountType"] = g.AccountType;
                Session["Naam"] = g.Naam;
                Session["Status"] = g.Status;
                Session["Woonplaats"] = g.Woonplaats;

                if(g.AccountType == "Gebruiker")
                {
                   return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Registreren", "Login");
                }
                
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                Session.Clear();
                return View();
            }
        }
    }
}