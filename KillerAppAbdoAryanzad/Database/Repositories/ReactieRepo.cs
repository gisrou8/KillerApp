using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class ReactieRepo
    {
        public IReactie context;


        public ReactieRepo(IReactie Context)
        {
            context = Context;
        }


        public List<Reactie> GetAll()
        {
            return context.GetAll();
        }

        public void Add(Reactie r)
        {
            context.Add(r);
        }
    }
}