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
        public class EventSQLContext : IEventContext
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
        public Event GetByName(string eventname)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Event Where Name=@eventname";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@eventname", eventname);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateEventFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }
        public Event GetById(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Event Where ID=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateEventFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Event InsertEvent(Event events)
            {
                using (SqlConnection connection = Database.Connection)
                {
                    string query = "INSERT INTO Event (Description, Name, Location, EventStartDate, EventEndDate)" +
                        "VALUES (@description, @name, @location, @eventstartdate, @eventenddate)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@description", events.name);
                        command.Parameters.AddWithValue("@name", events.name);
                        command.Parameters.AddWithValue("@location", events.location);
                        command.Parameters.AddWithValue("@eventstartdate", events.eventstartdate);
                        command.Parameters.AddWithValue("@eventenddate", events.eventenddate);
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
        public void InsertCampingspot(Event events, int campingspot, bool status)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO EventCampingspots (EventID, CampingSpotsID, Status)" +
                    "VALUES (@eventid, @campingspotid, @status)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@eventid", events.id);
                    command.Parameters.AddWithValue("@campingspotid", campingspot);
                    command.Parameters.AddWithValue("@status", status);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                }
                
            }

        }

            public bool UpdateEvents(Event events)
            {
                using (SqlConnection connection = Database.Connection)
                {
                    string query = "UPDATE Event" +
                        " SET Name=@name, Description=@description, Name=@name, Location=@location, EventStartDate=@eventstartdate, EventEndDate=@eventenddate" +
                        " WHERE ID=@id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("id", events.id);
                        command.Parameters.AddWithValue("description", events.description);
                        command.Parameters.AddWithValue("name", events.name);
                        command.Parameters.AddWithValue("location", events.location);
                        command.Parameters.AddWithValue("eventstartdate", events.eventstartdate);
                        command.Parameters.AddWithValue("eventenddate", events.eventenddate);
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

            public bool DeleteEvent(int id)
            {
                using (SqlConnection connection = Database.Connection)
                {
                    string query = "DELETE FROM Event WHERE ID=@id";
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

            private Event CreateEventFromReader(SqlDataReader reader)
            {
                return new Event(
                    Convert.ToInt32(reader["ID"]),
                    Convert.ToString(reader["Description"]),
                    Convert.ToString(reader["Name"]),
                    Convert.ToString(reader["Location"]),
                    Convert.ToDateTime(reader["EventStartDate"]),
                    Convert.ToDateTime(reader["EventEndDate"]));

            }

        public DateTime getStart()
        {
            DateTime tijd;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Event Where ID=@id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    tijd = 
                    return tijd;
                }
            }
        }
    }
    }

