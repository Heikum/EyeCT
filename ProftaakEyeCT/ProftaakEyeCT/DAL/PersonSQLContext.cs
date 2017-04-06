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
    public class PersonSQLContext:IPersonContext
    {

        public List<Person> GetAll()
        {
            List<Person> persons = new List<Person>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Person ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            persons.Add(CreatePersonFromReader(reader));
                        }
                    }
                }
            }
            return persons;
        }


        public Person GetByName(string Name)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Person Where Name=@name LIMIT 1";

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("name", Name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreatePersonFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }
       
        public Person Insert(Person person)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Person (Name,Zipcode,PlaceOfResidence,Street,Number,Phonenumber)"+
                    "VALUES (@name,@zipcode,@placeofresidence,@street,@number,@phonenumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("name", person.Name);
                    command.Parameters.AddWithValue("zipcode", person.Zipcode);
                    command.Parameters.AddWithValue("placeofresidence", person.City);
                    command.Parameters.AddWithValue("street", person.Street);
                    command.Parameters.AddWithValue("number", person.Number);
                    command.Parameters.AddWithValue("phonenumber", person.Phonenumber);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch(SqlException e)
                    {
                        MessageBox.Show("Error:"+e.Message);
                        return null;
                    }
                }
                return person;
            }
        }

        public bool Update(Person person)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Person" +
                    " SET Name=@name, Zipcode=@zipcode, PlaceOfResidence=@placeofresidence, Street=@street, Number=@number, Phonenumber=@phonenumber" +
                    " WHERE ID=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", person.Id);
                    command.Parameters.AddWithValue("name", person.Name);
                    command.Parameters.AddWithValue("zipcode", person.Zipcode);
                    command.Parameters.AddWithValue("placeofresidence", person.City);
                    command.Parameters.AddWithValue("street", person.Street);
                    command.Parameters.AddWithValue("number", person.Number);
                    command.Parameters.AddWithValue("phonenumber", person.Phonenumber);
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

        public bool Delete(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Person WHERE ID=@id";
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

        private Person CreatePersonFromReader(SqlDataReader reader)
        {
            return new Person(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["Name"]),
                Convert.ToString(reader["Zipcode"]),
                Convert.ToString(reader["PlaceOfResidence"]),
                Convert.ToString(reader["Street"]),
                Convert.ToInt32(reader["Number"]),
                Convert.ToInt32(reader["Phonenumber"]));

        }









    }
}
