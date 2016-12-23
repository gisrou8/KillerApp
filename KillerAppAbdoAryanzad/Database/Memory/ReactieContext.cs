using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class ReactieContext : IReactie
    {
        List<Models.Reactie> reacties = new List<Models.Reactie>();

        public void Add(Models.Reactie Reactie)
        {
            reacties.Add(Reactie);
        }

        public List<Models.Reactie> GetAll()
        {
            return reacties;
        }
    }
}