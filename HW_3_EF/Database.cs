using System;
using System.Linq;
using System.IO;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;
using Microsoft.Data.SqlClient;

namespace HW_3_EF
{
    public static class Database
    {
        private static string connectionString;
        public static void RegisterUser(string username, string password, byte[] profilePicture)
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.Username == username))
                    throw new Exception("Пользователь уже существует");

                string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

                var user = new User
                {
                    Username = username,
                    PasswordHash = passwordHash,
                    ProfilePicture = profilePicture
                };

                context.Users.Add(user);
                context.SaveChanges();
            }
        }

        public static bool ValidateUser(string username, string password, out byte[] profilePicture)
        {
            using (var context = new AppDbContext())
            {
                profilePicture = null;
                var user = context.Users.FirstOrDefault(u => u.Username == username);

                if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                {
                    profilePicture = user.ProfilePicture;
                    return true;
                }
                return false;
            }
        }

        public static void UpdateProfilePicture(string username, byte[] newPicture)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Users SET ProfilePicture = @ProfilePicture WHERE Username = @Username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@ProfilePicture", (object)newPicture ?? DBNull.Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
