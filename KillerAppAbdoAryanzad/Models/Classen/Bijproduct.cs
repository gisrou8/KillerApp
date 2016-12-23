using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Bijproduct
    {
        public int ID { get; private set; }
        public string Naam { get; private set; }
        public decimal Prijs { get; private set; }
        public string ProductInformatie { get; private set; }
        private List<Bestelling> Bestellingen = new List<Bestelling>();
        private List<Reactie> Reacties = new List<Reactie>();

        public Bijproduct(int ID, string Naam, decimal Prijs, string ProductInformatie)
        {
            this.ID = ID;
            this.Naam = Naam;
            this.Prijs = Prijs;
            this.ProductInformatie = ProductInformatie;
        }
    }
}