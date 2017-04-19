using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProftaakEyectEvents;
using System.Data.SqlClient;

namespace ProftaakEyeCT.DAL
{
    class PostSQLContext : IPostContext
    {


        public List<Post> GetAll()
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT P.*, M.VideoLink, M.ImageLink" +
                " FROM post p INNER JOIN Media M ON P.MediaID = M.ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Post post = this.CreatePostFromReader(reader);
                            if (post != null)
                            {
                                Image image = null;
                                Video video = null;
                                if (reader["MediaiD"] != DBNull.Value)
                                {
                                    switch (Convert.ToInt32(reader["MediaType"]))
                                    {
                                        case 1:
                                            image = new Image(
                                                Convert.ToInt32(reader["Id"]),
                                                Convert.ToString(reader["ImageName"]),
                                                Convert.ToString(reader["ImageLink"]));
                                            post.AddImage(image);
                                            break;


                                        case 2:
                                            video = new Video(
                                                Convert.ToInt32(reader["Id"]),
                                                Convert.ToString(reader["VideoName"]),
                                                Convert.ToString(reader["VideoLink"]));
                                            post.AddVideo(video);
                                            break;

                                    }

                                }


                                posts.Add(post);
                            }

                        }
                    }


                }
            }
            return posts;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Post Insert(Post post)
        {
            throw new NotImplementedException();
        }

        public bool Update(Post post)
        {
            throw new NotImplementedException();
        }

        private Post CreatePostFromReader(SqlDataReader reader)
        {
            return new Post(
                Convert.ToInt32(reader["Id"]),
                Convert.ToString(reader["Text"]),
                Convert.ToDateTime(reader["PostDateTime"]));

        }
    }
}
