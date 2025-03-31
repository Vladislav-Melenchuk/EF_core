using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;
using System.Text.Json;

public static class Database
{
    private static string connectionString;

    static Database()
    {
        LoadConfiguration();
    }

    private static void LoadConfiguration()
    {
        try
        {
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
            string json = File.ReadAllText(configPath);
            var config = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            if (config != null && config.ContainsKey("ConnectionString"))
                connectionString = config["ConnectionString"];
            else
                throw new Exception("Ошибка в файле config.json");
        }
        catch (Exception ex)
        {
            throw new Exception("Ошибка при загрузке конфигурации: " + ex.Message);
        }
    }

    public static bool UserExists(string username)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public static void RegisterUser(string username, string password, byte[] profilePicture)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            string query = "INSERT INTO Users (Username, Password, ProfilePicture) VALUES (@Username, @Password, @ProfilePicture)";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                // Проверяем, есть ли фото. Если нет - записываем NULL
                if (profilePicture != null && profilePicture.Length > 0)
                {
                    command.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary, profilePicture.Length).Value = profilePicture;
                }
                else
                {
                    command.Parameters.Add("@ProfilePicture", SqlDbType.VarBinary).Value = DBNull.Value; // Если фото нет
                }

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }


    public static bool ValidateUser(string username, string password, out byte[] profilePicture)
    {
        profilePicture = null;
        using (var connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Password, ProfilePicture FROM Users WHERE Username = @Username";
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader.GetString(0);
                        if (storedPassword == password)
                        {
                            if (!reader.IsDBNull(1))
                                profilePicture = (byte[])reader["ProfilePicture"];
                            return true;
                        }
                    }
                }
            }
        }
        return false;
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
