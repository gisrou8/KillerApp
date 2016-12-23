using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class UserContext : IUser
    {
        List<User> users = new List<User>();
        public void Add(User user)
        {
            users.Add(user);
        }

        public List<User> GetAll()
        {
            return users;
        }

        public User Login(string Gebruikersnaam, string Wachtwoord)
        {
            throw new NotImplementedException();
        }
    }
}