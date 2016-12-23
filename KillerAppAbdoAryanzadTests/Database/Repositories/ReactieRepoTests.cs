using Microsoft.VisualStudio.TestTools.UnitTesting;
using KillerAppAbdoAryanzad.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KillerAppAbdoAryanzad.Models;
using KillerAppAbdoAryanzad.Database.Memory;

namespace KillerAppAbdoAryanzad.Database.Repositories.Tests
{
    [TestClass()]
    public class ReactieRepoTests
    {
 
        [TestMethod()]
        public void GetAllTest()
        {
            List<Reactie> Reactieen = new List<Reactie>();
            ReactieRepo Reactie = new ReactieRepo(new ReactieContext());
            List<Reactie> Reacties = Reactie.GetAll();
            Assert.ReferenceEquals(Reacties, Reactieen);
        }

        [TestMethod()]
        public void AddTest()
        {
            ReactieRepo Reactie = new ReactieRepo(new ReactieContext());
            Reactie a = new Reactie(0, 0, 0, 0, 0, "Hallo");
            Reactie.Add(a);
            List<Reactie> Reacties = Reactie.GetAll();
            Assert.AreNotEqual(Reacties.Count == 0, Reacties.Count == 1);
        }
    }
}