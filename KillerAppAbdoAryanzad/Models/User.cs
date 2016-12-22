using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Email { get; set; }
        


        public User(int ID, string Gebruikersnaam, string Wachtwoord, string Email)
        {
            this.ID = ID;
            this.Gebruikersnaam = Gebruikersnaam;
            this.Wachtwoord = Wachtwoord;
           
            this.Email = Email;
         
        }
    }
}