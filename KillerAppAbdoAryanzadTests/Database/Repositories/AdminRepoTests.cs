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
    public class AdminRepoTests
    {

        List<Admin> admins = new List<Admin>();
        [TestMethod()]
        public void GetAllTest()
        {
            
            AdminRepo admin = new AdminRepo(new AdminContext());
            List<Admin> Admins = admin.GetAll();
            Assert.ReferenceEquals(Admins, admins);
        }

        [TestMethod()]
        public void AddTest()
        {
            AdminRepo admin = new AdminRepo(new AdminContext());
            Admin a = new Admin(0, 0, "admin", "Jan", "Gevorderd", "Best");
            admin.Add(a);
            List<Admin> Admins = admin.GetAll();
            Assert.AreNotEqual(Admins.Count == 0, Admins.Count == 1);
        }
    }
}