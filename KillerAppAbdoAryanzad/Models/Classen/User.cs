using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class User
    {
        public int ID { get; private set; }
        public string Gebruikersnaam { get; private set; }
        public string Wachtwoord { get; private set; }
        public string Email { get; private set; }
        


        public User(int ID, string Gebruikersnaam, string Wachtwoord, string Email)
        {
            this.ID = ID;
            this.Gebruikersnaam = Gebruikersnaam;
            this.Wachtwoord = Wachtwoord;
           
            this.Email = Email;
         
        }
        public User(string Gebruikersnaam, string Wachtwoord, string Email)
        {
            this.ID = ID;
            this.Gebruikersnaam = Gebruikersnaam;
            this.Wachtwoord = Wachtwoord;

            this.Email = Email;

        }
    }
}