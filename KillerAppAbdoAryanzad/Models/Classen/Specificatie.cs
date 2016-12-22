using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Specificatie
    {
        public int ID { get; set; }
        public string SpecificatieTekst { get; set; }


        public Specificatie(int ID, string SpecificatieTekst)
        {
            this.ID = ID;
            this.SpecificatieTekst = SpecificatieTekst;
        }
    }
}