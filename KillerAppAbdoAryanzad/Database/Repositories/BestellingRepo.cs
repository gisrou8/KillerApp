using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class BestellingRepo
    {
        public IBestelling context { get; private set; }

        public BestellingRepo(IBestelling Context)
        {
            context = Context;
            
        }

        public void ProcedureUitvoeren(Gebruiker g)
        {
            context.ProcedureUitvoeren(g);
        }


        public void RijenToevoegen(string Product, double Prijs)
        {
            context.AddToTable(Product, Prijs);
        }



    }
}