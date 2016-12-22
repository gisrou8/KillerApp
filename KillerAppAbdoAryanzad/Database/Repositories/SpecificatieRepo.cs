using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class SpecificatieRepo
    {
        public ISpecificatie context { get; private set; }

        public SpecificatieRepo(ISpecificatie Context)
        {
            context = Context;
        }


        public List<Specificatie> GetAll()
        {
            return context.GetAll();
        }

        


    }
}