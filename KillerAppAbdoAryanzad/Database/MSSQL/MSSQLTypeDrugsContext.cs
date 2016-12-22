using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLTypeDrugsContext : ITypeDrugs
    {
        public List<TypeDrugs> GetAll()
        {
            List<TypeDrugs> typedrugsen = new List<TypeDrugs>();

            SqlCommand cmd = new SqlCommand("Select * from TypeDrugs");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    typedrugsen.Add(new TypeDrugs(Convert.ToInt32(reader["ID"]),
                                            Convert.ToInt32(reader["Softdrugs_ID"]),
                                            Convert.ToString(reader["Naam"]),
                                            Convert.ToDecimal(reader["Prijs"]),
                                            Convert.ToString(reader["Extra_Informatie"])));
                }
            }
            return typedrugsen;
        }
    }
}