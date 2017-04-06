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
    public class MediaSQLContext:IMediaContext
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

        public Media Insert(Media media)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Media (VideoName, VideoLink, ImageName, ImageLink, MediaType)" +
                    "VALUES (@videoname,@videolink,@imagename,@imagelink,@mediatype)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", media.Id);
                    command.Parameters.AddWithValue("videoname", media.Videoname);
                    command.Parameters.AddWithValue("videolink", media.Videolink);
                    command.Parameters.AddWithValue("imagename", media.Imagename);
                    command.Parameters.AddWithValue("imagelink", media.Imagelink);
                    command.Parameters.AddWithValue("mediatype", media.Mediatype);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Error:" + e.Message);
                        return null;
                    }
                }
                return media;
            }
        }
        public bool Update(Media media)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Media" +
                    " SET VideoName=@videoname, VideoLink=@videolink, ImageName=@imagename, ImageLink=@imagelink, MediaType=@mediatype" +
                    " WHERE ID=@id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("id", media.Id);
                    command.Parameters.AddWithValue("videoname", media.Videoname);
                    command.Parameters.AddWithValue("videolink", media.Videolink);
                    command.Parameters.AddWithValue("imagename", media.Imagename);
                    command.Parameters.AddWithValue("imagelink", media.Imagelink);
                    command.Parameters.AddWithValue("mediatype", media.Mediatype);
                    
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
            return new Media(
                Convert.ToInt32(reader["ID"]),
                Convert.ToString(reader["VideoName"]),
                Convert.ToString(reader["VideoLink"]),
                Convert.ToString(reader["ImageName"]),
                Convert.ToString(reader["ImageLink"]),
                Convert.ToInt32(reader["MediaType"]));

        }
    }
}
