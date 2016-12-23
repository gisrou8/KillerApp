using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class ZoekProductenModelView
    {
        public int TypedrugID { get; private set; }
        public int BijproductID { get; private set; }
        List<TypeDrugs> typedrugs { get; set; }
        List<Bijproduct> bijproducten { get; set; }

        public ZoekProductenModelView(List<TypeDrugs> typedrugs, List<Bijproduct> bijproducten, string tekst)
        {
            TypedrugID = 0;
            BijproductID = 0;
            foreach (var i in typedrugs)
            {
                
                if(i.Naam == tekst)
                {
                    TypedrugID = i.ID;
                }
            }
            if(TypedrugID == 0)
            {
                foreach (var i in bijproducten)
                {
                    
                    if (i.Naam == tekst)
                    {
                        BijproductID = i.ID;
                    }
                }
                     
            }
        }
   
    }
}