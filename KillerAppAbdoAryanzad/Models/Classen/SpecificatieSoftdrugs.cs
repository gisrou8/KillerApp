using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class SpecificatieSoftdrugs
    {
        public int ID { get; set; }
        public int SpecificatieID { get; set; }
        public int TypeDrugsID { get; set; }

        public SpecificatieSoftdrugs(int ID, int SpecificatieID, int TypeDrugsID)
        {
            this.ID = ID;
            this.SpecificatieID = SpecificatieID;
            this.TypeDrugsID = TypeDrugsID;
        }
    }
}