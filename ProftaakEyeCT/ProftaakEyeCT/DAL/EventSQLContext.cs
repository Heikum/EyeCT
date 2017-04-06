using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProftaakEyeCT.DAL;

namespace ProftaakEyectEvents.DAL
{
    public class EventSQLContext: IEventContext
    {
        public List<Event> GetAllEvents()
        {
            List<Event> events = new List<Event>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Event ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            events.Add(CreateEventFromReader(reader));
                        }
                    }
                }
            }
            return events;
        }

        public Event InsertEvent(Event events)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Event (Description, Name, Location, Date)" +
                    "VALUES (@description, @name, @location, @date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@description", events.name);
                    command.Parameters.AddWithValue("@name", events.name);
                    command.Parameters.AddWithValue("@location", events.location);
                    command.Parameters.AddWithValue("@date", events.date);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                }
                return events;
            }
        }

        public void UpdateEvents(Event events)
        {
            string query = "UPDATE Event SET Description = @description, Name = @name, Location = @location, Date = @date WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", events.id);
                command.Parameters.AddWithValue("@description", events.description);
                command.Parameters.AddWithValue("@name", events.name);
                command.Parameters.AddWithValue("@location", events.location);
                command.Parameters.AddWithValue("@date", events.date);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteEvent(Event events)
        {
            string query = "DELETE FROM Event WHERE Id = @id";
            using (SqlConnection connection = Database.Connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", events.id);
                command.ExecuteNonQuery();
            }
        }

        private Event CreateEventFromReader(SqlDataReader reader)
        {
            return new Event(
                Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["Description"]),
                Convert.ToString(reader["Name"]),
                Convert.ToString(reader["Location"]),
                Convert.ToDateTime(reader["Date"]));

        }
    }
}
