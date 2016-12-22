using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLReactieContext : IReactie
    {
        public List<Reactie> GetAll()
        {
            List<Reactie> Reacties = new List<Reactie>();

            SqlCommand cmd = new SqlCommand("Select * from Reactie");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Reacties.Add(new Reactie(Convert.ToInt32(reader["ID"]),
                                            Convert.ToInt32(reader["Reactie_ID"]),
                                            Convert.ToInt32(reader["AccountType_ID"]),
                                            Convert.ToInt32(reader["Bijproduct_ID"]),
                                            Convert.ToInt32(reader["TypeDrugs_ID"]),
                                            Convert.ToString(reader["Tekst"])));
                }
            }
            return Reacties;
        }

        public void Add(Reactie Reactie)
        {
            SqlCommand cmd = new SqlCommand("Insert into Reactie (Account_ID, AccountType_ID, Bijproduct_ID, TypeDrugs_ID, Tekst)"
                                             + "Values (@Account_ID, @AccountType_ID, @Bijproduct_ID, @TypeDrugs_ID, @Tekst)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.Parameters.AddWithValue("@Account_ID", Reactie.ReactieID);
                cmd.Parameters.AddWithValue("@AccountType_ID", Reactie.AccountTypeID);
                cmd.Parameters.AddWithValue("@Bijproduct_ID", Reactie.Bijproduct_ID);
                cmd.Parameters.AddWithValue("@TypeDrugs_ID", Reactie.TypeDrugs_ID);
                cmd.Parameters.AddWithValue("@Tekst", Reactie.Tekst);
                cmd.ExecuteNonQuery();
            }
        }
    }
}