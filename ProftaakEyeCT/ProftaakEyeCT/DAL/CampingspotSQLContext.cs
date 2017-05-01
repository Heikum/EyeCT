using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProftaakEyeCT.DAL
{
    public class CampingspotSQLContext:ICampingspotContext
    {
        public List<CampingSpot> GetAllAvailable(Event events)
        {
            List<CampingSpot> campingspot = new List<CampingSpot>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM EventCampingspots INNER JOIN CampingSpots ON EventCampingspots.CampingSpotsID = CampingSpots.ID WHERE Status = 1 AND EventID = @eventid ";

                //commit
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("eventid", events.id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            campingspot.Add(CreateCampingspotFromReader(reader));
                        }
                    }
                }
            }
            return campingspot ;
        }
        public List<CampingSpot> GetByEvent(Event events)
        {
            List<CampingSpot> campingspot = new List<CampingSpot>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM EventCampingspots INNER JOIN CampingSpots ON EventCampingspots.CampingSpotsID = CampingSpots.ID WHERE EventCampingspots.EventID = @eventid";

                //commit
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@eventid", events.id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            campingspot.Add(CreateCampingspotFromReader(reader));
                        }
                    }
                }
            }
            return campingspot;
        }
        public int GetCampingspotById(int campingspotid)
        {
            
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT CampingSpotsID FROM EventCampingspots INNER JOIN CampingSpots ON EventCampingspots.CampingSpotsID = CampingSpots.ID WHERE EventCampingspots.ID = @id";

                //commit
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", campingspotid);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (int)reader.GetValue(0);
                        }
                    }
                }
            }
            return 0;
        }
        public bool UpdateCampingspot(int eventid, int campingspotid, bool status)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE EventCampingspots" +
                    " SET Status=@status" +
                    " WHERE CampingSpotsID=@campingspotsid AND EventID =@eventid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("status", status);
                    command.Parameters.AddWithValue("campingspotsid", campingspotid);
                    command.Parameters.AddWithValue("eventid", eventid);

                    try
                    {
                        if (Convert.ToInt32(command.ExecuteNonQuery()) > 0)
                        {
                            return true;
                        }
                    }
                    catch (SqlException e)
                    {
                        
                    }

                }
            }

            return false;
        }
        private CampingSpot CreateCampingspotFromReader(SqlDataReader reader)
        {
            return new CampingSpot(
                Convert.ToInt32(reader["ID"]),
                Convert.ToBoolean(reader["Availability"]),
                Convert.ToInt32(reader["Room"]),
                Convert.ToString(reader["Category"]),
                Convert.ToInt32(reader["Price"]));                

        }
    }
}
