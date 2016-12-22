using KillerAppAbdoAryanzad.Database.Interfaces;
using KillerAppAbdoAryanzad.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KillerAppAbdoAryanzad.Database
{
    public class MSSQLUserContext : IUser
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            SqlCommand cmd = new SqlCommand("Select * from Account");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    users.Add(new User(Convert.ToInt32(reader["ID"]),
                                       Convert.ToString(reader["Gebruikersnaam"]),
                                       Convert.ToString(reader["Wachtwoord"]),
                                       Convert.ToString(reader["Email"])));
                }
            }
            return users;
               
                
        }

        public void Add(User user)
        {
            SqlCommand cmd = new SqlCommand("Insert into Account (Gebruikersnaam, Wachtwoord, Email)"
                                             + "Values (@Gebruikersnaam, @Wachtwoord, @Email)");

            using (DatabaseConnectie conn = new DatabaseConnectie())
            {
                cmd.Connection = conn.Conn;
                cmd.Parameters.AddWithValue("@Gebruikersnaam", user.Gebruikersnaam);
                cmd.Parameters.AddWithValue("@Wachtwoord", user.Wachtwoord);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.ExecuteNonQuery();
            }
        }
    }
}