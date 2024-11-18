using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace y3s2_PROG_POE.Data
{
    

    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=./ServiceRequests.db;Version=3;";
        
        /// <summary>
        /// Method to initialize the database
        /// </summary>
        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS ServiceRequests (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Location TEXT NOT NULL,
                    Category TEXT NOT NULL,
                    Description TEXT NOT NULL,
                    FileName TEXT,
                    Status TEXT DEFAULT 'Pending',
                    FileData BLOB
                );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method to add a service request to the database
        /// </summary>
        /// <param name="location"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="filePath"></param>
        public static void AddServiceRequest(string location, string category, string description, string filePath)
        {
            byte[] fileData = File.ReadAllBytes(filePath);
            string fileName = Path.GetFileName(filePath);

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO ServiceRequests (Location, Category, Description, FileName, FileData, Status) VALUES (@Location, @Category, @Description, @FileName, @FileData, @Status)";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Category", category);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@FileName", fileName);
                    command.Parameters.AddWithValue("@FileData", fileData);
                    command.Parameters.AddWithValue("@Status", "Cancelled");
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// method to get file data from the database
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public static (string fileName, byte[] fileData) GetFileData(int requestId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT FileName, FileData FROM ServiceRequests WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", requestId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fileName = reader.GetString(0);
                            byte[] fileData = (byte[])reader["FileData"];
                            return (fileName, fileData);
                        }
                    }
                }
            }
            return (null, null);
        }
    }
}