using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Specificatie
    {
        public int ID { get; private set; }
        public string SpecificatieTekst { get; private set; }


        public Specificatie(int ID, string SpecificatieTekst)
        {
            this.ID = ID;
            this.SpecificatieTekst = SpecificatieTekst;
        }
    }
}