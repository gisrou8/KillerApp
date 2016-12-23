using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class TypeDrugsContext : ITypeDrugs
    {
        public List<TypeDrugs> typedrugs = new List<TypeDrugs>();
        public List<TypeDrugs> GetAll()
        {
            return typedrugs;
        }
    }
}