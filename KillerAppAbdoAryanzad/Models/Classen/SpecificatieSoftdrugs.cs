using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class SpecificatieSoftdrugs
    {
        public int ID { get; private set; }
        public int SpecificatieID { get; private set; }
        public int TypeDrugsID { get; private set; }

        public SpecificatieSoftdrugs(int ID, int SpecificatieID, int TypeDrugsID)
        {
            this.ID = ID;
            this.SpecificatieID = SpecificatieID;
            this.TypeDrugsID = TypeDrugsID;
        }
    }
}