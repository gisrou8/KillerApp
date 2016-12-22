using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLAdminContext : IAdmin
    {
        public List<Admin> GetAll()
        {
            List<Admin> admins = new List<Admin>();

            SqlCommand cmd = new SqlCommand("Select * from AccountType where Account_ID = 1");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    admins.Add(new Admin(Convert.ToInt32(reader["ID"]),
                                            Convert.ToInt32(reader["Account_ID"]),
                                            Convert.ToString(reader["AccountType"]),
                                            Convert.ToString(reader["Naam"]),
                                            Convert.ToString(reader["Status"]),
                                            Convert.ToString(reader["Woonplaats"])));
                }
            }
            return admins;
        }


        public void Add(Admin admin)
        {
            SqlCommand cmd = new SqlCommand("Insert into AccountType (Account_ID, AccountType, Naam, Status, Woonplaats)"
                                             + "Values (@Account_ID, @AccountType, @Naam, @Status, @Woonplaats)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.Parameters.AddWithValue("@Account_ID", admin.Account_ID);
                cmd.Parameters.AddWithValue("@AccountType", admin.AccountType);
                cmd.Parameters.AddWithValue("@Naam", admin.Naam);
                cmd.Parameters.AddWithValue("@Status", admin.Status);
                cmd.Parameters.AddWithValue("@Woonplaats", admin.Woonplaats);
                cmd.ExecuteNonQuery();
            }
        }
    }
}