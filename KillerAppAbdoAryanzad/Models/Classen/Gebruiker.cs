using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Gebruiker 
    {
        public int ID { get; private set; }
        public int Account_ID { get; private set; }
        public string Naam { get; private set; }
        public string Status { get; private set; }
        public string Woonplaats { get; private set; }
        public string AccountType { get; private set; }
        private List<Bestelling> bestellingen = new List<Bestelling>();
        private List<Reactie> Reacties = new List<Reactie>();
        public Gebruiker(int ID, int Account_ID, string AccountType, string Naam, string Status, string Woonplaats)
        {
            this.ID = ID;
            this.Account_ID = Account_ID;
            this.Naam = Naam;
            this.Status = Status;
            this.Woonplaats = Woonplaats;
            this.AccountType = AccountType;
            this.Woonplaats = Woonplaats;

        }

        public Gebruiker(int Account_ID, string AccountType, string Naam, string Status, string Woonplaats)
        {
            this.ID = ID;
            this.Account_ID = Account_ID;
            this.Naam = Naam;
            this.Status = Status;
            this.Woonplaats = Woonplaats;
            this.AccountType = AccountType;
            this.Woonplaats = Woonplaats;

        }


    }
}