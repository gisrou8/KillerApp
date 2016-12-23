using Microsoft.VisualStudio.TestTools.UnitTesting;
using KillerAppAbdoAryanzad.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerAppAbdoAryanzad.Database.Memory;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Repositories.Tests
{
    [TestClass()]
    public class GebruikerRepoTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
            List<Gebruiker> Gebruikeren = new List<Gebruiker>();
            GebruikerRepo Gebruiker = new GebruikerRepo(new GebruikerContext());
            List<Gebruiker> Gebruikers = Gebruiker.GetAll();
            Assert.ReferenceEquals(Gebruikers, Gebruikeren);
        }

        [TestMethod()]
        public void AddTest()
        {
            GebruikerRepo Gebruiker = new GebruikerRepo(new GebruikerContext());
            Gebruiker a = new Gebruiker(0, 0, "Gebruiker", "Jan", "Gevorderd", "Best");
            Gebruiker.Add(a);
            List<Gebruiker> Gebruikers = Gebruiker.GetAll();
            Assert.AreNotEqual(Gebruikers.Count == 0, Gebruikers.Count == 1);
        }
    }
}