using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Bijproduct
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public string ProductInformatie { get; set; }
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