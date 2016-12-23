using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class SpecificatieSoftdrugsContext : ISpecificatieSoftdrugs
    {
        List<SpecificatieSoftdrugs> SSoftdrugs = new List<SpecificatieSoftdrugs>();
        public List<SpecificatieSoftdrugs> GetAll()
        {
            return SSoftdrugs;
        }
    }
}