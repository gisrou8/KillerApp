using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLSpecificatieContext : ISpecificatie
    {
        public List<Specificatie> GetAll()
        {
            List<Specificatie> Specificatieen = new List<Specificatie>();

            SqlCommand cmd = new SqlCommand("Select * from Specificatie");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Specificatieen.Add(new Specificatie(Convert.ToInt32(reader["ID"]),
                                            Convert.ToString(reader["Specificatietekst"])));
                }
            }
            return Specificatieen;
        }
    }
}