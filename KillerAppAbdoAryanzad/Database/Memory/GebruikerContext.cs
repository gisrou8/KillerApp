using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class GebruikerContext : IGebruiker
    {
        private List<Gebruiker> gebruikers = new List<Gebruiker>();

        public void Add(Gebruiker gebruiker)
        {
            gebruikers.Add(gebruiker);
        }

        public List<Gebruiker> GetAll()
        {
            return gebruikers;
        }
    }
}