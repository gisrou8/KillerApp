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
    public class UserRepoTests
    {


        [TestMethod()]
        public void GetAllTest()
        {
            List<User> Useren = new List<User>();
            UserRepo User = new UserRepo(new UserContext());
            List<User> Users = User.GetAll();
            Assert.ReferenceEquals(Users, Useren);
        }

        [TestMethod()]
        public void AddTest()
        {
            UserRepo User = new UserRepo(new UserContext());
            User a = new User(0, "J", "K", "JK");
            User.Add(a);
            List<User> Users = User.GetAll();
            Assert.AreNotEqual(Users.Count == 0, Users.Count == 1);
        }

    }
}