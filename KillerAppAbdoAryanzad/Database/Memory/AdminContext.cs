using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database.Memory
{
    public class AdminContext : IAdmin
    {
        public List<Admin> admins = new List<Admin>();

        public void Add(Admin admin)
        {
            admins.Add(admin);
        }

        public List<Admin> GetAll()
        {
            return admins;
        }
    }
}