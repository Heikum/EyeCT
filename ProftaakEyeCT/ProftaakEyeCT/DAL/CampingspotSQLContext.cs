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
        public List<CampingSpot> GetAllAvailable()
        {
            List<CampingSpot> campingspot = new List<CampingSpot>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM CampingSpots WHERE Availability = 1";

                //commit
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
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
