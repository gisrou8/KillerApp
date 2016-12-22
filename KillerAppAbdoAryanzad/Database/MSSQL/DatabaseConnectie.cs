using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class DatabaseConnectie : IDisposable 
    {

        public SqlConnection Conn { get; private set; }


        public DatabaseConnectie()
        {
            Conn = new SqlConnection("Data Source=DESKTOP-OU4VKJ2\\SQLEXPRESS;Initial Catalog=CoffeshopOnline;Integrated Security=True");
            Conn.Open();
        }

        public void Dispose()
        {
            Conn.Close();
        }
    }
}