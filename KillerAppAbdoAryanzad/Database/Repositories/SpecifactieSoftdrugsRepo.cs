using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class SpecifactieSoftdrugsRepo
    {
        public ISpecificatieSoftdrugs context;

        public SpecifactieSoftdrugsRepo(ISpecificatieSoftdrugs Context)
        {
            context = Context;
        }


        public List<SpecificatieSoftdrugs> GetAll()
        {
            return context.GetAll();
        }
    }
}