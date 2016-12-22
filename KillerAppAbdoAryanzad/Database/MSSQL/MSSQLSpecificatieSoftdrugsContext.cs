using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLSpecificatieSoftdrugsSoftdrugsContext : ISpecificatieSoftdrugs
    {
        public List<SpecificatieSoftdrugs> GetAll()
        {
            List<SpecificatieSoftdrugs> SpecificatieSoftdrugsen = new List<SpecificatieSoftdrugs>();

            SqlCommand cmd = new SqlCommand("Select * from SpecificatieSoftdrugs");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    SpecificatieSoftdrugsen.Add(new SpecificatieSoftdrugs(Convert.ToInt32(reader["ID"]),
                                                            Convert.ToInt32(reader["Specificatie_ID"]),
                                                            Convert.ToInt32(reader["TypeDrugs_ID"])));
                }
            }
            return SpecificatieSoftdrugsen;
        }


        public void Add(Specificatie s, TypeDrugs t)
        {
            SqlCommand cmd = new SqlCommand("Insert into Specificatie_Softdrugs (Specificatie_ID, TypeDrugs_ID)"
                                             + "Values (@Specificatie_ID, @TypeDrugs_ID)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.Parameters.AddWithValue("@Specificatie_ID", t.ID);
                cmd.Parameters.AddWithValue("@TypeDrugs_ID", s.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}