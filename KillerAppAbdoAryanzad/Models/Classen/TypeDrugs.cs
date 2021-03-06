﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class TypeDrugs
    {
        public int ID { get; private set; }
        public int SoftdrugsID { get; private set; }
        public string Naam { get; private set; }
        public string ExtraInformatie { get; private set; }
        public decimal Prijs { get; private set; }
        private List<Bestelling> Bestellingen = new List<Bestelling>();
        private List<Reactie> Reacties = new List<Reactie>();
        private Specificatie Specificatie;

        public TypeDrugs(int ID, int SoftdrugsID, string Naam, decimal Prijs, string ExtraInformatie)
        {
            this.ID = ID;
            this.SoftdrugsID = SoftdrugsID;
            this.Naam = Naam;
            this.ExtraInformatie = ExtraInformatie;
            this.Prijs = Prijs;
        }
    }
}