using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class BijproductViewModel
    {
        public List<Bijproduct> bijproducten;


        public BijproductViewModel(List<Bijproduct> Bijproducten)
        {
            this.bijproducten = Bijproducten;
        }
    }
}