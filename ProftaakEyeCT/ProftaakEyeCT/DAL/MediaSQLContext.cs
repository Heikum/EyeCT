using ProftaakEyectEvents;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProftaakEyeCT.DAL
{
    public class MediaSQLContext
    {
        public List<Media> GetAll()
        {
            List<Media> media = new List<Media>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Media ORDER BY ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            media.Add(CreateMediaFromReader(reader));
                        }
                    }
                }
            }
            return media;
        }


        public Media GetByName(string Name)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Media Where VideoName=@videoname LIMIT 1";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("videoname", Name);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return CreateMediaFromReader(reader);
                        }
                    }
                }
            }
            return null;
        }

        

        public bool Delete(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Media WHERE ID=@id";
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

        private Media CreateMediaFromReader(SqlDataReader reader)
        {
            return null;

        }
    }
}
