using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data;

namespace ProftaakEyectEvents.DAL
{
    public class AccountSQLContext : IAccountContext
    {

        private Account account;
        //Get all the students
        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public List<Account> GetAllStudents()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Rights = 0 ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public List<Account> GetAllAdmins()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Rights = 1 ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public Account InsertAccount(Account account, Person person)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Account (Kind, PersonID, Username, Emailadress, Password, Rights)" +
                    "VALUES (@kind, @personid, @username, @emailadress, @password, @rights)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                   
                    command.Parameters.AddWithValue("@kind", account.Kind);
                    command.Parameters.AddWithValue("@personid", person.Id);
                    command.Parameters.AddWithValue("@username", account.Username);
                    command.Parameters.AddWithValue("@emailadress", account.Emailadress);
                    command.Parameters.AddWithValue("@password", account.Password);
                    command.Parameters.AddWithValue("@rights", account.Rights);


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                    return account;
                    
                }
                
            }
        }
        public Account GetAccountByUsername(string username)
        {
            
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                account = CreateAccountFromReader(reader);
                            }
                        }
                    }
                
                }
            return account;
                
            }

        public Account GetAccountRights(string username)
        {

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE Username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            account = CreateAccountFromReader(reader);
                        }
                    }
                }

            }
            return account;

        }

        public bool DeleteAccount(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Account WHERE ID=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", id);
                    if (Convert.ToInt32(command.ExecuteNonQuery()) == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool UpdateAccount(Account account)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Account SET Username = @username, Password = @password, Emailadress = @emailadress, Rights = @rights WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("id", account.Id);
                    command.Parameters.AddWithValue("username", account.Username);
                    command.Parameters.AddWithValue("password", account.Password);
                    command.Parameters.AddWithValue("emailadress", account.Emailadress);
                    command.Parameters.AddWithValue("rights", account.Rights);
                    command.ExecuteNonQuery();
                    try
                    {
                        if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }
            }

            return false;
        }

        public bool Login(string gebruikersnaam, string wachtwoord)
        {
            SqlConnection connection = Database.Connection;
            ConnectionState conState = connection.State;
            if (conState == ConnectionState.Open)
            {
                using (connection)
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM [Account] 
                                        WHERE Username=@uname and Password=@pass", connection);
                    cmd.Parameters.AddWithValue("@uname", gebruikersnaam);
                    cmd.Parameters.AddWithValue("@pass", wachtwoord);
                    var result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                    {
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
            return false;

        }

        public int GetID()
        {
            int userid; 
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT TOP 1 ID FROM Account ORDER BY ID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    userid = Convert.ToInt32(command.ExecuteScalar());
                    return userid; 
                }
            }
        }

        public int GetAccountIDByUsername(string gebruikersnaam)
        {
            int userid;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT ID FROM Account where username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", gebruikersnaam);
                    userid = Convert.ToInt32(command.ExecuteScalar());

                }
            }
            return userid;
        }


        public List<Account> GetAllAccountInformation()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT A.*, P.Name AS OwnerName, P.Phonenumber" +
                " FROM Account A LEFT JOIN Person P ON P.Id = A.Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public string GetTelNr(string username)
        {
            string Telnr;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT Person.Phonenumber FROM Account INNER JOIN Person ON Person.ID = Account.PersonID WHERE Account.Username = @acc";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@acc", username);
                    Telnr = Convert.ToString(command.ExecuteScalar());
                }
            }
            return Telnr;
        }

        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            return new Account(
                 Convert.ToInt32(reader["ID"]),
                 Convert.ToString(reader["Kind"]),
                 Convert.ToInt32(reader["PersonID"]),
                 Convert.ToString(reader["Username"]),
                 Convert.ToString(reader["Emailadress"]),
                 Convert.ToString(reader["Password"]),
                 Convert.ToBoolean(reader["Rights"]));
        }
    }
}
