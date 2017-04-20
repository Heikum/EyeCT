using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProftaakEyectEvents;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProftaakEyeCT.DAL
{
    class PostSQLContext : IPostContext
    {


        public List<Post> GetAll()
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT P.*, M.*, A.*" +
                " FROM post p INNER JOIN Media M ON P.MediaID = M.ID" +
                " INNER JOIN Account A on P.AccountID = A.ID";

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
                                Student student = null;
                                Admin admin = null;
                                if (reader["MediaiD"] != DBNull.Value)
                                {
                                    //Kijken of er een image of een video bij de post hoort
                                    switch (Convert.ToInt32(reader["MediaType"]))
                                    {
                                        case 2:
                                            image = new Image(
                                                Convert.ToInt32(reader["Id"]),
                                                Convert.ToString(reader["ImageName"]),
                                                Convert.ToString(reader["ImageLink"]));
                                            post.AddImage(image);
                                            break;


                                        case 1:
                                            video = new Video(
                                                Convert.ToInt32(reader["Id"]),
                                                Convert.ToString(reader["VideoName"]),
                                                Convert.ToString(reader["VideoLink"]));
                                            post.AddVideo(video);
                                            break;

                                    }
                                }
                                if (reader["AccountID"] != DBNull.Value)
                                {
                                    
                                    switch (Convert.ToString(reader["Kind"]))
                                    {
                                        case "Student":
                                            student = new Student(
                                            Convert.ToString(reader["Username"]));
                                            post.AddStudent(student);
                                            break;

                                        case "Admin":
                                            admin = new Admin(
                                            Convert.ToString(reader["Username"]));
                                            post.AddAdmin(admin);
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
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Post (Text, PostDateTime, AccountID)" +
                    "SELECT Text, PostDateTime, A.ID" +
                    "FROM Post P  INNER JOIN Media M ON P.MediaID = M.ID" +
                    "INNER JOIN Account A ON P.AccountID = A.ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@text", post.Text);
                    command.Parameters.AddWithValue("@postdatetime", post.Postdatetime);

                

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                }
                return post;
            }
        }

        public bool Update(Post post)
        {
            throw new NotImplementedException();
        }

        private Post CreatePostFromReader(SqlDataReader reader)
        {
            return new Post(
                Convert.ToInt32(reader["Id"]),
                Convert.ToInt32(reader["MediaId"]),
                Convert.ToString(reader["Text"]),
                Convert.ToDateTime(reader["PostDateTime"]));

        }
    }
}
