using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppAbdoAryanzad.Database.Interfaces
{
    public interface IBestelling
    {
        void ProcedureUitvoeren(Gebruiker g);

        void AddToTable(string Product, double Prijs);
    }
}
