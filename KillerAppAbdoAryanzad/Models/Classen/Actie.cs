using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Actie
    {
        public int ID { get; set; }
        public int Korting { get; set; }
        public int Coupon { get; set; }
        public string actie { get; set; }


        public Actie(int ID, int Korting, int Coupon, string actie)
        {
            this.ID = ID;
            this.Korting = Korting;
            this.Coupon = Coupon;
            this.actie = actie;
        }
    }
}