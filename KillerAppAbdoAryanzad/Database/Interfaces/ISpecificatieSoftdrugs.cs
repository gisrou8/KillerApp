using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Interfaces
{
    public interface ISpecificatieSoftdrugs
    {
        List<SpecificatieSoftdrugs> GetAll();
    }
}