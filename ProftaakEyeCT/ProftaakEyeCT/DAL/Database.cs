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
        private static readonly string connectionString = "Data Source=proftaakserver.database.windows.net;Initial Catalog=Proftaakdb;Integrated Security=False;User ID=Admininistrator;Password=Hosting123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // For reference check: https://support.microsoft.com/en-us/help/307283/how-to-create-a-sql-server-database-programmatically-by-using-ado.net-and-visual-c-.net
        private static string str = "CREATE DATABASE" + databaseFilename;


        /// <summary>
        /// Creates a new database connection and directly opens it. The caller
        /// is resposible for properly closing the connection.
        /// </summary>
        /// 

        
            public static SqlConnection Connection
            {
                
                get{
                    SqlConnection connection = new SqlConnection(connectionString);
                try
                {
                    connection.Open();
                    
                }
                catch(Exception e)
                {
                    MessageBox.Show("De connectie naar de database is gesloten");
                    connection.Close();
                }
                return connection;
            }
            }

        /// <summary>
        /// Create a new database if it doesn't exist, and fill it with some
        /// dummy data.
        /// </summary>
        
        
    }
}