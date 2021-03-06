﻿using System;
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


        public List<Post> GetByUsername(string username)
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT P.*, M.*, A.*" +
                " FROM post p INNER JOIN Media M ON P.MediaID = M.ID" +
                " INNER JOIN Account A on P.AccountID = A.ID" +
                " WHERE A.Username = @username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
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

        public List<Post> GetAll()
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT P.*, M.*, A.*" +
                " FROM post p INNER JOIN Media M ON P.MediaID = M.ID" +
                " INNER JOIN Account A on P.AccountID = A.ID ORDER BY P.PostDateTime DESC";

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
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Post WHERE ID=@id";
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

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        //deze klopt nog niet
        public void InsertPost(Post post)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Post (MediaID, Text, PostDateTime, AccountID)" +
                    "VALUES (@mediaid, @text, @postdatetime, @accountid)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@mediaid", post.MediaID);
                    command.Parameters.AddWithValue("@text", post.Text);
                    command.Parameters.AddWithValue("@postdatetime", post.Postdatetime);
                    command.Parameters.AddWithValue("@accountid", post.AccountID);

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

        public bool UpdatePost(Post post)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Post SET Text = @text, PostDateTime = @postdatetime WHERE Id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@id", post.PostID);
                    command.Parameters.AddWithValue("@text", post.Text);
                    command.Parameters.AddWithValue("@postdatetime", post.Postdatetime);
                    command.ExecuteNonQuery();
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

        public List<Post> GetAllReportedPosts()
        {
            List<Post> posts = new List<Post>();

            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT DISTINCT P.*, M.*, A.*" +
                " FROM post p INNER JOIN Media M ON P.MediaID = M.ID" +
                " INNER JOIN Account A on P.AccountID = A.ID" +
                " RIGHT JOIN PostReport PR on p.ID = PR.PostID ";

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
        public List<string> GetReportPostComplaint(Post post)
        {
            List<string> complaint = new List<string>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT Complaint FROM PostReport WHERE PostID=@postid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("postid", post.PostID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            complaint.Add(reader.GetString(0));
                        }
                        
                    }
                    return complaint;

                }
            }
        }
        public bool RemoveComplaint(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM PostReport WHERE PostID=@id";
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
        public void InsertReportedPost(Post post, string complaint)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO PostReport (PostID, Complaint)" +
                    "VALUES (@postid, @complaint)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@postid", post.PostID);
                    command.Parameters.AddWithValue("@complaint", complaint);
                 

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

        private Post CreatePostFromReader(SqlDataReader reader)
        {
            return new Post(
                Convert.ToInt32(reader["Id"]),
                Convert.ToInt32(reader["MediaId"]),
                Convert.ToString(reader["Text"]),
                Convert.ToDateTime(reader["PostDateTime"]),
                Convert.ToInt32(reader["AccountID"]));

        }
    }
}
