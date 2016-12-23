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
    public class SpecificatieRepoTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
            List<Specificatie> Specificatieen = new List<Specificatie>();
            SpecificatieRepo Specificatie = new SpecificatieRepo(new SpecificatieContext());
            List<Specificatie> Specificaties = Specificatie.GetAll();
            Assert.ReferenceEquals(Specificaties, Specificatieen);
        }
    }
}