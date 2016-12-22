using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class BijproductRepo
    {
        public IBijproduct context { get; private set; }


        public BijproductRepo(IBijproduct Context)
        {
            this.context = Context;
        }

        public List<Bijproduct> GetAll()
        {
            return context.GetAll();
        }
    }
}