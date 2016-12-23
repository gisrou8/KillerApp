using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class ProductModelView
    {
        public List<TypeDrugs> typedrugsen { get; private set; }
        public List<Bijproduct> bijproducten { get; private set; }
        public List<Specificatie> specificaties { get; private set; }
        public List<SpecificatieSoftdrugs> specdrugs { get; private set; }
        public List<Reactie> reacties { get; private set; }
        public List<Reactie> toonSoftreacties { get; private set; }
        public List<Reactie> toonBijreacties { get; private set; }
        public List<Gebruiker> gebruikers { get; private set; }
        public string Naam { get; private set; }
        public TypeDrugs Typedrug { get; private set; }
        public Bijproduct bijproduct { get; private set; }
        public Specificatie specificatie { get; private set; }
        public Reactie reactie { get; private set; }


        public ProductModelView(int id, List<TypeDrugs> typedrugsen, List<Bijproduct> bijproducten, List<Specificatie> specificaties, List<SpecificatieSoftdrugs> specdrugs, List<Reactie> reacties, List<Gebruiker> gebruikers)
        {
            this.typedrugsen = typedrugsen;
            this.bijproducten = bijproducten;
            this.specificaties = specificaties;
            this.specdrugs = specdrugs;
            this.reacties = reacties;
            this.gebruikers = gebruikers;
            toonSoftreacties = new List<Reactie>();
            toonBijreacties = new List<Reactie>();

            foreach (var i in typedrugsen)
            {
                if (i.ID == id)
                {            
                    Typedrug = i;
                    foreach (var sp in specdrugs)
                    {
                        if (sp.TypeDrugsID == i.ID)
                        {
                            foreach (var spec in specificaties)
                            {
                                if(spec.ID == sp.SpecificatieID)
                                {
                                    specificatie = spec;
                                    foreach (var r in reacties)
                                    {
                                        if(i.ID == r.TypeDrugs_ID)
                                        {
                                            toonSoftreacties.Add(r);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (var i in bijproducten)
            {
                if (i.ID == id)
                {
                    bijproduct = i;
                    foreach (var r in reacties)
                    {
                        if (i.ID == r.Bijproduct_ID)
                        {
                            toonBijreacties.Add(r);
                        }
                    }
                }
            }


        }

        public ProductModelView(int id,  List<Reactie> reacties, List<Gebruiker> gebruikers)
        {
            
            this.reacties = reacties;
            this.gebruikers = gebruikers;
            

           


        }


    }
}