using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLBestellingProcedure : IBestelling
    {
        //public DataTable dt { get; private set; }


        public MSSQLBestellingProcedure()
        {
            //dt = new DataTable();
            //DataTableAanmaken();
        }
      
       
    

        public void ProcedureUitvoeren(Gebruiker g, DataTable dt)
        {

            SqlCommand cmd = new SqlCommand("[dbo].[BestellingUitvoeren]");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter tvparam = cmd.Parameters.AddWithValue("@Gebruiker", g.Naam);
            SqlParameter tvparam1 = cmd.Parameters.AddWithValue("@list", dt);
            SqlParameter tvparam2 = cmd.Parameters.AddWithValue("@ActieID", 51);

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.ExecuteNonQuery();
            }

           
        }

        //private void DataTableAanmaken()
        //{
        //    dt.Columns.Add("Product", typeof(string));
        //    dt.Columns.Add("Prijs", typeof(double));
        //}


        //public void AddToTable(string Product, double Prijs)
        //{
        //    dt.Rows.Add(Product, Prijs);
        //}




    }
}