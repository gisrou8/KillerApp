using KillerAppAbdoAryanzad.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KillerAppAbdoAryanzad.Models;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class BijproductContext : IBijproduct
    {
        public List<Bijproduct> bijproducten = new List<Bijproduct>();
        public List<Bijproduct> GetAll()
        {
            return bijproducten;
        }
    }
}