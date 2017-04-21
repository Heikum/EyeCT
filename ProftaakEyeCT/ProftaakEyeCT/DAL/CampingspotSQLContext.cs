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
