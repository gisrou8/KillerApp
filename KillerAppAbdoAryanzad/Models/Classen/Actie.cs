using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Models
{
    public class Actie
    {
        public int ID { get; private set; }
        public int Korting { get; private set; }
        public int Coupon { get; private set; }
        public string actie { get; private set; }


        public Actie(int ID, int Korting, int Coupon, string actie)
        {
            this.ID = ID;
            this.Korting = Korting;
            this.Coupon = Coupon;
            this.actie = actie;
        }
    }
}