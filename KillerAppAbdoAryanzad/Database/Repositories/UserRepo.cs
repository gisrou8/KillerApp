using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class UserRepo
    {
        public IUser context { get; private set; }

        public UserRepo(IUser Context)
        {
            context = Context;
        }

        public List<User> GetAll()
        {
            return context.GetAll();
        }

        public void Add(User u)
        {
            context.Add(u);
        }

        public User Login(string Gebruikersnaam, string Wachtwoord)
        {
            return context.Login(Gebruikersnaam, Wachtwoord);
        }
    }
}