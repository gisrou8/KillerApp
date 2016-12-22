using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class GebruikerRepo
    {
        public IGebruiker context { get; private set; }

        public GebruikerRepo(IGebruiker Context)
        {
            context = Context;
        }

        public List<Gebruiker> GetAll()
        {
            return context.GetAll();
        }

        public void Add(Gebruiker g)
        {
            context.Add(g);
        }
         

    }
}