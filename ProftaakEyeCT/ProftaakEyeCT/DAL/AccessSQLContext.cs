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
                string query = "INSERT INTO Access (AccessStatus, InsideStatus, AccountID, ReservationID)" +
                    "VALUES (@accesstat, @insidestat @accID, @ResID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accesstat", false);
                    command.Parameters.AddWithValue("@insidestat", false);
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
        // goeike
        public bool AddRFIDstatusnewaccount(int id)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "INSERT INTO Access (AccessStatus, InsideStatus, AccountID, ReservationID)" +
                    "VALUES (@accesstat, @insidestat, @accID, @ResID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accesstat", false);
                    command.Parameters.AddWithValue("@insidestat", false);
                    command.Parameters.AddWithValue("@accID", id);
                    Console.WriteLine(id);
                    command.Parameters.AddWithValue("@ResID", DBNull.Value);
                    command.ExecuteNonQuery();
                    }
                    return true;
                }
            }

        public string EventReservationAccess(int AccountID)
        {
            string EventString;
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT Event.Name FROM Account" +
                                    " INNER JOIN Access ON Access.AccountID = Account.ID" +
                                    " INNER JOIN Reservation ON Reservation.ID = Access.ReservationID" +
                                    " INNER JOIN Event ON Event.ID = Reservation.EventID" +
                                    " WHERE Access.AccessStatus = 1 AND Account.ID = @accID; ";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@accID", AccountID);
                    EventString = Convert.ToString(command.ExecuteScalar());
                }
            }
            return EventString;
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

        public List<Account> GetAllInside()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE ID IN (SELECT AccountId FROM Access WHERE InsideStatus = 1 AND AccessStatus = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public List<Account> GetAllOutside()
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT * FROM Account WHERE ID IN (SELECT AccountId FROM Access WHERE InsideStatus = 0 AND AccessStatus = 1)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            accounts.Add(CreateAccountFromReader(reader));
                        }
                    }
                }
            }
            return accounts;
        }

        public bool GetStatus(/*Access access, Account acc*/ string acc)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "SELECT AccessStatus FROM Access WHERE AccountID IN (SELECT ID FROM Account WHERE Username=@username)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", acc);
                    if (Convert.ToInt32(command.ExecuteScalar()) == 1)
                    {
                        return true;
                    }
                    else return false;
                }
            }
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

        public bool ReservationUpdate(int ReservationID, int AccountID)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Access SET Access.ReservationID = @resID , Access.AccessStatus = 1" +
                               "WHERE Access.AccountID = @accID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@resID", ReservationID);
                    command.Parameters.AddWithValue("@accID", AccountID);
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
                        return false;
                    }

                }
            }
            return false;
        }

        public bool UpdateInside(Account acc, bool access)
        {
            using (SqlConnection connection = Database.Connection)
            {
                string query = "UPDATE Access SET InsideStatus=@accesstatus WHERE AccountID IN (SELECT ID FROM Account WHERE Username=@username)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("username", acc.Username);
                    command.Parameters.AddWithValue("accesstatus", access);
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



        private Access CreateAccessFromReader(SqlDataReader reader)
        {
            return new Access(
                 Convert.ToInt32(reader["RFID"]),
                 Convert.ToBoolean(reader["AccessStatus"]));
        }

        private Account CreateAccountFromReader(SqlDataReader reader)
        {
            return new Account(
                 Convert.ToInt32(reader["ID"]),
                 Convert.ToString(reader["Kind"]),
                 Convert.ToInt32(reader["PersonID"]),
                 Convert.ToString(reader["Username"]),
                 Convert.ToString(reader["Emailadress"]),
                 Convert.ToString(reader["Password"]),
                 Convert.ToBoolean(reader["Rights"]));


        }
    }
}
