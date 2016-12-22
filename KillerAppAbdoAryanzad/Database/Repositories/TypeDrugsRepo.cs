using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class TypeDrugsRepo
    {
        public ITypeDrugs context { get; private set; }


        public TypeDrugsRepo(ITypeDrugs Context)
        {
            context = Context;
        }

        public List<TypeDrugs> GetAll()
        {
            return context.GetAll();
        }
    }
}