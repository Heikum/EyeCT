using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;

namespace ProftaakEyectEvents.DAL
{
    public class AccountSQLContext:IAccountContext
    {
        //Get all the students
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account ORDER BY Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(CreateStudentFromReader(reader));
                        }
                    }
                }
            }
            return students;
        }

        //Get all the admins
        public List<Admin> GetAllAdmins()
        {
            List<Admin> admins = new List<Admin>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account ORDER BY Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            admins.Add(CreateAdminFromReader(reader));
                        }
                    }
                }
            }
            return admins;
        }

        //Check for student with exact username
        public Student GetStudentByUsername(string Username)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account Where Username = username LIMIT 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Username", Username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateStudentFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        //Check for admin with exact username
        public Admin GetAdminByUsername(string Username)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account Where Username = username LIMIT 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("Username", Username);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateAdminFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }


        private Student CreateStudentFromReader(SqlDataReader reader)
        {
            return new Student(
                Convert.ToString(reader["Username"]),
                Convert.ToString(reader["Password"]),
                Convert.ToString(reader["E-mailadress"]),
                Convert.ToBoolean(reader["Rights"]));
            //Moet nog het persoon object bij

        }

        private Admin CreateAdminFromReader(SqlDataReader reader)
        {
            return new Admin(
                Convert.ToString(reader["Username"]),
                Convert.ToString(reader["Password"]),
                Convert.ToString(reader["E-mailadress"]),
                Convert.ToBoolean(reader["Rights"]));
            //Moet nog het persoon object bij

        }
    }
}
