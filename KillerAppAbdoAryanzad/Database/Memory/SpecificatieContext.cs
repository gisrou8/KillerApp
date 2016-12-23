using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class SpecificatieContext : ISpecificatie
    {
        public List<Specificatie> specificatie = new List<Specificatie>();
        public List<Specificatie> GetAll()
        {
            return specificatie;
        }
    }
}