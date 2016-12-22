using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Bestelling
    {
        public int ID { get; set; }
        public decimal Prijs { get; set; }
        private List<Bijproduct> Bijproducten = new List<Bijproduct>();
        private List<TypeDrugs> Typedrugsen = new List<TypeDrugs>();

        public Bestelling(int ID, decimal Prijs)
        {
            this.ID = ID;
            this.Prijs = Prijs;
        }
    }
}