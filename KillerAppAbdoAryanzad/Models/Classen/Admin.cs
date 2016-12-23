using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Admin 
    {
        public int ID { get; private set; }
        public int Account_ID { get; private set; }
        public string Naam { get; private set; }
        public string Status { get; private set; }
        public string Woonplaats { get; private set; }
        public string AccountType { get; private set; }

        public Admin(int ID, int Account_ID, string AccountType, string Naam, string Status, string Woonplaats)
        {
            this.ID = ID;
            this.Account_ID = Account_ID;
            this.Naam = Naam;
            this.Status = Status;
            this.Woonplaats = Woonplaats;
            this.AccountType = AccountType;
        }
    }
}