using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models.ViewModels
{
    public class TypeDrugsSpecificatieViewModel
    {
        public List<TypeDrugs> t { get; private set; }
        public List<Specificatie> s { get; private set; }

        public List<SpecificatieSoftdrugs> st { get; private set; }

        public TypeDrugsSpecificatieViewModel(List<TypeDrugs> t, List<Specificatie> s, List<SpecificatieSoftdrugs> st)
        {
            this.t = t;
            this.s = s;
            this.st = st;
        }
    }
}