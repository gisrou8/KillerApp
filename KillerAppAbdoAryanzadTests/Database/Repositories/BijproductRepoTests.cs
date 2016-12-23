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
    public class BijproductRepoTests
    {
   

        [TestMethod()]
        public void GetAllTest()
        {
            List<Bijproduct> bijproducten = new List<Bijproduct>();
            BijproductRepo Bijproduct = new BijproductRepo(new BijproductContext());
            List<Bijproduct> Bijproducts = Bijproduct.GetAll();
            Assert.ReferenceEquals(Bijproducts, bijproducten);
        }
    }
}