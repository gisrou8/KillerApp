using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppAbdoAryanzad.Database.Interfaces
{
    public interface IReactie
    {
        List<Reactie> GetAll();

        void Add(Reactie Reactie);
    }
}
