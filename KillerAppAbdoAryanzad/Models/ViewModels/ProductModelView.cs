using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class ProductModelView
    {
        public List<TypeDrugs> t { get; private set; }
        public List<Bijproduct> b { get; private set; }
        public TypeDrugs Typedrug { get; private set; }
        public Bijproduct bijproduct { get; private set; }

        public ProductModelView(int id, List<TypeDrugs> t, List<Bijproduct> b)
        {
            this.t = t;
            this.b = b;

            foreach (var i in t)
            {
                if (i.ID == id)
                {
                    Typedrug = i;

                }
            }

       
            foreach (var i in b)
            {
                if(i.ID == id)
                {
                    bijproduct = i;
                }
            }
            
        }

       
    }
}