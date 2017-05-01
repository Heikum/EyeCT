using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProftaakEyectEvents;
using System.Data.SqlClient;

namespace ProftaakEyeCT.DAL
{
    public class ReactionSQLContext : IReactionContext
    {
        public List<Reaction> GetAll()
        {
          
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reaction> GetByPost(Post post)
        {
            List<Reaction> reactions = new List<Reaction>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "select distinct r.text, r.reactiondatetime, r.postid from reaction r, post where r.postid = @id";
                using (SqlCommand command = new SqlCommand(query, Database.Connection))
                {

                    command.Parameters.AddWithValue("@id", post.PostID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            reactions.Add(CreateReactionFromReader(reader));

                        }
                    }
                    
                }
               
            }
            return reactions;
        }



        public Reaction Insert(Reaction reaction)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Reaction (Text,ReactionID,ReactionDateTime,AccountID,PostID)" +
                    "VALUES (@Text, @ReactionID, @ReactionDateTime, @AccountID, @PostID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Text", reaction.Text);
                    command.Parameters.AddWithValue("@ReactionID", reaction.ReactionId);
                    command.Parameters.AddWithValue("@ReactionDateTime", reaction.ReactionDateTime);
                    command.Parameters.AddWithValue("@AccountID", reaction.AccountId);
                    command.Parameters.AddWithValue("@PostID", reaction.PostId);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        return null;
                    }
                }
                return reaction;
            }
        }

        public bool Update(Reaction reaction)
        {
            throw new NotImplementedException();
        }

        private Reaction CreateReactionFromReader(SqlDataReader reader)
        {
            return new Reaction(
                Convert.ToInt32(reader["PostId"]),
                Convert.ToString(reader["Text"]),
                Convert.ToDateTime(reader["ReactionDateTime"]));

        }
    }
}
