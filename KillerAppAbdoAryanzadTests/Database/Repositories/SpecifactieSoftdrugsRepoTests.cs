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
    public class SpecifactieSoftdrugsRepoTests
    {
   

        [TestMethod()]
        public void GetAllTest()
        {
            List<SpecificatieSoftdrugs> SpecificatieSoftdrugsen = new List<SpecificatieSoftdrugs>();
            
            SpecifactieSoftdrugsRepo SpecificatieSoftdrugs = new SpecifactieSoftdrugsRepo(new SpecificatieSoftdrugsContext());
            List<SpecificatieSoftdrugs> SpecificatieSoftdrugss = SpecificatieSoftdrugs.GetAll();
            Assert.ReferenceEquals(SpecificatieSoftdrugss, SpecificatieSoftdrugsen);
        }
    }
}