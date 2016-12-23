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
                    int reactie_ID = (reader["Reactie_ID"] != DBNull.Value) ? Convert.ToInt32(reader["Reactie_ID"]) : 0;
                    int AccountType_ID = (reader["AccountType_ID"] != DBNull.Value) ? Convert.ToInt32(reader["AccountType_ID"]) : 0;
                    int Bijproduct_ID = (reader["Bijproduct_ID"] != DBNull.Value) ? Convert.ToInt32(reader["Bijproduct_ID"]) : 0;
                    int TypeDrugs_ID = (reader["TypeDrugs_ID"] != DBNull.Value) ? Convert.ToInt32(reader["TypeDrugs_ID"]) : 0;
                    Reacties.Add(new Reactie(Convert.ToInt32(reader["ID"]),
                                            reactie_ID,
                                            AccountType_ID,
                                            Bijproduct_ID,
                                            TypeDrugs_ID,
                                            Convert.ToString(reader["Tekst"])));
                }
            }
            return Reacties;
        }

        public void Add(Reactie Reactie)
        {
            SqlCommand cmd = new SqlCommand("Insert into Reactie (Reactie_ID, AccountType_ID, Bijproduct_ID, TypeDrugs_ID, Tekst)"
                                             + "Values (@Reactie_ID, @AccountType_ID, @Bijproduct_ID, @TypeDrugs_ID, @Tekst)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                if(Reactie.ReactieID == null)
                {
                    cmd.Parameters.AddWithValue("@Reactie_ID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Reactie_ID", Reactie.ReactieID);
                }

                cmd.Parameters.AddWithValue("@AccountType_ID", Reactie.AccountTypeID);

                if (Reactie.Bijproduct_ID == null)
                {
                    cmd.Parameters.AddWithValue("@Bijproduct_ID", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Bijproduct_ID", Reactie.Bijproduct_ID);
                }
                if (Reactie.TypeDrugs_ID == null)
                {
                    cmd.Parameters.AddWithValue("@TypeDrugs_ID", DBNull.Value); 
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TypeDrugs_ID", Reactie.TypeDrugs_ID);
                }

                cmd.Parameters.AddWithValue("@Tekst", Reactie.Tekst);
                cmd.ExecuteNonQuery();
            }
        }
    }
}