using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.Json;
using Microsoft.Data.SqlClient;

class Program
{
    static string connectionString;

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; 

        LoadConfiguration();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Доступные таблицы в базе данных:");

            
            List<string> tables = GetTables();

            for (int i = 0; i < tables.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tables[i]}");
            }

            Console.Write("\nВведите номер таблицы (или 0 для выхода): ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }


            string selectedTable = "";
            if (int.TryParse(input, out int tableIndex) && tableIndex > 0 && tableIndex <= tables.Count)
            {
                selectedTable = tables[tableIndex - 1];
            }
            else if (tables.Contains(input))
            {
                selectedTable = input;
            }
            else
            {
                Console.WriteLine("Ошибка: такой таблицы нет.");
                continue;
            }

            TableMenu(selectedTable);
        }
    }

    static void LoadConfiguration()
    {
        try
        {
            string json = File.ReadAllText("config.json");
            var config = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            if (config != null && config.ContainsKey("ConnectionString"))
                connectionString = config["ConnectionString"];
            else
                throw new Exception("Ошибка в файле config.json");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Не удалось загрузить конфигурацию: " + ex.Message);
            Environment.Exit(1);
        }
    }

    static List<string> GetTables()
    {
        List<string> tables = new();
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }
            }
        }
        return tables;
    }

    static void TableMenu(string tableName)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Таблица: {tableName}");
            Console.WriteLine("1. Показать структуру таблицы");
            Console.WriteLine("2. Выбрать все данные (SELECT *)");
            Console.WriteLine("3. Вставить строку (INSERT)");
            Console.WriteLine("4. Обновить строку по ID (UPDATE)");
            Console.WriteLine("5. Удалить строку по ID (DELETE)");
            Console.WriteLine("6. Вернуться к списку таблиц");
            Console.Write("\nВыберите действие: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ShowTableStructure(tableName);
                    break;
                case "2":
                    SelectAll(tableName);
                    break;
                case "3":
                    InsertRow(tableName);
                    break;
                case "4":
                    UpdateRow(tableName);
                    break;
                case "5":
                    DeleteRow(tableName);
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте снова.");
                    break;
            }
        }
    }

    static void ShowTableStructure(string tableName)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = $"SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}'";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine($"\nСтруктура таблицы {tableName}:");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader.GetString(0)} - {reader.GetString(1)}");
                }
            }
        }
        Console.ReadLine();
    }

    static void SelectAll(string tableName)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = $"SELECT * FROM {tableName}";
            using (var command = new SqlCommand(query, connection))
            using (var reader = command.ExecuteReader())
            {
                Console.WriteLine($"\nДанные из таблицы {tableName}:");
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader.GetName(i)}: {reader[i]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        Console.ReadLine();
    }

    static void InsertRow(string tableName)
    {
        Console.Write("\nВведите значения через запятую (например: 'назва, ціна, ...') ");
        string values = Console.ReadLine();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = $"INSERT INTO {tableName} VALUES ({values})";
            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Запись добавлена.");
            }
        }
        Console.ReadLine();
    }

    static void UpdateRow(string tableName)
    {
        Console.Write("\nВведите ID строки для обновления: ");
        string id = Console.ReadLine();
        Console.Write("Введите SET выражение (например, name='Новый'): ");
        string setExpression = Console.ReadLine();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = $"UPDATE {tableName} SET {setExpression} WHERE id = {id}";
            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Запись обновлена.");
            }
        }
        Console.ReadLine();
    }

    static void DeleteRow(string tableName)
    {
        Console.Write("\nВведите ID строки для удаления: ");
        string id = Console.ReadLine();

        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = $"DELETE FROM {tableName} WHERE id = {id}";
            using (var command = new SqlCommand(query, connection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Запись удалена.");
            }
        }
        Console.ReadLine();
    }
}
