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
    public class AccessSQLContext : IAccessContext
    {
        
        public Access AddRFID(Access access, Account acc)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Access (AccessStatus, AccountID, ReservationID)" +
                    "VALUES (@accesstat, @accID, @ResID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accesstat", false);
                    command.Parameters.AddWithValue("@accID", acc.Id);
                    command.Parameters.AddWithValue("@ResID", null);
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show(Convert.ToString(e));
                    }
                    return access;
                }

            }
        }

        public bool GainAccess(bool accessBool,/* Access access,*/ Account acc)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Access SET AccessStatus=@accesstatus WHERE AccountID IN (SELECT ID FROM Account WHERE Username=@username)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", acc.Username);
                    command.Parameters.AddWithValue("accesstatus", accessBool);
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

        public bool GetStatus(/*Access access,*/ Account acc)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT AccessStatus FROM Access WHERE ID IN (SELECT AccountID FROM Account WHERE Username=@username)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", acc.Username);
                    if (Convert.ToInt32(command.ExecuteNonQuery()) == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool RemoveRFID(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "DELETE FROM Access WHERE ID=@id";
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

        private Access CreateAccessFromReader(SqlDataReader reader)
        {
            return new Access(
                 Convert.ToInt32(reader["RFID"]),
                 Convert.ToBoolean(reader["AccessStatus"]));
        }
    }
}
