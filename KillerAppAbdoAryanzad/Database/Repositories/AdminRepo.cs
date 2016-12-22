using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Repositories
{
    public class AdminRepo
    {
        public IAdmin context { get; private set; }


        public AdminRepo(IAdmin Context)
        {
            context = Context;
        }

        public List<Admin> GetAll()
        {
            return context.GetAll();
        }

        public void Add(Admin a)
        {
            context.Add(a);
        }
    }
}