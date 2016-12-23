using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Reactie
    {
        public int ID { get; set; }
        public Nullable<int> ReactieID { get; set; }
        public Nullable<int> AccountTypeID { get; set; }
        public Nullable<int> Bijproduct_ID { get; set; }
        public Nullable<int> TypeDrugs_ID { get; set; }
      
        public string Tekst { get; set; }

        public Reactie(int ID, int? ReactieID, int? AccountTypeID, int? Bijproduct_ID, int? TypeDrugs_ID, string Tekst)
        {
            this.ID = ID;
            this.ReactieID = ReactieID ;
            this.AccountTypeID = AccountTypeID;
            this.Bijproduct_ID = Bijproduct_ID;
            this.TypeDrugs_ID = TypeDrugs_ID;
            this.Tekst = Tekst;
        }

        public Reactie(string Tekst)
        {
            this.Tekst = Tekst;
        }
    }
}