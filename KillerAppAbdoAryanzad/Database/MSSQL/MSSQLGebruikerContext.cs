using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLGebruikerContext : IGebruiker
    {
        public List<Gebruiker> GetAll()
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            SqlCommand cmd = new SqlCommand("Select * from AccountType where Account_ID != 1");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gebruikers.Add(new Gebruiker(Convert.ToInt32(reader["ID"]),
                                            Convert.ToInt32(reader["Account_ID"]),
                                            Convert.ToString(reader["AccountType"]),
                                            Convert.ToString(reader["Naam"]),
                                            Convert.ToString(reader["Status"]),
                                            Convert.ToString(reader["Woonplaats"])));
                }
            }
            return gebruikers;
        }


        public void Add(Gebruiker gebruiker)
        {
            SqlCommand cmd = new SqlCommand("Insert into AccountType (Account_ID, AccountType, Naam, Status, Woonplaats)"
                                             + "Values (@Account_ID, @AccountType, @Naam, @Status, @Woonplaats)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.Parameters.AddWithValue("@Account_ID", gebruiker.Account_ID);
                cmd.Parameters.AddWithValue("@AccountType", gebruiker.AccountType);
                cmd.Parameters.AddWithValue("@Naam", gebruiker.Naam);
                cmd.Parameters.AddWithValue("@Status", gebruiker.Status);
                cmd.Parameters.AddWithValue("@Woonplaats", gebruiker.Woonplaats);
                cmd.ExecuteNonQuery();
            }
        }
    }
}