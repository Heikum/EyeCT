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
    public class MediaSQLContext: IMediaContext
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
            switch (Convert.ToInt32(reader["MediaType"]))
            {
                case 1:
                    return new Image(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["ImageName"]),
                        Convert.ToString(reader["ImageLink"]));

                case 2:
                    return new Video(
                        Convert.ToInt32(reader["Id"]),
                        Convert.ToString(reader["VideoName"]),
                        Convert.ToString(reader["VideoLink"]));
            }

            return null;


        }

        //Wordt gebruikt om de ID's van de media tabel gelijk te laten lopen met de posts
        public Media InsertNull()
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Media (VideoName,VideoLink,ImageName,ImageLink,MediaType)" +
                    "VALUES (@VideoName, @VideoLink, @ImageName, @ImageLink, @MediaType)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VideoName", DBNull.Value);
                    command.Parameters.AddWithValue("@VideoLink", DBNull.Value);
                    command.Parameters.AddWithValue("@ImageName", DBNull.Value);
                    command.Parameters.AddWithValue("@ImageLink", DBNull.Value);
                    command.Parameters.AddWithValue("@MediaType", 0);

                    
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        
                        
                    }
                }
                
            }
            return null;
        }

        public bool Update(Media media)
        {
            throw new NotImplementedException();
        }

        public Video Insert(Video video)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Media (VideoName,VideoLink,ImageName,ImageLink,MediaType)" +
                    "VALUES (@VideoName, @VideoLink, @ImageName, @ImageLink, @MediaType)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VideoName", video.VideoName);
                    command.Parameters.AddWithValue("@VideoLink", video.VideoLink);
                    command.Parameters.AddWithValue("@ImageName", DBNull.Value);
                    command.Parameters.AddWithValue("@ImageLink", DBNull.Value);
                    command.Parameters.AddWithValue("@MediaType", 1);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        

                    }
                }
                return video;

            }
        }

        public Image Insert(Image image)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Media (VideoName,VideoLink,ImageName,ImageLink,MediaType)" +
                    "VALUES (@VideoName, @VideoLink, @ImageName, @ImageLink, @MediaType)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VideoName", DBNull.Value);
                    command.Parameters.AddWithValue("@VideoLink", DBNull.Value);
                    command.Parameters.AddWithValue("@ImageName", image.ImageName);
                    command.Parameters.AddWithValue("@ImageLink", image.ImageLink);
                    command.Parameters.AddWithValue("@MediaType", 2);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        return null;
                    }
                }
                return image;
            }
        }

        public int GetId()
        {
            int userid;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT TOP 1 ID FROM Media ORDER BY ID DESC";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    userid = Convert.ToInt32(command.ExecuteScalar());
                    // het laatste id kiezen + 1 zodat het nieuwe id wordt verkregen en gebruikt kan worden
                    userid++;
                }
                return userid;
            }

           

        }
        
        // er moet nog een lege insert bij om de autoincrement gelijk te laten lopen
    }
}