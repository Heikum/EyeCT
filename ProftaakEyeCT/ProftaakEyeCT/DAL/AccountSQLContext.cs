using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;

namespace ProftaakEyectEvents.DAL
{
    public class AccountSQLContext : IAccountContext
    {
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

        public Account InsertStudent(Student student)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Account (Username, Password, Emailadress, Rights)" +
                    "VALUES (@username, @password, @emailadress, @rights)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", student.Username);
                    command.Parameters.AddWithValue("@password", student.Password);
                    command.Parameters.AddWithValue("@emailadress", student.Emailadress);
                    command.Parameters.AddWithValue("@rights", student.Rights = 0);


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                }
                return student;
            }
        }

        public Account InsertAdmin(Admin admin)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Account (Username, Password, Emailadress, Rights)" +
                    "VALUES (@username, @password, @emailadress, @rights)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", admin.Username);
                    command.Parameters.AddWithValue("@password", admin.Password);
                    command.Parameters.AddWithValue("@emailadress", admin.Emailadress);
                    command.Parameters.AddWithValue("@rights", admin.Rights = 1);


                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                }
                return admin;
            }
        }

        public void DeleteAccount(Account account)
        {
            string query = "DELETE FROM Account WHERE ID = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", account.Id);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAccount(Account account)
        {
            string query = "UPDATE Account SET Username = @username, Password = @password, Emailadress = @emailadress, Rights = @rights WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("id", account.Id);
                command.Parameters.AddWithValue("username", account.Username);
                command.Parameters.AddWithValue("password", account.Password);
                command.Parameters.AddWithValue("emailadress", account.Emailadress);
                command.Parameters.AddWithValue("rights", account.Rights);
                command.ExecuteNonQuery();
            }
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

        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            switch (Convert.ToString(reader["Type"]))
            {
                case "Student":
                    return new Student(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["Username"]),
                        Convert.ToString(reader["Password"]),
                        Convert.ToString(reader["Emailadress"]),
                        Convert.ToInt32(reader["Rights"]));

                case "Admin":
                    return new Admin(
                         Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["Username"]),
                        Convert.ToString(reader["Password"]),
                        Convert.ToString(reader["Emailadress"]),
                        Convert.ToInt32(reader["Rights"]));

            }

            return null;
        }
    }
}
