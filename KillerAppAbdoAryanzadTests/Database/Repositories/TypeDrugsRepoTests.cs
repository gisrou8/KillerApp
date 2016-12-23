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
    public class TypeDrugsRepoTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
            List<TypeDrugs> TypeDrugsen = new List<TypeDrugs>();
            TypeDrugsRepo TypeDrugs = new TypeDrugsRepo(new TypeDrugsContext());
            List<TypeDrugs> TypeDrugss = TypeDrugs.GetAll();
            Assert.ReferenceEquals(TypeDrugss, TypeDrugsen);
        }
    }
}