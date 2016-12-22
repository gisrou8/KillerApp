using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Reactie
    {
        public int ID { get; set; }
        public string Tekst { get; set; }

        public Reactie(int ID, string Tekst)
        {
            this.ID = ID;
            this.Tekst = Tekst;
        }
    }
}