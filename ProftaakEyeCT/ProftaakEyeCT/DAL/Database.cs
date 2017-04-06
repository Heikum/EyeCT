using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ProftaakEyectEvents
{
    public class Database
    {
        // De bestandsnaam voor de database
        private static readonly string databaseFilename = "Hier komt de file naam van de database";
        private static readonly string connectionString = "connectionString" + databaseFilename;

        // For reference check: https://support.microsoft.com/en-us/help/307283/how-to-create-a-sql-server-database-programmatically-by-using-ado.net-and-visual-c-.net
        private static string str = "CREATE DATABASE" + databaseFilename;


        /// <summary>
        /// Creates a new database connection and directly opens it. The caller
        /// is resposible for properly closing the connection.
        /// </summary>
        public static SqlConnection Connection
        {
            get
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
        }

        /// <summary>
        /// Create a new database if it doesn't exist, and fill it with some
        /// dummy data.
        /// </summary>
        public static void Initialize()
        {
            bool recreateDatabase = false;

            // Check if the database already exists
            if (File.Exists("Hier komt de file naam van de database"))
            {
                // If this source file is also found when running the program,
                // see if it was modified after the database was last written to
                if (File.Exists(@"..\..\Data\Database.cs") &&
                        (new FileInfo(@".\Hier komt de file naam van de database").LastWriteTime <
                         new FileInfo(@"..\..\Data\Database.cs").LastWriteTime))
                {
                    recreateDatabase = true;
                }
            }
            else
            {
                recreateDatabase = true;
            }

            // File doesn't exist, or this file was modified after the database
            // was created: recreate the database
            if (recreateDatabase)
            {
                Console.WriteLine("Database (re)created.");
                SqlCommand recreateDb = new SqlCommand(str, Connection);

                // Create some dummy data to work with
                using (SqlConnection connection = Database.Connection)
                {
                    string[] queries = new string[] {
                        "Create queries here"
                    };

                    foreach (string query in queries)
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }

                    }
                }
            }
        }
    }
}