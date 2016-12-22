using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLBijproductContext : IBijproduct
    {
        public List<Bijproduct> GetAll()
        {
            List<Bijproduct> bijproducten = new List<Bijproduct>();

            SqlCommand cmd = new SqlCommand("Select * from Bijproduct");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    bijproducten.Add(new Bijproduct(Convert.ToInt32(reader["ID"]),
                                            Convert.ToString(reader["Naam"]),
                                            Convert.ToDecimal(reader["Prijs"]),
                                            Convert.ToString(reader["ProductInformatie"])));
                }
            }
            return bijproducten;
        }
    }
}