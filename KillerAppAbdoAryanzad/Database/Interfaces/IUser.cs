using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Interfaces
{
    public interface IUser
    {
        List<User> GetAll();

        void Add(User user);

        User Login(string Gebruikersnaam, string Wachtwoord);
    }
}